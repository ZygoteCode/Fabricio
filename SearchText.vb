Public Class SearchText
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim found As Boolean
        For i = 0 To MainForm.RichTextBox1.Text.Length - 1
            If i = 0 Then
                i = MainForm.RichTextBox1.SelectionStart
            End If
            If MainForm.RichTextBox1.Text.Substring(i, MainForm.RichTextBox1.Text.Length - i).StartsWith(TextBox1.Text) Then
                found = True
                MainForm.RichTextBox1.SelectionStart = i
                MainForm.RichTextBox1.SelectionLength = TextBox1.Text.Length
                MainForm.Select()
                MainForm.RichTextBox1.Select()
            End If
        Next
        If Not found Then
            MessageBox.Show("Could not find that text.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim theText As String = ""
        Dim found As Boolean = False
        If Not CheckBox1.Checked And Not CheckBox2.Checked Then
            If MainForm.RichTextBox1.Text.Contains(TextBox1.Text) Then
                found = True
                theText = TextBox1.Text
            End If
        End If
        If Not found Then
            If CheckBox1.Checked And MainForm.RichTextBox1.Text.Contains(TextBox1.Text.ToLower()) Then
                found = True
                theText = TextBox1.Text.ToLower()
            End If
        End If
        If Not found Then
            If CheckBox2.Checked And MainForm.RichTextBox1.Text.Contains(TextBox1.Text.ToUpper()) Then
                found = True
                theText = TextBox1.Text.ToUpper()
            End If
        End If
        If found Then
            MainForm.RichTextBox1.Text = MainForm.RichTextBox1.Text.Replace(theText, TextBox2.Text)
        Else
            MessageBox.Show("Could not find that text.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyValue = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub
    Private Sub SearchText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.LowerCase
        CheckBox2.Checked = My.Settings.UpperCase
        TextBox1.Text = My.Settings.FindText
        TextBox2.Text = My.Settings.ReplaceWith
    End Sub
    Private Sub SearchText_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.LowerCase = CheckBox1.Checked
        My.Settings.UpperCase = CheckBox2.Checked
        My.Settings.FindText = TextBox1.Text
        My.Settings.ReplaceWith = TextBox2.Text
        My.Settings.Save()
    End Sub
End Class