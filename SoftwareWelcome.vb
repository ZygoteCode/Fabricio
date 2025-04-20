Public Class SoftwareWelcome
    Private Sub SoftwareWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        My.Settings.Welcome = True
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class