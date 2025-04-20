<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateANewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportScriptPackAsExecutableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoThisActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoAnActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlayScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportAScriptModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportThisScriptModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ClearTheRam = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.RichTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateANewFileToolStripMenuItem, Me.OpenAFileToolStripMenuItem, Me.SaveThisFileToolStripMenuItem, Me.ExportScriptPackAsExecutableToolStripMenuItem, Me.ToolStripSeparator4, Me.UndoThisActionToolStripMenuItem, Me.RedoAnActionToolStripMenuItem, Me.ToolStripSeparator5, Me.CutTextToolStripMenuItem, Me.CopyTextToolStripMenuItem, Me.PasteTextToolStripMenuItem, Me.SearchTextToolStripMenuItem, Me.ChangeFontToolStripMenuItem, Me.ToolStripSeparator6, Me.PlayScriptToolStripMenuItem, Me.ToolStripMenuItem1, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator8, Me.ImportAScriptModelToolStripMenuItem, Me.ExportThisScriptModelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(318, 380)
        '
        'CreateANewFileToolStripMenuItem
        '
        Me.CreateANewFileToolStripMenuItem.Name = "CreateANewFileToolStripMenuItem"
        Me.CreateANewFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.CreateANewFileToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.CreateANewFileToolStripMenuItem.Text = "Create a new file"
        '
        'OpenAFileToolStripMenuItem
        '
        Me.OpenAFileToolStripMenuItem.Name = "OpenAFileToolStripMenuItem"
        Me.OpenAFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenAFileToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.OpenAFileToolStripMenuItem.Text = "Open a file"
        '
        'SaveThisFileToolStripMenuItem
        '
        Me.SaveThisFileToolStripMenuItem.Name = "SaveThisFileToolStripMenuItem"
        Me.SaveThisFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveThisFileToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.SaveThisFileToolStripMenuItem.Text = "Save this file"
        '
        'ExportScriptPackAsExecutableToolStripMenuItem
        '
        Me.ExportScriptPackAsExecutableToolStripMenuItem.Name = "ExportScriptPackAsExecutableToolStripMenuItem"
        Me.ExportScriptPackAsExecutableToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportScriptPackAsExecutableToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ExportScriptPackAsExecutableToolStripMenuItem.Text = "Export script pack as executable"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(314, 6)
        '
        'UndoThisActionToolStripMenuItem
        '
        Me.UndoThisActionToolStripMenuItem.Name = "UndoThisActionToolStripMenuItem"
        Me.UndoThisActionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoThisActionToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.UndoThisActionToolStripMenuItem.Text = "Undo this action"
        '
        'RedoAnActionToolStripMenuItem
        '
        Me.RedoAnActionToolStripMenuItem.Name = "RedoAnActionToolStripMenuItem"
        Me.RedoAnActionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RedoAnActionToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.RedoAnActionToolStripMenuItem.Text = "Redo an action"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(314, 6)
        '
        'CutTextToolStripMenuItem
        '
        Me.CutTextToolStripMenuItem.Name = "CutTextToolStripMenuItem"
        Me.CutTextToolStripMenuItem.ShowShortcutKeys = False
        Me.CutTextToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.CutTextToolStripMenuItem.Text = "Cut text"
        '
        'CopyTextToolStripMenuItem
        '
        Me.CopyTextToolStripMenuItem.Name = "CopyTextToolStripMenuItem"
        Me.CopyTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyTextToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.CopyTextToolStripMenuItem.Text = "Copy text"
        '
        'PasteTextToolStripMenuItem
        '
        Me.PasteTextToolStripMenuItem.Name = "PasteTextToolStripMenuItem"
        Me.PasteTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteTextToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.PasteTextToolStripMenuItem.Text = "Paste text"
        '
        'SearchTextToolStripMenuItem
        '
        Me.SearchTextToolStripMenuItem.Name = "SearchTextToolStripMenuItem"
        Me.SearchTextToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchTextToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.SearchTextToolStripMenuItem.Text = "Search text"
        '
        'ChangeFontToolStripMenuItem
        '
        Me.ChangeFontToolStripMenuItem.Name = "ChangeFontToolStripMenuItem"
        Me.ChangeFontToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ChangeFontToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ChangeFontToolStripMenuItem.Text = "Change font"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(314, 6)
        '
        'PlayScriptToolStripMenuItem
        '
        Me.PlayScriptToolStripMenuItem.Name = "PlayScriptToolStripMenuItem"
        Me.PlayScriptToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.PlayScriptToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.PlayScriptToolStripMenuItem.Text = "Play script"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(317, 22)
        Me.ToolStripMenuItem1.Text = "Stop playing scripts"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(314, 6)
        '
        'ImportAScriptModelToolStripMenuItem
        '
        Me.ImportAScriptModelToolStripMenuItem.Name = "ImportAScriptModelToolStripMenuItem"
        Me.ImportAScriptModelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImportAScriptModelToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ImportAScriptModelToolStripMenuItem.Text = "Import a script model"
        '
        'ExportThisScriptModelToolStripMenuItem
        '
        Me.ExportThisScriptModelToolStripMenuItem.Name = "ExportThisScriptModelToolStripMenuItem"
        Me.ExportThisScriptModelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportThisScriptModelToolStripMenuItem.Size = New System.Drawing.Size(317, 22)
        Me.ExportThisScriptModelToolStripMenuItem.Text = "Export this script model"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton16, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator3, Me.ToolStripButton11, Me.ToolStripButton15, Me.ToolStripButton12, Me.ToolStripSeparator7, Me.ToolStripButton13, Me.ToolStripButton14})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1067, 25)
        Me.ToolStrip1.TabIndex = 2
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Create a new file"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Open a file"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Save this file"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Export script pack as executable"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Undo this action"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Redo an action"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Cut text"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Copy text"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Paste text"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Search text"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Change font"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Play script"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Stop playing scripts"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Settings"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Import a script model"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Export this script model"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Fabricio Script File (*.fbs)|*.fbs"
        Me.OpenFileDialog1.Title = "Open a Fabricio script file..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Fabricio Script File (*.fbs)|*.fbs"
        Me.SaveFileDialog1.Title = "Save current Fabricio script file..."
        '
        'ClearTheRam
        '
        Me.ClearTheRam.Interval = 1000
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.RichTextBox1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.RichTextBox1.BackBrush = Nothing
        Me.RichTextBox1.CharHeight = 14
        Me.RichTextBox1.CharWidth = 8
        Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.RichTextBox1.IsReplaceMode = False
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 25)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.RichTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBox1.ServiceColors = CType(resources.GetObject("RichTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.RichTextBox1.ShowFoldingLines = True
        Me.RichTextBox1.Size = New System.Drawing.Size(1067, 598)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Zoom = 100
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1067, 623)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fabricio - Editing a new file"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.RichTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ClearTheRam As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CreateANewFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenAFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents UndoThisActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoAnActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CutTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents PlayScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ImportAScriptModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportThisScriptModelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ExportScriptPackAsExecutableToolStripMenuItem As ToolStripMenuItem
End Class
