Public Class ExportScriptPack
    Dim addedFiles As New List(Of AddedFile)()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim alreadyExist As Boolean
        For Each addedFile As AddedFile In addedFiles
            If addedFile.GetScriptName() = TextBox1.Text Or addedFile.GetScriptPath() = TextBox2.Text Then
                alreadyExist = True
                Exit For
            End If
        Next
        If Not alreadyExist Then
            If TextBox1.Text.Replace(" ", "").Replace(vbTab, "") = "" Then
                MessageBox.Show("Invalid script name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If Not System.IO.File.Exists(TextBox2.Text) Then
                    MessageBox.Show("The specified file does not exist!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not System.IO.Path.GetExtension(TextBox2.Text).ToLower() = ".fbs" Then
                        MessageBox.Show("Invalid file extension!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        addedFiles.Add(New AddedFile(TextBox1.Text, TextBox2.Text))
                        ListBox1.Items.Add(TextBox1.Text)
                    End If
                End If
            End If
        Else
            MessageBox.Show("This script already exist!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyValue = Keys.Cancel Or e.KeyValue = Keys.Delete Or e.KeyValue = Keys.Back Then
            DeleteIt()
        End If
    End Sub
    Private Sub RemoveScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveScriptToolStripMenuItem.Click
        DeleteIt()
    End Sub
    Public Sub DeleteIt()
        If Not ListBox1.SelectedIndex < 0 Then
            If Not ListBox1.SelectedItem = "" And Not ListBox1.SelectedItem = Nothing Then
                For Each addedFile As AddedFile In addedFiles
                    If addedFile.GetScriptName() = ListBox1.SelectedItem.ToString() Then
                        addedFiles.Remove(addedFile)
                        Exit For
                    End If
                Next
                ListBox1.Items.Remove(ListBox1.SelectedItem.ToString())
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count > 0 Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                MessageBox.Show("Succesfully saved your executable!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("You need at least to add one script to the pack!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class