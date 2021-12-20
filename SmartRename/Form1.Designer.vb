<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Menu_Strumenti = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Linguaggio = New System.Windows.Forms.ToolStripMenuItem
        Me.ItalianoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Info = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_Source = New System.Windows.Forms.TabPage
        Me.cmd_Avanti = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button_CheckFilter = New System.Windows.Forms.Button
        Me.Label_Filter = New System.Windows.Forms.Label
        Me.lbl_filtro = New System.Windows.Forms.Label
        Me.lbl_NumeroFIleTrovati = New System.Windows.Forms.Label
        Me.Label_Titolo = New System.Windows.Forms.Label
        Me.cmd_ChoosePath = New System.Windows.Forms.Button
        Me.GroupBox_FiltroFile = New System.Windows.Forms.GroupBox
        Me.Label_HelpFilter = New System.Windows.Forms.Label
        Me.Label_FiltroEstensione = New System.Windows.Forms.Label
        Me.txt_FiltroEstensione = New System.Windows.Forms.TextBox
        Me.Label_FiltroNome = New System.Windows.Forms.Label
        Me.txt_FiltroNome = New System.Windows.Forms.TextBox
        Me.Label_HelpDirectory = New System.Windows.Forms.Label
        Me.Label_Directory = New System.Windows.Forms.Label
        Me.txt_FilesPath = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Tab_Transformation = New System.Windows.Forms.TabPage
        Me.chk_ModificaNome = New System.Windows.Forms.CheckBox
        Me.cmd_Rinomina = New System.Windows.Forms.Button
        Me.Label_Esempio = New System.Windows.Forms.Label
        Me.txt_Esempio = New System.Windows.Forms.TextBox
        Me.GroupBox_NomeFile = New System.Windows.Forms.GroupBox
        Me.rb_Inserisci = New System.Windows.Forms.RadioButton
        Me.rb_Elimina = New System.Windows.Forms.RadioButton
        Me.rb_Rimpiazza = New System.Windows.Forms.RadioButton
        Me.txt_Modifica = New System.Windows.Forms.TextBox
        Me.rb_Rinomina = New System.Windows.Forms.RadioButton
        Me.rb_Suffisso = New System.Windows.Forms.RadioButton
        Me.rb_Prefisso = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_Separatore = New System.Windows.Forms.MaskedTextBox
        Me.lbl_Separatore = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.txt_NumeroCifre = New System.Windows.Forms.MaskedTextBox
        Me.lbl_NumeroCifre = New System.Windows.Forms.Label
        Me.rb_NumeroSuffisso = New System.Windows.Forms.RadioButton
        Me.rb_NumeroPrefisso = New System.Windows.Forms.RadioButton
        Me.txt_NumeroStart = New System.Windows.Forms.MaskedTextBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.lbl_NumeroStart = New System.Windows.Forms.Label
        Me.chk_NumerazioneAutomatica = New System.Windows.Forms.CheckBox
        Me.grp_Rimpiazza = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Sostituisci = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Trova = New System.Windows.Forms.TextBox
        Me.grp_Elimina = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Num_EliminaNum = New System.Windows.Forms.NumericUpDown
        Me.txt_EliminaNumCaratteri = New System.Windows.Forms.MaskedTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_EliminaDa = New System.Windows.Forms.MaskedTextBox
        Me.Num_EliminaDa = New System.Windows.Forms.NumericUpDown
        Me.grp_Inserisci = New System.Windows.Forms.GroupBox
        Me.txt_Inserisci = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_InserisciDa = New System.Windows.Forms.MaskedTextBox
        Me.Num_InserisciDa = New System.Windows.Forms.NumericUpDown
        Me.GroupBox_EstensioneFile = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbl_EstensioneCorrente = New System.Windows.Forms.Label
        Me.txt_NuovaEstensione = New System.Windows.Forms.TextBox
        Me.chk_ModificaEstensione = New System.Windows.Forms.CheckBox
        Me.lbl_NumeroFIleTrovati2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.ts_Stato = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbl_nuovaestensione = New System.Windows.Forms.Label
        Me.cmd_Indietro = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Source.SuspendLayout()
        Me.GroupBox_FiltroFile.SuspendLayout()
        Me.Tab_Transformation.SuspendLayout()
        Me.GroupBox_NomeFile.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Rimpiazza.SuspendLayout()
        Me.grp_Elimina.SuspendLayout()
        CType(Me.Num_EliminaNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_EliminaDa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Inserisci.SuspendLayout()
        CType(Me.Num_InserisciDa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_EstensioneFile.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Strumenti, Me.Menu_Info})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'Menu_Strumenti
        '
        Me.Menu_Strumenti.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Linguaggio})
        Me.Menu_Strumenti.Name = "Menu_Strumenti"
        resources.ApplyResources(Me.Menu_Strumenti, "Menu_Strumenti")
        '
        'Menu_Linguaggio
        '
        Me.Menu_Linguaggio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItalianoToolStripMenuItem, Me.EnglishToolStripMenuItem})
        Me.Menu_Linguaggio.Name = "Menu_Linguaggio"
        resources.ApplyResources(Me.Menu_Linguaggio, "Menu_Linguaggio")
        '
        'ItalianoToolStripMenuItem
        '
        Me.ItalianoToolStripMenuItem.Name = "ItalianoToolStripMenuItem"
        resources.ApplyResources(Me.ItalianoToolStripMenuItem, "ItalianoToolStripMenuItem")
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        '
        'Menu_Info
        '
        Me.Menu_Info.Name = "Menu_Info"
        resources.ApplyResources(Me.Menu_Info, "Menu_Info")
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Controls.Add(Me.Tab_Source)
        Me.TabControl1.Controls.Add(Me.Tab_Transformation)
        Me.TabControl1.HotTrack = True
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'Tab_Source
        '
        Me.Tab_Source.AllowDrop = True
        Me.Tab_Source.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_Source.Controls.Add(Me.cmd_Avanti)
        Me.Tab_Source.Controls.Add(Me.Label1)
        Me.Tab_Source.Controls.Add(Me.Button_CheckFilter)
        Me.Tab_Source.Controls.Add(Me.Label_Filter)
        Me.Tab_Source.Controls.Add(Me.lbl_filtro)
        Me.Tab_Source.Controls.Add(Me.lbl_NumeroFIleTrovati)
        Me.Tab_Source.Controls.Add(Me.Label_Titolo)
        Me.Tab_Source.Controls.Add(Me.cmd_ChoosePath)
        Me.Tab_Source.Controls.Add(Me.GroupBox_FiltroFile)
        Me.Tab_Source.Controls.Add(Me.Label_HelpDirectory)
        Me.Tab_Source.Controls.Add(Me.Label_Directory)
        Me.Tab_Source.Controls.Add(Me.txt_FilesPath)
        Me.Tab_Source.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.Tab_Source, "Tab_Source")
        Me.Tab_Source.Name = "Tab_Source"
        '
        'cmd_Avanti
        '
        resources.ApplyResources(Me.cmd_Avanti, "cmd_Avanti")
        Me.cmd_Avanti.Name = "cmd_Avanti"
        Me.cmd_Avanti.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Name = "Label1"
        '
        'Button_CheckFilter
        '
        resources.ApplyResources(Me.Button_CheckFilter, "Button_CheckFilter")
        Me.Button_CheckFilter.Name = "Button_CheckFilter"
        Me.Button_CheckFilter.UseVisualStyleBackColor = True
        '
        'Label_Filter
        '
        resources.ApplyResources(Me.Label_Filter, "Label_Filter")
        Me.Label_Filter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_Filter.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label_Filter.Name = "Label_Filter"
        '
        'lbl_filtro
        '
        resources.ApplyResources(Me.lbl_filtro, "lbl_filtro")
        Me.lbl_filtro.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_filtro.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_filtro.Name = "lbl_filtro"
        '
        'lbl_NumeroFIleTrovati
        '
        resources.ApplyResources(Me.lbl_NumeroFIleTrovati, "lbl_NumeroFIleTrovati")
        Me.lbl_NumeroFIleTrovati.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_NumeroFIleTrovati.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_NumeroFIleTrovati.Name = "lbl_NumeroFIleTrovati"
        '
        'Label_Titolo
        '
        Me.Label_Titolo.AllowDrop = True
        resources.ApplyResources(Me.Label_Titolo, "Label_Titolo")
        Me.Label_Titolo.Name = "Label_Titolo"
        '
        'cmd_ChoosePath
        '
        resources.ApplyResources(Me.cmd_ChoosePath, "cmd_ChoosePath")
        Me.cmd_ChoosePath.Name = "cmd_ChoosePath"
        Me.cmd_ChoosePath.UseVisualStyleBackColor = True
        '
        'GroupBox_FiltroFile
        '
        Me.GroupBox_FiltroFile.Controls.Add(Me.Label_HelpFilter)
        Me.GroupBox_FiltroFile.Controls.Add(Me.Label_FiltroEstensione)
        Me.GroupBox_FiltroFile.Controls.Add(Me.txt_FiltroEstensione)
        Me.GroupBox_FiltroFile.Controls.Add(Me.Label_FiltroNome)
        Me.GroupBox_FiltroFile.Controls.Add(Me.txt_FiltroNome)
        resources.ApplyResources(Me.GroupBox_FiltroFile, "GroupBox_FiltroFile")
        Me.GroupBox_FiltroFile.Name = "GroupBox_FiltroFile"
        Me.GroupBox_FiltroFile.TabStop = False
        '
        'Label_HelpFilter
        '
        resources.ApplyResources(Me.Label_HelpFilter, "Label_HelpFilter")
        Me.Label_HelpFilter.Name = "Label_HelpFilter"
        '
        'Label_FiltroEstensione
        '
        resources.ApplyResources(Me.Label_FiltroEstensione, "Label_FiltroEstensione")
        Me.Label_FiltroEstensione.Name = "Label_FiltroEstensione"
        '
        'txt_FiltroEstensione
        '
        Me.txt_FiltroEstensione.AllowDrop = True
        resources.ApplyResources(Me.txt_FiltroEstensione, "txt_FiltroEstensione")
        Me.txt_FiltroEstensione.Name = "txt_FiltroEstensione"
        '
        'Label_FiltroNome
        '
        resources.ApplyResources(Me.Label_FiltroNome, "Label_FiltroNome")
        Me.Label_FiltroNome.Name = "Label_FiltroNome"
        '
        'txt_FiltroNome
        '
        Me.txt_FiltroNome.AllowDrop = True
        resources.ApplyResources(Me.txt_FiltroNome, "txt_FiltroNome")
        Me.txt_FiltroNome.Name = "txt_FiltroNome"
        '
        'Label_HelpDirectory
        '
        resources.ApplyResources(Me.Label_HelpDirectory, "Label_HelpDirectory")
        Me.Label_HelpDirectory.Name = "Label_HelpDirectory"
        '
        'Label_Directory
        '
        Me.Label_Directory.AllowDrop = True
        resources.ApplyResources(Me.Label_Directory, "Label_Directory")
        Me.Label_Directory.Name = "Label_Directory"
        '
        'txt_FilesPath
        '
        Me.txt_FilesPath.AllowDrop = True
        resources.ApplyResources(Me.txt_FilesPath, "txt_FilesPath")
        Me.txt_FilesPath.Name = "txt_FilesPath"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Tab_Transformation
        '
        Me.Tab_Transformation.BackColor = System.Drawing.SystemColors.Control
        Me.Tab_Transformation.Controls.Add(Me.cmd_Indietro)
        Me.Tab_Transformation.Controls.Add(Me.chk_ModificaNome)
        Me.Tab_Transformation.Controls.Add(Me.cmd_Rinomina)
        Me.Tab_Transformation.Controls.Add(Me.Label_Esempio)
        Me.Tab_Transformation.Controls.Add(Me.txt_Esempio)
        Me.Tab_Transformation.Controls.Add(Me.GroupBox_NomeFile)
        Me.Tab_Transformation.Controls.Add(Me.GroupBox_EstensioneFile)
        Me.Tab_Transformation.Controls.Add(Me.chk_ModificaEstensione)
        resources.ApplyResources(Me.Tab_Transformation, "Tab_Transformation")
        Me.Tab_Transformation.Name = "Tab_Transformation"
        '
        'chk_ModificaNome
        '
        resources.ApplyResources(Me.chk_ModificaNome, "chk_ModificaNome")
        Me.chk_ModificaNome.Name = "chk_ModificaNome"
        Me.chk_ModificaNome.UseVisualStyleBackColor = True
        '
        'cmd_Rinomina
        '
        resources.ApplyResources(Me.cmd_Rinomina, "cmd_Rinomina")
        Me.cmd_Rinomina.Name = "cmd_Rinomina"
        Me.cmd_Rinomina.UseVisualStyleBackColor = True
        '
        'Label_Esempio
        '
        resources.ApplyResources(Me.Label_Esempio, "Label_Esempio")
        Me.Label_Esempio.Name = "Label_Esempio"
        '
        'txt_Esempio
        '
        resources.ApplyResources(Me.txt_Esempio, "txt_Esempio")
        Me.txt_Esempio.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_Esempio.ForeColor = System.Drawing.Color.White
        Me.txt_Esempio.Name = "txt_Esempio"
        Me.txt_Esempio.ReadOnly = True
        Me.txt_Esempio.TabStop = False
        '
        'GroupBox_NomeFile
        '
        resources.ApplyResources(Me.GroupBox_NomeFile, "GroupBox_NomeFile")
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Inserisci)
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Elimina)
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Rimpiazza)
        Me.GroupBox_NomeFile.Controls.Add(Me.txt_Modifica)
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Rinomina)
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Suffisso)
        Me.GroupBox_NomeFile.Controls.Add(Me.rb_Prefisso)
        Me.GroupBox_NomeFile.Controls.Add(Me.GroupBox3)
        Me.GroupBox_NomeFile.Controls.Add(Me.grp_Rimpiazza)
        Me.GroupBox_NomeFile.Controls.Add(Me.grp_Elimina)
        Me.GroupBox_NomeFile.Controls.Add(Me.grp_Inserisci)
        Me.GroupBox_NomeFile.Name = "GroupBox_NomeFile"
        Me.GroupBox_NomeFile.TabStop = False
        '
        'rb_Inserisci
        '
        resources.ApplyResources(Me.rb_Inserisci, "rb_Inserisci")
        Me.rb_Inserisci.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Inserisci.Name = "rb_Inserisci"
        Me.rb_Inserisci.TabStop = True
        Me.rb_Inserisci.UseVisualStyleBackColor = True
        '
        'rb_Elimina
        '
        resources.ApplyResources(Me.rb_Elimina, "rb_Elimina")
        Me.rb_Elimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Elimina.Name = "rb_Elimina"
        Me.rb_Elimina.TabStop = True
        Me.rb_Elimina.UseVisualStyleBackColor = True
        '
        'rb_Rimpiazza
        '
        resources.ApplyResources(Me.rb_Rimpiazza, "rb_Rimpiazza")
        Me.rb_Rimpiazza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Rimpiazza.Name = "rb_Rimpiazza"
        Me.rb_Rimpiazza.TabStop = True
        Me.rb_Rimpiazza.UseVisualStyleBackColor = True
        '
        'txt_Modifica
        '
        resources.ApplyResources(Me.txt_Modifica, "txt_Modifica")
        Me.txt_Modifica.Name = "txt_Modifica"
        '
        'rb_Rinomina
        '
        resources.ApplyResources(Me.rb_Rinomina, "rb_Rinomina")
        Me.rb_Rinomina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Rinomina.Name = "rb_Rinomina"
        Me.rb_Rinomina.TabStop = True
        Me.rb_Rinomina.UseVisualStyleBackColor = True
        '
        'rb_Suffisso
        '
        resources.ApplyResources(Me.rb_Suffisso, "rb_Suffisso")
        Me.rb_Suffisso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Suffisso.Name = "rb_Suffisso"
        Me.rb_Suffisso.TabStop = True
        Me.rb_Suffisso.UseVisualStyleBackColor = True
        '
        'rb_Prefisso
        '
        resources.ApplyResources(Me.rb_Prefisso, "rb_Prefisso")
        Me.rb_Prefisso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_Prefisso.Name = "rb_Prefisso"
        Me.rb_Prefisso.TabStop = True
        Me.rb_Prefisso.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txt_Separatore)
        Me.GroupBox3.Controls.Add(Me.lbl_Separatore)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox3.Controls.Add(Me.txt_NumeroCifre)
        Me.GroupBox3.Controls.Add(Me.lbl_NumeroCifre)
        Me.GroupBox3.Controls.Add(Me.rb_NumeroSuffisso)
        Me.GroupBox3.Controls.Add(Me.rb_NumeroPrefisso)
        Me.GroupBox3.Controls.Add(Me.txt_NumeroStart)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.lbl_NumeroStart)
        Me.GroupBox3.Controls.Add(Me.chk_NumerazioneAutomatica)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txt_Separatore
        '
        Me.txt_Separatore.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_Separatore, "txt_Separatore")
        Me.txt_Separatore.AsciiOnly = True
        Me.txt_Separatore.Name = "txt_Separatore"
        '
        'lbl_Separatore
        '
        resources.ApplyResources(Me.lbl_Separatore, "lbl_Separatore")
        Me.lbl_Separatore.Name = "lbl_Separatore"
        '
        'NumericUpDown2
        '
        resources.ApplyResources(Me.NumericUpDown2, "NumericUpDown2")
        Me.NumericUpDown2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        '
        'txt_NumeroCifre
        '
        Me.txt_NumeroCifre.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_NumeroCifre, "txt_NumeroCifre")
        Me.txt_NumeroCifre.AsciiOnly = True
        Me.txt_NumeroCifre.Name = "txt_NumeroCifre"
        '
        'lbl_NumeroCifre
        '
        resources.ApplyResources(Me.lbl_NumeroCifre, "lbl_NumeroCifre")
        Me.lbl_NumeroCifre.Name = "lbl_NumeroCifre"
        '
        'rb_NumeroSuffisso
        '
        resources.ApplyResources(Me.rb_NumeroSuffisso, "rb_NumeroSuffisso")
        Me.rb_NumeroSuffisso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_NumeroSuffisso.Name = "rb_NumeroSuffisso"
        Me.rb_NumeroSuffisso.TabStop = True
        Me.rb_NumeroSuffisso.UseVisualStyleBackColor = True
        '
        'rb_NumeroPrefisso
        '
        resources.ApplyResources(Me.rb_NumeroPrefisso, "rb_NumeroPrefisso")
        Me.rb_NumeroPrefisso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb_NumeroPrefisso.Name = "rb_NumeroPrefisso"
        Me.rb_NumeroPrefisso.TabStop = True
        Me.rb_NumeroPrefisso.UseVisualStyleBackColor = True
        '
        'txt_NumeroStart
        '
        Me.txt_NumeroStart.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_NumeroStart, "txt_NumeroStart")
        Me.txt_NumeroStart.AsciiOnly = True
        Me.txt_NumeroStart.Name = "txt_NumeroStart"
        '
        'NumericUpDown1
        '
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        '
        'lbl_NumeroStart
        '
        resources.ApplyResources(Me.lbl_NumeroStart, "lbl_NumeroStart")
        Me.lbl_NumeroStart.Name = "lbl_NumeroStart"
        '
        'chk_NumerazioneAutomatica
        '
        resources.ApplyResources(Me.chk_NumerazioneAutomatica, "chk_NumerazioneAutomatica")
        Me.chk_NumerazioneAutomatica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chk_NumerazioneAutomatica.Name = "chk_NumerazioneAutomatica"
        Me.chk_NumerazioneAutomatica.UseVisualStyleBackColor = True
        '
        'grp_Rimpiazza
        '
        resources.ApplyResources(Me.grp_Rimpiazza, "grp_Rimpiazza")
        Me.grp_Rimpiazza.Controls.Add(Me.Label3)
        Me.grp_Rimpiazza.Controls.Add(Me.txt_Sostituisci)
        Me.grp_Rimpiazza.Controls.Add(Me.Label2)
        Me.grp_Rimpiazza.Controls.Add(Me.txt_Trova)
        Me.grp_Rimpiazza.Name = "grp_Rimpiazza"
        Me.grp_Rimpiazza.TabStop = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txt_Sostituisci
        '
        resources.ApplyResources(Me.txt_Sostituisci, "txt_Sostituisci")
        Me.txt_Sostituisci.Name = "txt_Sostituisci"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txt_Trova
        '
        resources.ApplyResources(Me.txt_Trova, "txt_Trova")
        Me.txt_Trova.Name = "txt_Trova"
        '
        'grp_Elimina
        '
        resources.ApplyResources(Me.grp_Elimina, "grp_Elimina")
        Me.grp_Elimina.Controls.Add(Me.Label6)
        Me.grp_Elimina.Controls.Add(Me.Num_EliminaNum)
        Me.grp_Elimina.Controls.Add(Me.txt_EliminaNumCaratteri)
        Me.grp_Elimina.Controls.Add(Me.Label5)
        Me.grp_Elimina.Controls.Add(Me.txt_EliminaDa)
        Me.grp_Elimina.Controls.Add(Me.Num_EliminaDa)
        Me.grp_Elimina.Name = "grp_Elimina"
        Me.grp_Elimina.TabStop = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Num_EliminaNum
        '
        resources.ApplyResources(Me.Num_EliminaNum, "Num_EliminaNum")
        Me.Num_EliminaNum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Num_EliminaNum.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Num_EliminaNum.Name = "Num_EliminaNum"
        Me.Num_EliminaNum.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'txt_EliminaNumCaratteri
        '
        Me.txt_EliminaNumCaratteri.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_EliminaNumCaratteri, "txt_EliminaNumCaratteri")
        Me.txt_EliminaNumCaratteri.AsciiOnly = True
        Me.txt_EliminaNumCaratteri.Name = "txt_EliminaNumCaratteri"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txt_EliminaDa
        '
        Me.txt_EliminaDa.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_EliminaDa, "txt_EliminaDa")
        Me.txt_EliminaDa.AsciiOnly = True
        Me.txt_EliminaDa.Name = "txt_EliminaDa"
        '
        'Num_EliminaDa
        '
        resources.ApplyResources(Me.Num_EliminaDa, "Num_EliminaDa")
        Me.Num_EliminaDa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Num_EliminaDa.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Num_EliminaDa.Name = "Num_EliminaDa"
        Me.Num_EliminaDa.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'grp_Inserisci
        '
        resources.ApplyResources(Me.grp_Inserisci, "grp_Inserisci")
        Me.grp_Inserisci.Controls.Add(Me.txt_Inserisci)
        Me.grp_Inserisci.Controls.Add(Me.Label7)
        Me.grp_Inserisci.Controls.Add(Me.Label4)
        Me.grp_Inserisci.Controls.Add(Me.txt_InserisciDa)
        Me.grp_Inserisci.Controls.Add(Me.Num_InserisciDa)
        Me.grp_Inserisci.Name = "grp_Inserisci"
        Me.grp_Inserisci.TabStop = False
        '
        'txt_Inserisci
        '
        resources.ApplyResources(Me.txt_Inserisci, "txt_Inserisci")
        Me.txt_Inserisci.Name = "txt_Inserisci"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txt_InserisciDa
        '
        Me.txt_InserisciDa.AllowPromptAsInput = False
        resources.ApplyResources(Me.txt_InserisciDa, "txt_InserisciDa")
        Me.txt_InserisciDa.AsciiOnly = True
        Me.txt_InserisciDa.Name = "txt_InserisciDa"
        '
        'Num_InserisciDa
        '
        resources.ApplyResources(Me.Num_InserisciDa, "Num_InserisciDa")
        Me.Num_InserisciDa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Num_InserisciDa.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Num_InserisciDa.Name = "Num_InserisciDa"
        Me.Num_InserisciDa.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'GroupBox_EstensioneFile
        '
        resources.ApplyResources(Me.GroupBox_EstensioneFile, "GroupBox_EstensioneFile")
        Me.GroupBox_EstensioneFile.Controls.Add(Me.lbl_nuovaestensione)
        Me.GroupBox_EstensioneFile.Controls.Add(Me.Label8)
        Me.GroupBox_EstensioneFile.Controls.Add(Me.lbl_EstensioneCorrente)
        Me.GroupBox_EstensioneFile.Controls.Add(Me.txt_NuovaEstensione)
        Me.GroupBox_EstensioneFile.Name = "GroupBox_EstensioneFile"
        Me.GroupBox_EstensioneFile.TabStop = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Name = "Label8"
        '
        'lbl_EstensioneCorrente
        '
        resources.ApplyResources(Me.lbl_EstensioneCorrente, "lbl_EstensioneCorrente")
        Me.lbl_EstensioneCorrente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_EstensioneCorrente.Name = "lbl_EstensioneCorrente"
        '
        'txt_NuovaEstensione
        '
        resources.ApplyResources(Me.txt_NuovaEstensione, "txt_NuovaEstensione")
        Me.txt_NuovaEstensione.Name = "txt_NuovaEstensione"
        '
        'chk_ModificaEstensione
        '
        resources.ApplyResources(Me.chk_ModificaEstensione, "chk_ModificaEstensione")
        Me.chk_ModificaEstensione.Name = "chk_ModificaEstensione"
        Me.chk_ModificaEstensione.UseVisualStyleBackColor = True
        '
        'lbl_NumeroFIleTrovati2
        '
        Me.lbl_NumeroFIleTrovati2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbl_NumeroFIleTrovati2, "lbl_NumeroFIleTrovati2")
        Me.lbl_NumeroFIleTrovati2.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_NumeroFIleTrovati2.Name = "lbl_NumeroFIleTrovati2"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgressBar1, Me.ts_Stato})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        '
        'ts_Stato
        '
        Me.ts_Stato.Name = "ts_Stato"
        resources.ApplyResources(Me.ts_Stato, "ts_Stato")
        Me.ts_Stato.Spring = True
        '
        'lbl_nuovaestensione
        '
        resources.ApplyResources(Me.lbl_nuovaestensione, "lbl_nuovaestensione")
        Me.lbl_nuovaestensione.Name = "lbl_nuovaestensione"
        '
        'cmd_Indietro
        '
        resources.ApplyResources(Me.cmd_Indietro, "cmd_Indietro")
        Me.cmd_Indietro.Name = "cmd_Indietro"
        Me.cmd_Indietro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_NumeroFIleTrovati2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Source.ResumeLayout(False)
        Me.Tab_Source.PerformLayout()
        Me.GroupBox_FiltroFile.ResumeLayout(False)
        Me.GroupBox_FiltroFile.PerformLayout()
        Me.Tab_Transformation.ResumeLayout(False)
        Me.Tab_Transformation.PerformLayout()
        Me.GroupBox_NomeFile.ResumeLayout(False)
        Me.GroupBox_NomeFile.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Rimpiazza.ResumeLayout(False)
        Me.grp_Rimpiazza.PerformLayout()
        Me.grp_Elimina.ResumeLayout(False)
        Me.grp_Elimina.PerformLayout()
        CType(Me.Num_EliminaNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_EliminaDa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Inserisci.ResumeLayout(False)
        Me.grp_Inserisci.PerformLayout()
        CType(Me.Num_InserisciDa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_EstensioneFile.ResumeLayout(False)
        Me.GroupBox_EstensioneFile.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_Strumenti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Linguaggio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Info As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItalianoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Source As System.Windows.Forms.TabPage
    Friend WithEvents cmd_ChoosePath As System.Windows.Forms.Button
    Friend WithEvents GroupBox_FiltroFile As System.Windows.Forms.GroupBox
    Friend WithEvents Label_HelpFilter As System.Windows.Forms.Label
    Friend WithEvents Label_FiltroEstensione As System.Windows.Forms.Label
    Friend WithEvents txt_FiltroEstensione As System.Windows.Forms.TextBox
    Friend WithEvents Label_FiltroNome As System.Windows.Forms.Label
    Friend WithEvents txt_FiltroNome As System.Windows.Forms.TextBox
    Friend WithEvents Label_HelpDirectory As System.Windows.Forms.Label
    Friend WithEvents Label_Directory As System.Windows.Forms.Label
    Friend WithEvents txt_FilesPath As System.Windows.Forms.TextBox
    Friend WithEvents Tab_Transformation As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox_NomeFile As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Modifica As System.Windows.Forms.TextBox
    Friend WithEvents rb_Rinomina As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Suffisso As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Prefisso As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Separatore As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_Separatore As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_NumeroCifre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_NumeroCifre As System.Windows.Forms.Label
    Friend WithEvents rb_NumeroSuffisso As System.Windows.Forms.RadioButton
    Friend WithEvents rb_NumeroPrefisso As System.Windows.Forms.RadioButton
    Friend WithEvents txt_NumeroStart As System.Windows.Forms.MaskedTextBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_NumeroStart As System.Windows.Forms.Label
    Friend WithEvents chk_NumerazioneAutomatica As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_EstensioneFile As System.Windows.Forms.GroupBox
    Friend WithEvents txt_NuovaEstensione As System.Windows.Forms.TextBox
    Friend WithEvents Label_Titolo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_CheckFilter As System.Windows.Forms.Button
    Friend WithEvents Label_Filter As System.Windows.Forms.Label
    Friend WithEvents lbl_filtro As System.Windows.Forms.Label
    Friend WithEvents lbl_NumeroFIleTrovati As System.Windows.Forms.Label
    Friend WithEvents Label_Esempio As System.Windows.Forms.Label
    Friend WithEvents txt_Esempio As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NumeroFIleTrovati2 As System.Windows.Forms.Label
    Friend WithEvents rb_Rimpiazza As System.Windows.Forms.RadioButton
    Friend WithEvents grp_Rimpiazza As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Sostituisci As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Trova As System.Windows.Forms.TextBox
    Friend WithEvents grp_Elimina As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Num_EliminaNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_EliminaNumCaratteri As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_EliminaDa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Num_EliminaDa As System.Windows.Forms.NumericUpDown
    Friend WithEvents rb_Elimina As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Inserisci As System.Windows.Forms.RadioButton
    Friend WithEvents grp_Inserisci As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_InserisciDa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Num_InserisciDa As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_Inserisci As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ts_Stato As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmd_Rinomina As System.Windows.Forms.Button
    Friend WithEvents cmd_Avanti As System.Windows.Forms.Button
    Friend WithEvents lbl_EstensioneCorrente As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_ModificaNome As System.Windows.Forms.CheckBox
    Friend WithEvents chk_ModificaEstensione As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_nuovaestensione As System.Windows.Forms.Label
    Friend WithEvents cmd_Indietro As System.Windows.Forms.Button

End Class
