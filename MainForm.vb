Imports System.Runtime
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports FastColoredTextBoxNS
Public Class MainForm
    <DllImport("psapi.dll")>
    Private Shared Function EmptyWorkingSet(ByVal hwProc As IntPtr) As Integer
    End Function
    Dim currentFile As String = ""
    Dim currentScripts As New List(Of String)()
    Dim scriptThread As Thread
    Dim discordClient As Object
    Dim isEncrypted As Boolean
    Dim editingEncrypted As Boolean
    Dim theKey As String
    Public Shared tokenStyle As Style = New TextStyle(Brushes.DarkBlue, Nothing, FontStyle.Bold)
    Public Shared commentStyle As Style = New TextStyle(Brushes.Green, Nothing, FontStyle.Italic)
    Public Shared numberStyle As Style = New TextStyle(Brushes.Magenta, Nothing, FontStyle.Regular)
    Public Shared otherTokens As Style = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Public Sub ClearRam()
        While True
            Thread.Sleep(My.Settings.ThreadSleep)
            ClearAll()
        End While
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.AskClose Then
            If MessageBox.Show("Are you sure you wanna exit from the application?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
        My.Settings.TheFont = RichTextBox1.Font
        If My.Settings.SaveLast Then
            My.Settings.LastText = RichTextBox1.Text
        End If
        My.Settings.Save()
        Process.GetCurrentProcess().Kill()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.RealTime
        Me.CheckForIllegalCrossThreadCalls = True
        GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If My.Settings.ReduceRAM Then
            If My.Settings.MultiThreadedRAM Then
                For i = 0 To My.Settings.NOfThreads - 1
                    Dim threader As Thread = New Thread(New ThreadStart(AddressOf ClearRam))
                    threader.Start()
                Next
            Else
                ClearTheRam.Start()
            End If
        End If
        If My.Settings.LoadScript Then
            If System.IO.File.Exists(My.Settings.ScriptPath) Then
                If System.IO.Path.GetExtension(My.Settings.ScriptPath).ToLower() = ".fbs" Then
                    Dim theText As String = IO.File.ReadAllText(My.Settings.ScriptPath)
                    If theText.ToLower().StartsWith("e") Then
                        isEncrypted = True
                        MessageBox.Show("This file is encrypted, so you can only execute it and you will be not able to modify it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        RichTextBox1.Text = IO.File.ReadAllText(My.Settings.ScriptPath)
                    End If
                    Me.Text = "Fabricio - Editing """ + IO.Path.GetFileNameWithoutExtension(My.Settings.ScriptPath) + """"
                    currentFile = My.Settings.ScriptPath
                    If My.Settings.ExecuteIt Then
                        ToolStripButton11.PerformClick()
                    End If
                End If
            End If
        ElseIf My.Settings.SaveLast Then
            RichTextBox1.Text = My.Settings.LastText
        End If
        If Not My.Settings.SaveLast Then
            My.Settings.LastText = ""
            My.Settings.Save()
        End If
        CreateANewFileToolStripMenuItem.Image = ToolStripButton1.Image
        OpenAFileToolStripMenuItem.Image = ToolStripButton2.Image
        SaveThisFileToolStripMenuItem.Image = ToolStripButton3.Image
        UndoThisActionToolStripMenuItem.Image = ToolStripButton4.Image
        RedoAnActionToolStripMenuItem.Image = ToolStripButton5.Image
        CutTextToolStripMenuItem.Image = ToolStripButton6.Image
        CopyTextToolStripMenuItem.Image = ToolStripButton7.Image
        PasteTextToolStripMenuItem.Image = ToolStripButton8.Image
        SearchTextToolStripMenuItem.Image = ToolStripButton9.Image
        ChangeFontToolStripMenuItem.Image = ToolStripButton10.Image
        PlayScriptToolStripMenuItem.Image = ToolStripButton11.Image
        SettingsToolStripMenuItem.Image = ToolStripButton12.Image
        ImportAScriptModelToolStripMenuItem.Image = ToolStripButton13.Image
        ExportThisScriptModelToolStripMenuItem.Image = ToolStripButton14.Image
        ToolStripMenuItem1.Image = ToolStripButton15.Image
        ExportScriptPackAsExecutableToolStripMenuItem.Image = ToolStripButton16.Image
        If Not System.IO.Directory.Exists(Application.StartupPath + "\script-models") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\script-models")
        End If
        If My.Settings.AllowScript Then
            scriptThread = New Thread(New ThreadStart(AddressOf ExecuteAllScripts))
            scriptThread.Start()
        End If
        RichTextBox1.Font = My.Settings.TheFont
        If System.IO.File.Exists(Application.StartupPath + "\DiscordRPC.dll") And System.IO.File.Exists(Application.StartupPath + "\Newtonsoft.Json.dll") Then
            If FileLen(Application.StartupPath + "\DiscordRPC.dll") = 84936 And FileLen(Application.StartupPath + "\Newtonsoft.Json.dll") = 675752 Then
                If My.Settings.RichPresence Then
                    discordClient = New DiscordRPC.DiscordRpcClient("736623354735362059")
                    discordClient.Initialize()
                    discordClient.SetPresence(New DiscordRPC.RichPresence() With {
                                          .Details = "Fabricio IDE",
                                          .State = "Idling...",
                                          .Assets = New DiscordRPC.Assets() With
                                          {
                .LargeImageKey = "fabricio",
                .LargeImageText = "Fabricio Scripting Language",
                .SmallImageKey = "in-idle",
                .SmallImageText = "In idle"
                }})
                End If
            End If
        End If
        If Not My.Settings.Welcome Then
            SoftwareWelcome.Show()
        End If
        theKey = System.Text.Encoding.Unicode.GetString(Convert.FromBase64String(My.Settings.JERHJKEWHRKJWEHRJWHEKRJHWERKJHWEJKRHKJEWHRKJWEHRJKH))
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Text = "Fabricio - Editing a new file"
        RichTextBox1.Text = ""
        currentFile = ""
        discordClient.SetPresence(New DiscordRPC.RichPresence() With {
                          .Details = "Fabricio IDE",
                          .State = "Idling...",
                          .Assets = New DiscordRPC.Assets() With
                          {
.LargeImageKey = "fabricio",
.LargeImageText = "Fabricio Scripting Language",
.SmallImageKey = "in-idle",
.SmallImageText = "In idle"
}})
        editingEncrypted = False
        isEncrypted = False
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim theText As String = IO.File.ReadAllText(OpenFileDialog1.FileName)
            If theText.ToLower().StartsWith("e") Then
                isEncrypted = True
                MessageBox.Show("This file is encrypted, so you can only execute it and you will be not able to modify it!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                isEncrypted = False
                RichTextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
            End If
            Me.Text = "Fabricio - Editing """ + IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) + """"
            currentFile = OpenFileDialog1.FileName
            discordClient.SetPresence(New DiscordRPC.RichPresence() With {
                          .Details = "Fabricio IDE",
                          .State = "Editing " + IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName) + ".fbs",
                          .Assets = New DiscordRPC.Assets() With
                          {
.LargeImageKey = "fabricio",
.LargeImageText = "Fabricio Scripting Language",
.SmallImageKey = "fabricier",
.SmallImageText = "Fabricio Script"
}})
        End If
        OpenFileDialog1.FileName = ""
        RichTextBox1.ClearUndo()
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If currentFile = "" Then
            If MessageBox.Show("Do you want to encrypt this file?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                editingEncrypted = True
            End If
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                currentFile = SaveFileDialog1.FileName
                Dim theText As String = RichTextBox1.Text
                If editingEncrypted Then
                    theText = "E" + AES_Encrypt(theText, theKey)
                End If
                System.IO.File.WriteAllText(currentFile, theText)
                Me.Text = "Fabricio - Editing """ + IO.Path.GetFileNameWithoutExtension(currentFile) + """"
                discordClient.SetPresence(New DiscordRPC.RichPresence() With {
                          .Details = "Fabricio IDE",
                          .State = "Editing " + IO.Path.GetFileNameWithoutExtension(currentFile) + ".fbs",
                          .Assets = New DiscordRPC.Assets() With
                          {
.LargeImageKey = "fabricio",
.LargeImageText = "Fabricio Scripting Language",
.SmallImageKey = "fabricier",
.SmallImageText = "Fabricio Script"
}})
            Else
                editingEncrypted = False
            End If
            SaveFileDialog1.FileName = ""
        Else
            If Not isEncrypted Then
                Dim theText As String = RichTextBox1.Text
                If editingEncrypted Then
                    theText = "E" + AES_Encrypt(theText, theKey)
                End If
                IO.File.WriteAllText(currentFile, theText)
            End If
        End If
        RichTextBox1.ClearUndo()
    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        RichTextBox1.Undo()
    End Sub
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        RichTextBox1.Redo()
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        SendKeys.Send("^x")
    End Sub
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        If Not RichTextBox1.SelectedText = "" Then
            Clipboard.SetText(RichTextBox1.SelectedText)
        End If
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        RichTextBox1.Text += Clipboard.GetText()
        RichTextBox1.SelectionStart = RichTextBox1.Text.Length
    End Sub
    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        SearchText.Show()
    End Sub
    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            My.Settings.TheFont = RichTextBox1.Font
            My.Settings.Save()
        End If
    End Sub
    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        If Not My.Settings.AllowScript Then
            Exit Sub
        End If
        If currentFile = "" Then
            If MessageBox.Show("Do you want to encrypt this file?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                editingEncrypted = True
            End If
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                currentFile = SaveFileDialog1.FileName
                Dim theText As String = RichTextBox1.Text
                If editingEncrypted Then
                    theText = "E" + AES_Encrypt(theText, theKey)
                End If
                System.IO.File.WriteAllText(currentFile, theText)
                Me.Text = "Fabricio - Editing """ + IO.Path.GetFileNameWithoutExtension(currentFile) + """"
                discordClient.SetPresence(New DiscordRPC.RichPresence() With {
                          .Details = "Fabricio IDE",
                          .State = "Editing " + IO.Path.GetFileNameWithoutExtension(currentFile) + ".fbs",
                          .Assets = New DiscordRPC.Assets() With
                          {
.LargeImageKey = "fabricio",
.LargeImageText = "Fabricio Scripting Language",
.SmallImageKey = "fabricier",
.SmallImageText = "Fabricio Script"
}})
                currentScripts.Add(currentFile)
            Else
                editingEncrypted = False
            End If
            SaveFileDialog1.FileName = ""
        Else
            If Not isEncrypted Then
                Dim theText As String = RichTextBox1.Text
                If editingEncrypted Then
                    theText = "E" + AES_Encrypt(theText, theKey)
                End If
                IO.File.WriteAllText(currentFile, theText)
            End If
            currentScripts.Add(currentFile)
        End If
    End Sub
    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        ProgramSettings.Show()
    End Sub
    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbTab Then
            e.Handled = False
        End If
    End Sub
    Private Sub ClearTheRam_Tick(sender As Object, e As EventArgs) Handles ClearTheRam.Tick
        ClearAll()
    End Sub
    Public Sub ClearAll()
        If My.Settings.WorkingSet Then
            EmptyWorkingSet(Process.GetCurrentProcess().Handle)
        End If
        If My.Settings.GCollect Then
            GC.Collect(GC.MaxGeneration)
            GC.WaitForPendingFinalizers()
        End If
    End Sub
    Private Sub CreateANewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateANewFileToolStripMenuItem.Click
        ToolStripButton1.PerformClick()
    End Sub
    Private Sub OpenAFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenAFileToolStripMenuItem.Click
        ToolStripButton2.PerformClick()
    End Sub
    Private Sub SaveThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveThisFileToolStripMenuItem.Click
        ToolStripButton3.PerformClick()
    End Sub
    Private Sub UndoThisActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoThisActionToolStripMenuItem.Click
        ToolStripButton4.PerformClick()
    End Sub
    Private Sub RedoAnActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoAnActionToolStripMenuItem.Click
        ToolStripButton5.PerformClick()
    End Sub
    Private Sub CutTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutTextToolStripMenuItem.Click
        ToolStripButton6.PerformClick()
    End Sub
    Private Sub CopyTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyTextToolStripMenuItem.Click
        ToolStripButton7.PerformClick()
    End Sub
    Private Sub PasteTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteTextToolStripMenuItem.Click
        ToolStripButton8.PerformClick()
    End Sub
    Private Sub SearchTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchTextToolStripMenuItem.Click
        ToolStripButton9.PerformClick()
    End Sub
    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        ToolStripButton10.PerformClick()
    End Sub
    Private Sub PlayScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayScriptToolStripMenuItem.Click
        ToolStripButton11.PerformClick()
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        ToolStripButton12.PerformClick()
    End Sub
    Private Sub ImportAScriptModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportAScriptModelToolStripMenuItem.Click
        ToolStripButton13.PerformClick()
    End Sub
    Private Sub ExportThisScriptModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportThisScriptModelToolStripMenuItem.Click
        ToolStripButton14.PerformClick()
    End Sub
    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        ImportScriptModel.Show()
    End Sub
    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        ExportScriptModel.Show()
    End Sub
    Public Sub ExecuteAllScripts()
        While True
            Thread.Sleep(My.Settings.ThreadSleep1)
            If currentScripts IsNot Nothing AndAlso currentScripts.Count = 0 Then
                Continue While
            End If
            Dim currentScript As String = ""
            For Each thing As String In currentScripts
                If Not RemoveInitialSpaces(RemoveEndSpaces(thing)).Replace(" ", "").Replace(vbTab, "") = "" Then
                    currentScript = thing
                End If
            Next
            Dim newScript As String = ""
            Dim textboxona As New TextBox With {.Text = System.IO.File.ReadAllText(currentScript), .MaxLength = 2147483647}
            If textboxona.Text.ToLower().StartsWith("e") Then
                textboxona.Text = AES_Decrypt(textboxona.Text.Substring(1, textboxona.Text.Length - 1), theKey)
            End If
            Dim currentLines() As String = textboxona.Lines
            For Each line As String In currentLines
                If line.Contains("//") Then
                    line = Split(line, "//")(0)
                End If
                line = RemoveInitialSpaces(RemoveEndSpaces(line))
                If line.Replace(" ", "").Replace(vbTab, "") = "" Then
                    Continue For
                End If
                If newScript = "" Then
                    newScript = line
                Else
                    newScript += Environment.NewLine + line
                End If
            Next
            textboxona.Text = newScript
            currentLines = textboxona.Lines
            If newScript.StartsWith("[Settings]") Then
                Dim scriptType As String = GetProperty(currentLines, "ScriptType")
                If Not scriptType = "" Then
                    If IsCategoryPresent(currentLines, scriptType) Then
                        Dim theDialogResult As DialogResult = DialogResult.None
                        Dim currentDir As String = System.IO.Path.GetDirectoryName(currentScript)
                        Dim fileStatus As Integer = 0
                        If scriptType = "MessageBox" Then
                            Dim msgCaption As String = GetProperty(currentLines, "Caption").Replace("<br>", Environment.NewLine)
                            Dim msgText As String = GetProperty(currentLines, "Text").Replace("<br>", Environment.NewLine)
                            Dim msgButtons As String = GetProperty(currentLines, "Buttons").ToLower().Replace("_", "").Replace("-", "")
                            Dim msgIcon As String = GetProperty(currentLines, "Icon").ToLower()
                            Dim theButtons As MessageBoxButtons = MessageBoxButtons.OK
                            Dim theIcon As MessageBoxIcon = MessageBoxIcon.None
                            If msgButtons = "yesno" Then
                                theButtons = MessageBoxButtons.YesNo
                            ElseIf msgButtons = "yesnocancel" Then
                                theButtons = MessageBoxButtons.YesNoCancel
                            ElseIf msgButtons = "abortretryignore" Then
                                theButtons = MessageBoxButtons.AbortRetryIgnore
                            ElseIf msgButtons = "okcancel" Then
                                theButtons = MessageBoxButtons.OKCancel
                            ElseIf msgButtons = "retrycancel" Then
                                theButtons = MessageBoxButtons.RetryCancel
                            End If
                            If msgIcon = "error" Or msgIcon = "stop" Then
                                theIcon = MessageBoxIcon.Error
                            ElseIf msgIcon = "information" Or msgIcon = "info" Or msgIcon = "asterisk" Then
                                theIcon = MessageBoxIcon.Information
                            ElseIf msgIcon = "question" Then
                                theIcon = MessageBoxIcon.Question
                            ElseIf msgIcon = "exclamation" Or msgIcon = "warning" Or msgIcon = "warn" Then
                                theIcon = MessageBoxIcon.Exclamation
                            End If
                            theDialogResult = MessageBox.Show(msgText, msgCaption, theButtons, theIcon)
                        ElseIf scriptType = "FileWrite" Then
                            Dim targetFile As String = GetProperty(currentLines, "TargetFile")
                            Dim deleteFileIfExists As String = GetProperty(currentLines, "DeleteFileIfExists").ToLower()
                            Dim appendToFileIfExists As String = GetProperty(currentLines, "AppendToFileIfExists").ToLower()
                            Dim contentToWrite As String = GetProperty(currentLines, "ContentToWrite").Replace("<br>", Environment.NewLine)
                            Dim theRealFile As String = ""
                            If System.IO.File.Exists(targetFile) Then
                                theRealFile = targetFile
                            ElseIf System.IO.File.Exists(Application.StartupPath + "\" + targetFile) Then
                                theRealFile = Application.StartupPath + "\" + targetFile
                            ElseIf System.IO.File.Exists(currentDir + "\" + targetFile) Then
                                theRealFile = currentDir + "\" + targetFile
                            End If
                            Try
                                If Not theRealFile = "" Then
                                    If deleteFileIfExists = "1" Or deleteFileIfExists = "true" Then
                                        System.IO.File.Delete(theRealFile)
                                        System.IO.File.WriteAllText(theRealFile, contentToWrite)
                                        fileStatus = 2
                                    ElseIf appendToFileIfExists = "1" Or appendToFileIfExists = "true" Then
                                        System.IO.File.AppendAllText(theRealFile, contentToWrite)
                                        fileStatus = 3
                                    Else
                                        System.IO.File.WriteAllText(currentDir + "\" + targetFile, contentToWrite)
                                        fileStatus = 4
                                    End If
                                Else
                                    System.IO.File.WriteAllText(currentDir + "\" + targetFile, contentToWrite)
                                End If
                            Catch ex As Exception
                                fileStatus = 1
                            End Try
                        End If
                        If IsCategoryPresent(currentLines, "Events") Then
                            Dim performEvents As String = GetProperty(currentLines, "PerformEvents").ToLower()
                            Dim performEventDialog As String = ""
                            Dim scriptToExecute As String = ""
                            Dim executionTimes As String = ""
                            Dim theEvent As String = ""
                            If performEvents = "1" Or performEvents = "true" Then
                                If scriptType = "MessageBox" Then
                                    theEvent = "EventDialog" + theDialogResult.ToString("g")
                                ElseIf scriptType = "FileExists" Then
                                    Dim targetFile As String = GetProperty(currentLines, "TargetFile")
                                    Dim fileExists As Boolean = False
                                    If System.IO.File.Exists(Application.StartupPath + "\" + targetFile) Then
                                        fileExists = True
                                    ElseIf System.IO.File.Exists(currentDir + "\" + targetFile) Then
                                        fileExists = True
                                    ElseIf System.IO.File.Exists(targetFile) Then
                                        fileExists = True
                                    End If
                                    If fileExists Then
                                        theEvent = "EventFileExists"
                                    Else
                                        theEvent = "EventFileNotExist"
                                    End If
                                ElseIf scriptType = "FileWrite" Then
                                    If fileStatus = 0 Then
                                        theEvent = "EventWriteSuccess"
                                    ElseIf fileStatus = 1 Then
                                        theEvent = "EventWriteError"
                                    ElseIf fileStatus = 2 Then
                                        theEvent = "EventWriteDeleted"
                                    ElseIf fileStatus = 3 Then
                                        theEvent = "EventWriteAppended"
                                    Else
                                        theEvent = "EventWriteReplaced"
                                    End If
                                End If
                                If scriptToExecute.ToLower().EndsWith(".fbs") Then
                                    scriptToExecute = scriptToExecute.Substring(0, scriptToExecute.Length - 4)
                                End If
                                performEventDialog = GetProperty(currentLines, "Perform" + theEvent).ToLower()
                                scriptToExecute = GetProperty(currentLines, "Script" + theEvent)
                                executionTimes = GetProperty(currentLines, "Times" + theEvent)
                                If performEventDialog = "true" Or performEventDialog = "1" Then
                                    If System.IO.File.Exists(currentDir + "\" + scriptToExecute + ".fbs") Then
                                        Try
                                            For i = 0 To Decimal.Parse(executionTimes) - 1
                                                currentScripts.Add(currentDir + "\" + scriptToExecute + ".fbs")
                                            Next
                                        Catch ex As Exception
                                            currentScripts.Add(currentDir + "\" + scriptToExecute + ".fbs")
                                        End Try
                                    ElseIf System.IO.File.Exists(Application.StartupPath + "\" + scriptToExecute + ".fbs") Then
                                        Try
                                            For i = 0 To Decimal.Parse(executionTimes) - 1
                                                currentScripts.Add(Application.StartupPath + "\" + scriptToExecute + ".fbs")
                                            Next
                                        Catch ex As Exception
                                            currentScripts.Add(Application.StartupPath + "\" + scriptToExecute + ".fbs")
                                        End Try
                                    End If
                                End If
                            End If
                        End If
                        If IsCategoryPresent(currentLines, "Execution") Then
                            Dim executeAnother As String = GetProperty(currentLines, "ExecuteAnother").ToLower()
                            If executeAnother = "1" Or executeAnother = "true" Then
                                Dim scriptToExecute As String = GetProperty(currentLines, "ScriptToExecute")
                                If scriptToExecute.ToLower().EndsWith(".fbs") Then
                                    scriptToExecute = scriptToExecute.Substring(0, scriptToExecute.Length - 4)
                                End If
                                Dim repeatIt As String = GetProperty(currentLines, "RepeatIt").ToLower()
                                Dim repeatTimes As String = GetProperty(currentLines, "RepeatTimes")
                                If System.IO.File.Exists(currentDir + "\" + scriptToExecute + ".fbs") Then
                                    If repeatIt = "true" Or repeatIt = "1" Then
                                        Try
                                            For i = 0 To Decimal.Parse(repeatTimes) - 1
                                                currentScripts.Add(currentDir + "\" + scriptToExecute + ".fbs")
                                            Next
                                        Catch ex As Exception
                                            currentScripts.Add(currentDir + "\" + scriptToExecute + ".fbs")
                                        End Try
                                    Else
                                        currentScripts.Add(currentDir + "\" + scriptToExecute + ".fbs")
                                    End If
                                ElseIf System.IO.File.Exists(Application.StartupPath + "\" + scriptToExecute + ".fbs") Then
                                    If repeatIt = "true" Or repeatIt = "1" Then
                                        Try
                                            For i = 0 To Decimal.Parse(repeatTimes) - 1
                                                currentScripts.Add(Application.StartupPath + "\" + scriptToExecute + ".fbs")
                                            Next
                                        Catch ex As Exception
                                            currentScripts.Add(Application.StartupPath + "\" + scriptToExecute + ".fbs")
                                        End Try
                                    Else
                                        currentScripts.Add(Application.StartupPath + "\" + scriptToExecute + ".fbs")
                                    End If
                                End If
                                currentScripts.Remove(currentScript)
                            Else
                                currentScripts.Remove(currentScript)
                            End If
                        Else
                            currentScripts.Remove(currentScript)
                        End If
                    Else
                        currentScripts.Remove(currentScript)
                    End If
                Else
                    currentScripts.Remove(currentScript)
                End If
            Else
                currentScripts.Remove(currentScript)
            End If
        End While
    End Sub
    Public Function RemoveInitialSpaces(ByVal instruction As String) As String
        If instruction.StartsWith(" ") Or instruction.StartsWith(vbTab) Then
            Do While instruction.StartsWith(" ") Or instruction.StartsWith(vbTab)
                instruction = instruction.Substring(1, instruction.Length - 1)
            Loop
        End If
        Return instruction
    End Function
    Public Function RemoveEndSpaces(ByVal instruction As String) As String
        If instruction.EndsWith(" ") Or instruction.EndsWith(vbTab) Then
            Do While instruction.EndsWith(" ") Or instruction.EndsWith(vbTab)
                instruction = instruction.Substring(0, instruction.Length - 1)
            Loop
        End If
        Return instruction
    End Function
    Public Function GetProperty(ByVal lines() As String, ByVal propertyToFind As String) As String
        For Each line As String In lines
            If line.Contains("=") Then
                Dim splitter() As String = Split(line, "=")
                If RemoveInitialSpaces(RemoveEndSpaces(splitter(0))).Replace(" ", "").Replace(vbTab, "") = propertyToFind Then
                    Return RemoveInitialSpaces(RemoveEndSpaces(splitter(1)))
                End If
            End If
        Next
        Return ""
    End Function
    Public Function IsCategoryPresent(ByVal lines() As String, ByVal categoryToFind As String) As String
        If categoryToFind.StartsWith("[") Then
            categoryToFind = categoryToFind.Substring(1, categoryToFind.Length - 1)
        End If
        If categoryToFind.EndsWith("]") Then
            categoryToFind = categoryToFind.Substring(0, categoryToFind.Length - 1)
        End If
        For Each line As String In lines
            If line = "[" + categoryToFind + "]" Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        currentScripts.Clear()
    End Sub
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            Return Convert.ToBase64String(AES.CreateEncryptor.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
        End Try
    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            Return System.Text.ASCIIEncoding.ASCII.GetString(AES.CreateDecryptor.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
        End Try
    End Function
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.Range.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2
        RichTextBox1.Range.tb.LeftBracket = "["
        RichTextBox1.Range.tb.RightBracket = "]"
        RichTextBox1.Range.tb.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);^\s*(case|default)\s*[^:]*(?<range>:)\s*(?<range>[^;]+);"
        Dim commentRegex1 As Regex = New Regex("//.*$", RegexOptions.Multiline)
        Dim commentRegex2 As Regex = New Regex("(/\*.*?\*/)|(/\*.*)", RegexOptions.Multiline)
        Dim commentRegex3 As Regex = New Regex("(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline And RegexOptions.RightToLeft)
        Dim numberRegex As Regex = New Regex("\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b")
        Dim attributeRegex As Regex = New Regex("^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
        Dim tokensRegex As Regex = New Regex("\b(Settings|Events|Execution|MessageBox|FileWrite|FileExists)\b")
        Dim otherTokensRegex As Regex = New Regex("\b(br|false|true)\b")
        RichTextBox1.Range.ClearStyle(commentStyle, tokenStyle, numberStyle, otherTokens)
        RichTextBox1.Range.SetStyle(commentStyle, commentRegex1)
        RichTextBox1.Range.SetStyle(commentStyle, commentRegex2)
        RichTextBox1.Range.SetStyle(commentStyle, commentRegex3)
        RichTextBox1.Range.SetStyle(tokenStyle, tokensRegex)
        RichTextBox1.Range.SetStyle(numberStyle, numberRegex)
        RichTextBox1.Range.SetStyle(otherTokens, otherTokensRegex)
        RichTextBox1.Range.ClearFoldingMarkers()
    End Sub
    Private Sub ExportScriptPackAsExecutableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportScriptPackAsExecutableToolStripMenuItem.Click
        ToolStripButton16.PerformClick()
    End Sub
    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        ExportScriptPack.Show()
    End Sub
End Class