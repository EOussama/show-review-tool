Public Class fExport
    Private Sub fExport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lDesc.Text = fMain.tbShow.Text + " Review"
        rtbOutput.Text = Dep.FormatOutput()
    End Sub

    Private Sub bCopy_Click(sender As Object, e As EventArgs) Handles bCopy.Click
        rtbOutput.SelectAll()
        rtbOutput.Copy()
        MessageBox.Show("Review was successfully copied the review's content!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bExport_Click(sender As Object, e As EventArgs) Handles bExport.Click
        Dim saveF As New SaveFileDialog()
        saveF.Title = "Exporting the review"
        saveF.Filter = "Text files (*.txt)|.txt"
        saveF.FileName = fMain.tbShow.Text.Trim()

        If saveF.ShowDialog() = DialogResult.OK Then
            Dim streamW As New System.IO.StreamWriter(saveF.FileName, False)
            Try
                streamW.Write(rtbOutput.Text)
                MessageBox.Show($"Review was successfully saved under {saveF.FileName}!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                streamW.Close()
            End Try
        End If
    End Sub
End Class