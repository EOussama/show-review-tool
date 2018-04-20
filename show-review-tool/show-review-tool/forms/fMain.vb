Public Class fMain
    ' Main form
    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = $"{Config.name} - v{Config.version}"
        Dep.UpdateRatings()
    End Sub

    ' MenuStrip
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show($"This could be a very useless tool for everybody else but me, I almost daily watch and review shows (mostly anime), and this is just a simple tool built primarily for my personal use.{Environment.NewLine}{Environment.NewLine}Created by {Config.author}, on 4/20/2018", $"Credits - {Config.name} v{Config.version}", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dep.NewReview()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim form As New fExport()
        form.ShowDialog()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub nudArtRating_ValueChanged(sender As Object, e As EventArgs) Handles nudArtRating.ValueChanged
        Dep.UpdateRatings()
    End Sub

    Private Sub nudSoundRating_ValueChanged(sender As Object, e As EventArgs) Handles nudSoundRating.ValueChanged
        Dep.UpdateRatings()
    End Sub

    Private Sub nudCharacterRating_ValueChanged(sender As Object, e As EventArgs) Handles nudCharacterRating.ValueChanged
        Dep.UpdateRatings()
    End Sub

    Private Sub nudEnjoymentRating_ValueChanged(sender As Object, e As EventArgs) Handles nudEnjoymentRating.ValueChanged
        Dep.UpdateRatings()
    End Sub
End Class
