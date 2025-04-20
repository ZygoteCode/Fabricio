Public Class ImportScriptModel
    Dim allItems As New List(Of String)()
    Private Sub ImportScriptModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists(Application.StartupPath + "\script-models") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\script-models")
        End If
        For Each file As String In System.IO.Directory.GetFiles(Application.StartupPath + "\script-models")
            If System.IO.Path.GetExtension(file).ToLower() = ".fbs" Then
                allItems.Add(System.IO.Path.GetFileNameWithoutExtension(file))
                ListBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
            End If
        Next
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Button1.PerformClick()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not System.IO.Directory.Exists(Application.StartupPath + "\script-models") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\script-models")
        End If
        If ListBox1.SelectedItem = "" Or ListBox1.SelectedItem = Nothing Or ListBox1.SelectedIndex < 0 Then
            MessageBox.Show("This script model does not exist!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If System.IO.File.Exists(Application.StartupPath + "\script-models\" + ListBox1.SelectedItem.ToString() + ".fbs") Then
            MainForm.RichTextBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + "\script-models\" + ListBox1.SelectedItem.ToString() + ".fbs")
            MessageBox.Show("Succesfully imported this script model!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf System.IO.File.Exists(Application.StartupPath + "\script-models\" + TextBox1.Text + ".fbs") Then
            MainForm.RichTextBox1.Text = System.IO.File.ReadAllText(Application.StartupPath + "\script-models\" + TextBox1.Text + ".fbs")
            MessageBox.Show("Succesfully imported this script model!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("This script model does not exist!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListBox1.Items.Clear()
        For Each item As String In allItems
            If item.StartsWith(TextBox1.Text, StringComparison.CurrentCultureIgnoreCase) Then
                ListBox1.Items.Add(item)
            End If
        Next
    End Sub
End Class