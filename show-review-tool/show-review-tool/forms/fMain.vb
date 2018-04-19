Public Class fMain
    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = $"{Config.name} - v{Config.version}"
    End Sub
End Class
