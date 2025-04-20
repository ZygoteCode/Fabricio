Public Class ProgramSettings
    Private Sub ProgramSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.ReduceRAM
        CheckBox2.Checked = My.Settings.MultiThreadedRAM
        NumericUpDown1.Value = My.Settings.NOfThreads
        NumericUpDown2.Value = My.Settings.ThreadSleep
        CheckBox3.Checked = My.Settings.GCollect
        CheckBox4.Checked = My.Settings.WorkingSet
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        CheckBox5.Checked = My.Settings.AskClose
        CheckBox6.Checked = My.Settings.LoadScript
        TextBox1.Text = My.Settings.ScriptPath
        CheckBox7.Checked = My.Settings.ExecuteIt
        CheckBox8.Checked = My.Settings.AllowScript
        NumericUpDown3.Value = My.Settings.ThreadSleep1
        CheckBox9.Checked = My.Settings.RichPresence
        CheckBox10.Checked = My.Settings.SaveLast
    End Sub
    Private Sub ProgramSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.ReduceRAM = CheckBox1.Checked
        My.Settings.MultiThreadedRAM = CheckBox2.Checked
        My.Settings.NOfThreads = NumericUpDown1.Value
        My.Settings.ThreadSleep = NumericUpDown2.Value
        My.Settings.GCollect = CheckBox3.Checked
        My.Settings.WorkingSet = CheckBox4.Checked
        My.Settings.AskClose = CheckBox5.Checked
        My.Settings.LoadScript = CheckBox6.Checked
        My.Settings.ScriptPath = TextBox1.Text
        My.Settings.ExecuteIt = CheckBox7.Checked
        My.Settings.AllowScript = CheckBox8.Checked
        My.Settings.ThreadSleep1 = NumericUpDown3.Value
        My.Settings.RichPresence = CheckBox9.Checked
        My.Settings.SaveLast = CheckBox10.Checked
        My.Settings.Save()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Enabled = CheckBox1.Checked
        If Not CheckBox1.Checked Then
            Label1.Enabled = False
            Label2.Enabled = False
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
        ElseIf CheckBox2.Checked Then
            Label1.Enabled = True
            Label2.Enabled = True
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label1.Enabled = CheckBox2.Checked
        Label2.Enabled = CheckBox2.Checked
        NumericUpDown1.Enabled = CheckBox2.Checked
        NumericUpDown2.Enabled = CheckBox2.Checked
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        TextBox1.Enabled = CheckBox6.Checked
        Button1.Enabled = CheckBox6.Checked
        CheckBox7.Enabled = CheckBox6.Checked
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        Label3.Enabled = CheckBox8.Checked
        NumericUpDown3.Enabled = CheckBox8.Checked
        If Not CheckBox8.Checked Then
            MainForm.ToolStripButton15.PerformClick()
        End If
    End Sub
End Class