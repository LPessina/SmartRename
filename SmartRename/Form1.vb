Imports System.IO.File
Imports System.Threading

Public Class Form1
    Private TextDropped() As String
    Private DirControllata As Boolean
    Private DirValida As Boolean

    Dim Estensione As String
    Dim Percorso As String
    Dim CambioEstensione As Boolean
    Dim NuovaEstensione As Boolean
    Dim NumerazioneAutomatica As Boolean
    Dim NumeroDiInizio As Long
    Dim NumerazionePostfissa As Boolean
    Dim LogFile As IO.StreamWriter = Nothing
    Dim filtro As String = ""
    Dim NomePrimoFile As String = ""

    Dim NumeroFileDaElaborare As Long = 0
    Dim Inizializzazione As Boolean = True
    Dim OriginalCaption As String

    Dim Lingua As String

    Private Sub SetLocale(ByVal locale_name As String)
        On Error Resume Next
        ' Reload the form using this locale.
        Static setting_locale As Boolean = False

        If setting_locale Then Exit Sub
        If Not Me.Created Then Exit Sub
        If Thread.CurrentThread.CurrentCulture.Name = locale_name Then Exit Sub

        setting_locale = True

        ' Make a CultureInfo.
        Dim culture_info As New Globalization.CultureInfo(locale_name)

        ' Make the thread use this locale.
        Thread.CurrentThread.CurrentUICulture = culture_info
        Thread.CurrentThread.CurrentCulture = culture_info

        ' Reload the form.
        If Me.components IsNot Nothing Then Me.components.Dispose()
        Me.Controls.Clear()
        Me.InitializeComponent()

        setting_locale = False
    End Sub

    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        On Error Resume Next
        MyDragDrop(e)
    End Sub

    Private Sub Form1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        On Error Resume Next
        MyDragEnter(e)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'Me.SuspendLayout()
        OriginalCaption = Me.Text
        Me.Text += "  [L.Pessina @2012)"
        Me.lbl_NumeroFIleTrovati2.Text = ""

        Me.txt_FiltroEstensione.Text = "JPG"
        Me.lbl_EstensioneCorrente.Text = "JPG"
        Me.txt_Modifica.Text = "XXX"
        Me.txt_NumeroCifre.Text = "3"
        Me.txt_Separatore.Text = "_"

        DirValida = False
        DirControllata = False
        Me.txt_Modifica.Top = Me.rb_Prefisso.Top
        Me.rb_Prefisso.Checked = True
        Me.NumericUpDown1.Value = 100
        Me.txt_NumeroStart.Text = Me.NumericUpDown1.Value
        Me.chk_NumerazioneAutomatica.Checked = False
        Set_NumerazioneAutomatica()
        Set_NuovaEstensione()
        Me.ProgressBar1.Visible = False
        Me.txt_FiltroEstensione.Focus()
        Me.txt_FiltroEstensione.Select(0, 0)
        'Me.NumeroCifre.Text = 3
        Me.NumericUpDown2.Value = 3

        Me.Num_EliminaDa.Value = 0
        Me.Num_EliminaNum.Value = 1
        Me.Num_InserisciDa.Value = 0

        Me.cmd_Avanti.Enabled = False
        Me.chk_ModificaNome.Checked = False
        Me.chk_ModificaEstensione.Checked = False

        ConteggiaFileTrovati()

        Inizializzazione = False
        GetEsempio()
        'Me.ResumeLayout()


    End Sub


    Private Sub Set_NumerazioneAutomatica()
        On Error Resume Next
        If Me.chk_NumerazioneAutomatica.Checked Then
            Me.lbl_NumeroStart.Visible = True
            Me.txt_NumeroStart.Visible = True
            Me.NumericUpDown1.Visible = True
            Me.NumericUpDown2.Visible = True
            Me.lbl_NumeroCifre.Visible = True
            Me.txt_NumeroCifre.Visible = True
            Me.rb_NumeroPrefisso.Visible = True
            Me.rb_NumeroSuffisso.Visible = True
            Me.rb_NumeroSuffisso.Checked = True
            Me.lbl_Separatore.Visible = True
            Me.txt_Separatore.Visible = True
        Else
            Me.lbl_NumeroStart.Visible = False
            Me.txt_NumeroStart.Visible = False
            Me.NumericUpDown1.Visible = False
            Me.rb_NumeroPrefisso.Visible = False
            Me.rb_NumeroSuffisso.Visible = False
            Me.NumericUpDown2.Visible = False
            Me.lbl_NumeroCifre.Visible = False
            Me.txt_NumeroCifre.Visible = False
            Me.lbl_Separatore.Visible = False
            Me.txt_Separatore.Visible = False
        End If

        If Not Inizializzazione Then GetEsempio()

    End Sub
    Private Sub Set_NuovaEstensione()
        On Error Resume Next
        If Me.chk_ModificaEstensione.Checked Then
            NuovaEstensione = True
            Me.txt_NuovaEstensione.Focus()
        Else
            NuovaEstensione = False
        End If

        If Not Inizializzazione Then GetEsempio()

    End Sub


    Private Function ValidaPath() As Boolean
        On Error Resume Next
        ValidaPath = True
        If DirControllata Then Exit Function

        If Me.txt_FilesPath.Text.Length > 0 Then
            If Not System.IO.Directory.Exists(Me.txt_FilesPath.Text.Trim) Then
                MsgBox("ATTENZIONE" & vbCrLf & "La directory specificata non esiste;" & vbCrLf & "Controllare il nome della directory", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, OriginalCaption & " - Attenzione")
                Me.txt_FilesPath.Focus()
                Me.txt_FilesPath.SelectAll()
                DirControllata = True
                DirValida = False
                ValidaPath = False
            Else
                DirControllata = True
                DirValida = True
                ValidaPath = True
            End If
        End If
    End Function
    Private Sub Rinomina()
        On Error Resume Next

        Percorso = Me.txt_FilesPath.Text

        If Percorso.Length = 0 Then
            MsgBox("ATTENZIONE!" & vbCrLf & "Selezionare la directory dove sono contenuti i file", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, OriginalCaption & " - Attenzione")
            Me.txt_FilesPath.Focus()
            Exit Sub
        End If

        Dim fList As String() = System.IO.Directory.GetFiles(Percorso, filtro)
        Dim conteggio As Long = 0
        conteggio = fList.Length


        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = conteggio
        Me.ProgressBar1.Visible = True

        Dim NewFileName As String

        Dim i As Long
        For i = 1 To conteggio

            If Me.chk_NumerazioneAutomatica.Checked Then
                NewFileName = GetNewFileName(fList(i - 1), CLng(Me.txt_NumeroStart.Text) + i - 1)
            Else
                NewFileName = GetNewFileName(fList(i - 1))
            End If

            Debug.Print(i & " - Renaming the file : " & fList(i - 1) & "  in: " & Percorso & "\" & NewFileName)
            FileSystem.Rename(fList(i - 1), Percorso & "\" & NewFileName)
            WriteLog(Percorso & "\" & fList(i - 1), Percorso & "\" & NewFileName)

            Me.ProgressBar1.Value += 1

        Next

        LogFile.Close()
        ConteggiaFileTrovati()
        MsgBox("Rinomina dei file terminata", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, OriginalCaption & " - Terminato")
        Me.ProgressBar1.Visible = False

    End Sub

    Private Sub WriteLog(ByVal OldFileName As String, ByVal NewFileName As String)
        On Error Resume Next
        If IsNothing(LogFile) Then
            LogFile = IO.File.CreateText(Application.StartupPath & "\undo_" & Format(Now.Year, "0000") & Format(Now.Month, "00") & Format(Now.Day, "00") & "-" & Format(Now.Hour, "00") & Format(Now.Minute, "00") & Format(Now.Second, "00") & ".txt")
        End If
        LogFile.WriteLine(OldFileName & ";" & NewFileName)
        LogFile.Flush()
    End Sub

    Private Function GetNewFileName(ByVal currentFileName As String, Optional ByVal numero As Integer = -1) As String
        On Error Resume Next

        Dim MyDir As String = ""
        Dim OldFileName As String = ""
        Dim OldExtension As String = ""
        Dim NewExtension As String = ""
        Dim NewFileName As String = ""
        Dim i As Long = 0
        Dim stringaFormato
        Dim NumeroCifre As Integer

        Dim Separatore As String
        Separatore = Me.txt_Separatore.Text


        MyDir = System.IO.Path.GetDirectoryName(currentFileName)
        OldFileName = System.IO.Path.GetFileNameWithoutExtension(currentFileName)
        OldExtension = System.IO.Path.GetExtension(currentFileName).Substring(1)

        '** Estensione
        If NuovaEstensione Then
            NewExtension = Me.txt_NuovaEstensione.Text
        Else
            NewExtension = OldExtension
        End If



        '** FileName
        If Me.chk_ModificaNome.Checked Then
            If Me.rb_Prefisso.Checked Or Me.rb_Suffisso.Checked Or Me.rb_Rinomina.Checked Then

                NumeroCifre = IIf(Len(Me.txt_NumeroCifre.Text & "") > 0, Me.txt_NumeroCifre.Text, 3)
                stringaFormato = New String("0", NumeroCifre)

                If Me.rb_Rinomina.Checked Then
                    If Me.rb_NumeroPrefisso.Checked Then
                        NewFileName = Format(numero, stringaFormato) & IIf(Separatore.Length > 0, Separatore, "") & Me.txt_Modifica.Text
                    Else
                        If numero >= 0 Then
                            NewFileName = Me.txt_Modifica.Text & IIf(Separatore.Length > 0, Separatore, "") & Format(numero, stringaFormato)
                        Else
                            NewFileName = Me.txt_Modifica.Text
                        End If
                    End If
                Else
                    If Me.rb_Suffisso.Checked Then
                        If Me.chk_NumerazioneAutomatica.Checked Then
                            If Me.rb_NumeroPrefisso.Checked Then
                                NewFileName = numero & IIf(Separatore.Length > 0, Separatore, "") & OldFileName & Me.txt_Modifica.Text
                            Else
                                NewFileName = OldFileName & Me.txt_Modifica.Text & IIf(Separatore.Length > 0, Separatore, "") & Format(numero, stringaFormato)
                            End If
                        Else
                            NewFileName = OldFileName & Me.txt_Modifica.Text
                        End If
                    End If

                    If Me.rb_Prefisso.Checked Then
                        If Me.chk_NumerazioneAutomatica.Checked Then
                            If Me.rb_NumeroPrefisso.Checked Then
                                NewFileName = Format(numero, stringaFormato) & IIf(Separatore.Length > 0, Separatore, "") & Me.txt_Modifica.Text & OldFileName
                            Else
                                NewFileName = Me.txt_Modifica.Text & OldFileName & IIf(Separatore.Length > 0, Separatore, "") & Format(numero, stringaFormato)
                            End If
                        Else
                            NewFileName = Me.txt_Modifica.Text & OldFileName
                        End If
                    End If
                End If
            Else
                NewFileName = OldFileName
            End If
        End If

        GetNewFileName = NewFileName & "." & NewExtension

    End Function

    Private Sub GetEsempio()
        On Error Resume Next
        Dim NewFileName As String
        If Me.chk_NumerazioneAutomatica.Checked Then
            'If NomePrimoFile.Length = 0 Then
            NewFileName = GetNewFileName("ESEMPIO." & Me.txt_FiltroEstensione.Text, Me.txt_NumeroStart.Text)
            'Else
            'NewFileName = GetNewFileName(NomePrimoFile, Me.txt_NumeroStart.Text)
            'End If
        Else
            'If NomePrimoFile.Length = 0 Then
            NewFileName = GetNewFileName("ESEMPIO." & Me.txt_FiltroEstensione.Text)
            'Else
            'NewFileName = GetNewFileName(NomePrimoFile)
            'End If
        End If
        Me.txt_Esempio.Text = NewFileName
    End Sub

    Private Sub cmd_Chiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Me.Close()
    End Sub


    Private Sub ConteggiaFileTrovati()
        On Error Resume Next
        filtro = ""
        Estensione = Me.txt_FiltroEstensione.Text.Trim
        If Estensione.Length = 0 Then Estensione = "*"
        If Me.txt_FiltroNome.Text.Trim.Length > 0 Then
            filtro = Me.txt_FiltroNome.Text.Trim
        Else
            filtro = "*"
        End If
        filtro = filtro & "." & Estensione
        Me.lbl_filtro.Text = filtro

        Percorso = Me.txt_FilesPath.Text.Trim
        If Percorso.Length > 0 Then
            Dim fList As String() = System.IO.Directory.GetFiles(Percorso, filtro)
            If Err.Number <> 0 Then
                'MsgBox("ATTENZIONE!" & vbCrLf & "Il percorso specificato non esiste." & vbCrLf & "Controllare il percorso", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Attenzione")
                'Me.txt_FilesPath.Focus()
                Me.lbl_NumeroFIleTrovati.Text = "0 files"
                Exit Sub
            End If
            NumeroFileDaElaborare = fList.Length

            If NumeroFileDaElaborare = 0 Then
                MsgBox("ATTENZIONE!" & vbCrLf & "Non è stato trovato nessun file che soddisfa il filtro [" & filtro & "]" & vbCrLf & _
                "nel percorso specificato." & vbCrLf & "Controllare l'estensione od il percorso specificati", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, OriginalCaption & " - Attenzione")
                'Me.txt_FiltroEstensione.Focus()
            Else
                NomePrimoFile = fList.GetValue(0)
            End If

            Me.lbl_NumeroFIleTrovati.Text = NumeroFileDaElaborare & " files"

        End If

    End Sub


    Private Function GetResource(ByVal name As String) As String
        On Error Resume Next
        'Dim rm As Resources.ResourceManager = New Resources.ResourceManager("MyProjectName.My.Resources.Resources", [Assembly].GetExecutingAssembly())
        'Dim myValue = rm.GetString(name)

        'My.Resources.ResourceManager
        GetResource = ""

    End Function

    Private Sub ItalianoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalianoToolStripMenuItem.Click
        On Error Resume Next
        SetLocale("it-IT")
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnglishToolStripMenuItem.Click
        On Error Resume Next
        SetLocale("en-US")
    End Sub


    Private Sub cmd_ChoosePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ChoosePath.Click
        On Error Resume Next
        Dim ThePath As String
        DirControllata = False
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ThePath = Me.FolderBrowserDialog1.SelectedPath
            Me.txt_FilesPath.Text = ThePath
        End If
        ValidaPath()
        ConteggiaFileTrovati()

    End Sub

    Private Sub txt_FilesPath_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txt_FilesPath.DragDrop
        On Error Resume Next
        MyDragDrop(e)
    End Sub

    Private Sub MyDragDrop(ByVal e As System.Windows.Forms.DragEventArgs)
        On Error Resume Next
        Me.txt_FilesPath.Text = TextDropped(0)
        ValidaPath()
        ConteggiaFileTrovati()
        GetEsempio()
    End Sub
    Private Sub txt_FilesPath_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txt_FilesPath.DragEnter
        On Error Resume Next
        MyDragEnter(e)
    End Sub
    Private Sub MyDragEnter(ByVal e As System.Windows.Forms.DragEventArgs)
        On Error Resume Next
        Array.Resize(TextDropped, 0)
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            ' Display the copy cursor.
            e.Effect = DragDropEffects.Copy
        Else
            ' Display the no-drop cursor.
            e.Effect = DragDropEffects.None
        End If
        TextDropped = e.Data.GetData(DataFormats.FileDrop)
    End Sub
    Private Sub txt_FilesPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FilesPath.TextChanged
        On Error Resume Next
        DirValida = False
        DirControllata = False
    End Sub


    Private Sub txt_FiltroEstensione_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FiltroEstensione.Validated
        On Error Resume Next
        Me.lbl_EstensioneCorrente.Text = Me.txt_FiltroEstensione.Text.Trim
        ConteggiaFileTrovati()
    End Sub

    Private Sub txt_FiltroNome_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FiltroNome.Validated
        On Error Resume Next
        ConteggiaFileTrovati()
    End Sub

    Private Sub lbl_NumeroFIleTrovati_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_NumeroFIleTrovati.TextChanged
        On Error Resume Next
        lbl_NumeroFIleTrovati2.Text = lbl_NumeroFIleTrovati.Text & " interessati alla trasformazione"
    End Sub

    Private Sub Button_CheckFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_CheckFilter.Click
        On Error Resume Next
        ConteggiaFileTrovati()
    End Sub

    Private Sub chk_NuovaEstensione_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Set_NuovaEstensione()
    End Sub

    Private Sub rb_Prefisso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Prefisso.CheckedChanged
        On Error Resume Next
        If Me.rb_Prefisso.Checked Then
            Me.txt_Modifica.Top = Me.rb_Prefisso.Top
            Me.txt_Modifica.Enabled = True
            Me.GroupBox3.Enabled = True
            Me.grp_Inserisci.Enabled = False
            Me.grp_Rimpiazza.Enabled = False
            Me.grp_Elimina.Enabled = False

            Me.chk_NumerazioneAutomatica.Enabled = True
            Me.chk_NumerazioneAutomatica.Checked = False
            Set_NumerazioneAutomatica()
            Me.txt_Modifica.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub rb_Suffisso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Suffisso.CheckedChanged
        On Error Resume Next
        If Me.rb_Suffisso.Checked Then
            Me.txt_Modifica.Top = Me.rb_Suffisso.Top
            Me.txt_Modifica.Enabled = True
            Me.GroupBox3.Enabled = True
            Me.grp_Inserisci.Enabled = False
            Me.grp_Rimpiazza.Enabled = False
            Me.grp_Elimina.Enabled = False

            Me.chk_NumerazioneAutomatica.Enabled = True
            Me.chk_NumerazioneAutomatica.Checked = False
            Set_NumerazioneAutomatica()
            Me.txt_Modifica.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub rb_Rinomina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Rinomina.CheckedChanged
        On Error Resume Next
        If Me.rb_Rinomina.Checked Then
            Me.txt_Modifica.Top = Me.rb_Rinomina.Top
            Me.txt_Modifica.Enabled = True
            Me.GroupBox3.Enabled = True
            Me.grp_Inserisci.Enabled = False
            Me.grp_Rimpiazza.Enabled = False
            Me.grp_Elimina.Enabled = False

            Me.chk_NumerazioneAutomatica.Checked = True
            Set_NumerazioneAutomatica()
            Me.chk_NumerazioneAutomatica.Enabled = False
            Me.txt_Modifica.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_NuovaEstensione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_NuovaEstensione.TextChanged
        On Error Resume Next
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_Modifica_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Modifica.TextChanged
        On Error Resume Next
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub chk_NumerazioneAutomatica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_NumerazioneAutomatica.CheckedChanged
        On Error Resume Next
        Set_NumerazioneAutomatica()
    End Sub

    Private Sub rb_NumeroPrefisso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_NumeroPrefisso.CheckedChanged
        On Error Resume Next
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub rb_NumeroSuffisso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_NumeroSuffisso.CheckedChanged
        On Error Resume Next
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_NumeroStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NumeroStart.Click
        On Error Resume Next
        Me.txt_NumeroStart.SelectAll()
    End Sub

    Private Sub txt_NumeroStart_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NumeroStart.Leave
        On Error Resume Next
        Me.NumericUpDown1.Value = Me.txt_NumeroStart.Text
    End Sub

    Private Sub txt_NumeroStart_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NumeroStart.TextChanged
        On Error Resume Next
        Me.NumericUpDown2.Minimum = Trim(Me.txt_NumeroStart.Text).Length
        If Trim(Me.txt_NumeroStart.Text).Length > CInt(Trim(Me.txt_NumeroCifre.Text)) Then
            Me.txt_NumeroCifre.Text = Me.txt_NumeroStart.Text.Length.ToString
            Application.DoEvents()
        End If
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_FilesPath_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_FilesPath.Validating
        On Error Resume Next
        If Not ValidaPath() Then
            e.Cancel = True
        End If
        ConteggiaFileTrovati()
        GetEsempio()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        On Error Resume Next
        Me.txt_NumeroStart.Text = Me.NumericUpDown1.Value
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        On Error Resume Next
        Me.txt_NumeroCifre.Text = Me.NumericUpDown2.Value
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_Separatore_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Separatore.TextChanged
        On Error Resume Next
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub txt_NumeroCifre_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NumeroCifre.TextChanged
        On Error Resume Next
        Me.NumericUpDown2.Value = CInt(Me.txt_NumeroCifre.Text)
        If Not Inizializzazione Then GetEsempio()
    End Sub


    Private Sub rb_Rimpiazza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Rimpiazza.CheckedChanged
        On Error Resume Next
        If Me.rb_Rimpiazza.Checked Then
            'Me.txt_Modifica.Text = ""
            Me.txt_Modifica.Enabled = False
            Me.chk_NumerazioneAutomatica.Enabled = False
            Me.GroupBox3.Enabled = False

            Me.grp_Elimina.Enabled = False
            Me.grp_Inserisci.Enabled = False
            Me.grp_Rimpiazza.Enabled = True

            Me.txt_Trova.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()

    End Sub


    Private Sub rb_Elimina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Elimina.CheckedChanged
        On Error Resume Next
        If Me.rb_Elimina.Checked Then
            'Me.txt_Modifica.Text = ""
            Me.txt_Modifica.Enabled = False
            Me.chk_NumerazioneAutomatica.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.grp_Elimina.Enabled = True
            Me.grp_Inserisci.Enabled = False
            Me.grp_Rimpiazza.Enabled = False
            Me.txt_EliminaDa.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()

    End Sub

    Private Sub rb_Inserisci_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Inserisci.CheckedChanged
        On Error Resume Next
        If Me.rb_Inserisci.Checked Then
            'Me.txt_Modifica.Text = ""
            Me.txt_Modifica.Enabled = False
            Me.chk_NumerazioneAutomatica.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.grp_Elimina.Enabled = False
            Me.grp_Inserisci.Enabled = True
            Me.grp_Rimpiazza.Enabled = False
            Me.txt_InserisciDa.Focus()
        End If
        If Not Inizializzazione Then GetEsempio()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        On Error Resume Next

        Dim st = Me.TabControl1.SelectedTab.Name
        If st.ToString.ToUpper = "TAB_TRANSFORMATION" Then
            AbilitaElaborazione()
        End If
    End Sub

    Private Sub AbilitaElaborazione()
        On Error Resume Next
        If DirValida And NumeroFileDaElaborare > 0 Then
            Me.chk_ModificaEstensione.Enabled = True
            Me.chk_ModificaNome.Enabled = True
            If Me.chk_ModificaEstensione.Checked Then Me.GroupBox_EstensioneFile.Enabled = True
            If Me.chk_ModificaNome.Checked Then Me.GroupBox_NomeFile.Enabled = True
            Me.cmd_Rinomina.Enabled = Me.chk_ModificaEstensione.Checked Or Me.chk_ModificaNome.Checked

            Me.cmd_Avanti.Enabled = True

        Else
            Me.GroupBox_EstensioneFile.Enabled = False
            Me.GroupBox_NomeFile.Enabled = False
            Me.cmd_Rinomina.Enabled = False
            Me.cmd_Avanti.Enabled = False
            Me.chk_ModificaEstensione.Enabled = False
            Me.chk_ModificaNome.Enabled = False
        End If
    End Sub

    Private Sub Num_EliminaDa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_EliminaDa.ValueChanged
        On Error Resume Next
        Me.txt_EliminaDa.Text = Me.Num_EliminaDa.Value
    End Sub

    Private Sub Num_EliminaNum_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_EliminaNum.ValueChanged
        On Error Resume Next
        Me.txt_EliminaNumCaratteri.Text = Me.Num_EliminaNum.Value
    End Sub

    Private Sub Num_InserisciDa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num_InserisciDa.ValueChanged
        On Error Resume Next
        Me.txt_InserisciDa.Text = Me.Num_InserisciDa.Value
    End Sub

    Private Sub cmd_Rinomina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Rinomina.Click
        On Error Resume Next

        '--- RIMPIAZZA
        If Me.rb_Rimpiazza.Checked Then
            Dim Trova As String = Me.txt_Trova.Text.Trim
            If Trova.Length = 0 Then
                MsgBox("Stringa TROVA non valida", MsgBoxStyle.Exclamation, OriginalCaption & " - Attenzione")
                Exit Sub
            End If
            Dim Sostituisci As String = Me.txt_Sostituisci.Text.Trim
            If Sostituisci.Length = 0 Then
                MsgBox("Stringa SOSTITUISCI non valida", MsgBoxStyle.Exclamation, OriginalCaption & " - Attenzione")
                Exit Sub
            End If
            RimpiazzaStringa(Trova, Sostituisci)
            Exit Sub
        End If

        '--- INSERISCI
        If Me.rb_Inserisci.Checked Then
            Dim Inserisci As String = Me.txt_Inserisci.Text.Trim
            If Inserisci.Length = 0 Then
                MsgBox("Stringa INSERISCI non valida", MsgBoxStyle.Exclamation, OriginalCaption & " - Attenzione")
                Exit Sub
            End If
            Dim PosInserimento = CInt(Me.txt_InserisciDa.Text.Trim)
            InserisciStringa(Inserisci, PosInserimento)
            Exit Sub
        End If

        '--- ELIMINA
        If Me.rb_Elimina.Checked Then
            Dim NumeroCarDaEliminare As String = Me.txt_EliminaNumCaratteri.Text.Trim
            Dim PosEliminazione = CInt(Me.txt_EliminaDa.Text.Trim)
            EliminaStringa(PosEliminazione, NumeroCarDaEliminare)
            Exit Sub
        End If

        Rinomina()

    End Sub
    Private Sub EliminaStringa(ByVal PosEliminazione As Integer, ByVal NumCaratteri As Integer)
        On Error Resume Next

        Percorso = Me.txt_FilesPath.Text

        If Percorso.Length = 0 Then
            MsgBox("ATTENZIONE!" & vbCrLf & "Selezionare la directory dove sono contenuti i file", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, OriginalCaption & " - Attenzione")
            Me.txt_FilesPath.Focus()
            Exit Sub
        End If

        Dim fList As String() = System.IO.Directory.GetFiles(Percorso, filtro)
        Dim conteggio As Long = 0
        conteggio = fList.Length

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = conteggio
        Me.ProgressBar1.Visible = True

        Dim OldFileName As String
        Dim NewFileName As String


        Dim i As Long
        For i = 1 To conteggio

            OldFileName = IO.Path.GetFileNameWithoutExtension(fList(i - 1))
            NewFileName = OldFileName.Remove(PosEliminazione, NumCaratteri)

            '** Estensione
            If NuovaEstensione Then
                OldFileName = OldFileName & "." & Me.txt_NuovaEstensione.Text.Trim
                NewFileName = NewFileName & "." & Me.txt_NuovaEstensione.Text.Trim
            Else
                OldFileName = OldFileName & "." & Estensione
                NewFileName = NewFileName & "." & Estensione
            End If

            If NewFileName <> OldFileName Then
                Debug.Print(i & " - Renaming the file : " & fList(i - 1) & "  in: " & Percorso & "\" & NewFileName)
                FileSystem.Rename(fList(i - 1), Percorso & "\" & NewFileName)
                WriteLog(Percorso & "\" & fList(i - 1), Percorso & "\" & NewFileName)
            End If
            Me.ProgressBar1.Value += 1

        Next

        LogFile.Close()
        ConteggiaFileTrovati()
        MsgBox("Rinomina dei file terminata", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, OriginalCaption)
        Me.ProgressBar1.Visible = False



    End Sub
    Private Sub InserisciStringa(ByVal StringaDaInserire As String, ByVal Posizione As Integer)
        On Error Resume Next

        Percorso = Me.txt_FilesPath.Text

        If Percorso.Length = 0 Then
            MsgBox("ATTENZIONE!" & vbCrLf & "Selezionare la directory dove sono contenuti i file", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, OriginalCaption & " - Attenzione")
            Me.txt_FilesPath.Focus()
            Exit Sub
        End If

        Dim fList As String() = System.IO.Directory.GetFiles(Percorso, filtro)
        Dim conteggio As Long = 0
        conteggio = fList.Length

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = conteggio
        Me.ProgressBar1.Visible = True

        Dim OldFileName As String
        Dim NewFileName As String

        Dim i As Long
        For i = 1 To conteggio

            OldFileName = IO.Path.GetFileNameWithoutExtension(fList(i - 1))
            NewFileName = OldFileName.Insert(Posizione, StringaDaInserire)

            '** Estensione
            If NuovaEstensione Then
                OldFileName = OldFileName & "." & Me.txt_NuovaEstensione.Text.Trim
                NewFileName = NewFileName & "." & Me.txt_NuovaEstensione.Text.Trim
            Else
                OldFileName = OldFileName & "." & Estensione
                NewFileName = NewFileName & "." & Estensione
            End If

            If NewFileName <> OldFileName Then
                Debug.Print(i & " - Renaming the file : " & fList(i - 1) & "  in: " & Percorso & "\" & NewFileName)
                FileSystem.Rename(fList(i - 1), Percorso & "\" & NewFileName)
                WriteLog(Percorso & "\" & fList(i - 1), Percorso & "\" & NewFileName)
            End If
            Me.ProgressBar1.Value += 1

        Next

        LogFile.Close()
        ConteggiaFileTrovati()
        MsgBox("Rinomina dei file terminata", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, OriginalCaption & " - Terminato")
        Me.ProgressBar1.Visible = False


    End Sub
    Private Sub RimpiazzaStringa(ByVal Trova As String, ByVal Sostituisci As String)
        On Error Resume Next

        Percorso = Me.txt_FilesPath.Text

        If Percorso.Length = 0 Then
            MsgBox("ATTENZIONE!" & vbCrLf & "Selezionare la directory dove sono contenuti i file", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, OriginalCaption & " - Attenzione")
            Me.txt_FilesPath.Focus()
            Exit Sub
        End If

        Dim fList As String() = System.IO.Directory.GetFiles(Percorso, filtro)
        Dim conteggio As Long = 0
        conteggio = fList.Length

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = conteggio
        Me.ProgressBar1.Visible = True

        Dim OldFileName As String
        Dim NewFileName As String

        Dim i As Long
        For i = 1 To conteggio

            oldFileName = IO.Path.GetFileNameWithoutExtension(fList(i - 1))
            NewFileName = OldFileName.Replace(Trova, Sostituisci)

            '** Estensione
            If NuovaEstensione Then
                OldFileName = OldFileName & "." & Me.txt_NuovaEstensione.Text.Trim
                NewFileName = NewFileName & "." & Me.txt_NuovaEstensione.Text.Trim
            Else
                OldFileName = OldFileName & "." & Estensione
                NewFileName = NewFileName & "." & Estensione
            End If

            If NewFileName <> OldFileName Then
                Debug.Print(i & " - Renaming the file : " & fList(i - 1) & "  in: " & Percorso & "\" & NewFileName)
                FileSystem.Rename(fList(i - 1), Percorso & "\" & NewFileName)
                WriteLog(Percorso & "\" & fList(i - 1), Percorso & "\" & NewFileName)
            End If
            Me.ProgressBar1.Value += 1

        Next

        LogFile.Close()
        ConteggiaFileTrovati()
        MsgBox("Rinomina dei file terminata", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, OriginalCaption)
        Me.ProgressBar1.Visible = False


    End Sub

    Private Sub cmd_Avanti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Avanti.Click
        On Error Resume Next
        Me.TabControl1.SelectTab(1)
    End Sub

    Private Sub lbl_NumeroFIleTrovati2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_NumeroFIleTrovati2.TextChanged
        On Error Resume Next
        AbilitaElaborazione()
    End Sub

    Private Sub Tab_Source_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Tab_Source.DragDrop
        On Error Resume Next
        MyDragDrop(e)

    End Sub

    Private Sub Tab_Source_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Tab_Source.DragEnter
        On Error Resume Next
        MyDragEnter(e)
    End Sub

    Private Sub Label_Titolo_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Label_Titolo.DragDrop
        On Error Resume Next
        MyDragDrop(e)

    End Sub


    Private Sub Label_Titolo_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Label_Titolo.DragEnter
        On Error Resume Next
        MyDragEnter(e)
    End Sub

    Private Sub Label_Directory_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Label_Directory.DragDrop
        On Error Resume Next
        MyDragDrop(e)
    End Sub

    Private Sub Label_Directory_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Label_Directory.DragEnter
        On Error Resume Next
        MyDragEnter(e)
    End Sub

    Private Sub chk_ModificaEstensione_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ModificaEstensione.CheckedChanged
        On Error Resume Next
        NuovaEstensione = Me.chk_ModificaEstensione.Checked
        Me.GroupBox_EstensioneFile.Enabled = Me.chk_ModificaEstensione.Checked
        AbilitaElaborazione()
    End Sub

    Private Sub chk_ModificaNome_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ModificaNome.CheckedChanged
        On Error Resume Next
        Me.GroupBox_NomeFile.Enabled = Me.chk_ModificaNome.Checked
        AbilitaElaborazione()
    End Sub

    Private Sub cmd_Indietro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Indietro.Click
        On Error Resume Next
        Me.TabControl1.SelectTab(0)
    End Sub
End Class
