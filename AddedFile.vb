Public Class AddedFile
    Dim scriptName As String
    Dim scriptPath As String
    Public Sub New(ByVal scriptName As String, ByVal scriptPath As String)
        Me.scriptName = scriptName
        Me.scriptPath = scriptPath
    End Sub
    Public Function GetScriptName() As String
        Return scriptName
    End Function
    Public Function GetScriptPath() As String
        Return scriptPath
    End Function
End Class