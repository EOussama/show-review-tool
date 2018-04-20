Public Class Dep
    Public Shared Sub NewReview()
        If MessageBox.Show("Do you really want to open a new review panel?", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
            fMain.tbShow.Clear()
            fMain.rtbIntro.Clear()

            fMain.nudStoryRating.Value = 0.0
            fMain.nudArtRating.Value = 0.0
            fMain.nudSoundRating.Value = 0.0
            fMain.nudCharacterRating.Value = 0.0
            fMain.nudEnjoymentRating.Value = 0.0

            fMain.rtbStoryDesc.Clear()
            fMain.rtbArtDesc.Clear()
            fMain.rtbSoundDesc.Clear()
            fMain.rtbCharacterDesc.Clear()
            fMain.rtbEnjoymentDesc.Clear()
            fMain.rtbOverallDesc.Clear()
        End If
    End Sub

    Public Shared Sub UpdateRatings()
        Dim total As Double = (fMain.nudStoryRating.Value + fMain.nudArtRating.Value + fMain.nudSoundRating.Value + fMain.nudCharacterRating.Value + fMain.nudEnjoymentRating.Value) / 5

        fMain.tpStory.Text = $"Story ({fMain.nudStoryRating.Value.ToString()}/10)"
        fMain.tpArt.Text = $"Art ({fMain.nudArtRating.Value.ToString()}/10)"
        fMain.tpSound.Text = $"Sound ({fMain.nudSoundRating.Value.ToString()}/10)"
        fMain.tpCharacter.Text = $"Character ({fMain.nudCharacterRating.Value.ToString()}/10)"
        fMain.tpEnjoyment.Text = $"Enjoyment ({fMain.nudEnjoymentRating.Value.ToString()}/10)"
        fMain.tpOverall.Text = $"Overall ({total.ToString()}/10)"
    End Sub

    Public Shared Function FormatOutput()
        Dim output As String = String.Empty

        output += fMain.rtbIntro.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpStory.Text}:{Environment.NewLine}" + fMain.rtbStoryDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpArt.Text}:{Environment.NewLine}" + fMain.rtbArtDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpStory.Text}:{Environment.NewLine}" + fMain.rtbSoundDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpCharacter.Text}:{Environment.NewLine}" + fMain.rtbCharacterDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpEnjoyment.Text}:{Environment.NewLine}" + fMain.rtbEnjoymentDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpOverall.Text}:{Environment.NewLine}" + fMain.rtbOverallDesc.Text

        Return output
    End Function
End Class
