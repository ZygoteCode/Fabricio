Public Class ExportScriptModel
    Private Sub ExportScriptModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists(Application.StartupPath + "\script-models") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\script-models")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not System.IO.Directory.Exists(Application.StartupPath + "\script-models") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\script-models")
        End If
        If Not System.IO.File.Exists(Application.StartupPath + "\script-models\" + TextBox1.Text + ".fbs") Then
            System.IO.File.WriteAllText(Application.StartupPath + "\script-models\" + TextBox1.Text + ".fbs", MainForm.RichTextBox1.Text)
            MessageBox.Show("Succesfully exported this script model!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("This script model already exist!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class