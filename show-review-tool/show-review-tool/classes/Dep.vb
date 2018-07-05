Public Class Dep
    Public Shared Sub NewReview()
        If MessageBox.Show("Do you really want to open a new review panel?", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
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
        fMain.tpOverall.Text = $"Overall ({total.ToString("0.0")}/10)"
    End Sub

    Public Shared Function FormatOutput()
        Dim output As String = String.Empty

        output += fMain.rtbIntro.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpStory.Text}:{Environment.NewLine}" + fMain.rtbStoryDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpArt.Text}:{Environment.NewLine}" + fMain.rtbArtDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpSound.Text}:{Environment.NewLine}" + fMain.rtbSoundDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpCharacter.Text}:{Environment.NewLine}" + fMain.rtbCharacterDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpEnjoyment.Text}:{Environment.NewLine}" + fMain.rtbEnjoymentDesc.Text + Environment.NewLine + Environment.NewLine
        output += $"- {fMain.tpOverall.Text}:{Environment.NewLine}" + fMain.rtbOverallDesc.Text

        Return output.Replace("[title]", fMain.tbShow.Text.Trim())
    End Function

    Public Shared Sub SaveReview(title As String, intro As String, story As String, story_score As Double, art As String, art_score As Double, sound As String, sound_score As Double, characters As String, characters_score As Double, enjoyment As String, enjoyment_score As Double, overall As String)
        Dim sFile As SaveFileDialog = New SaveFileDialog
        sFile.Title = title & " review"
        sFile.FileName = sFile.Title & ".xml"
        sFile.Filter = "XML File (*.xml)|*.xml"

        If sFile.ShowDialog() = DialogResult.OK Then
            Dim doc As Xml.XmlDocument = New Xml.XmlDocument()

            Dim _dec As Xml.XmlNode = doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            doc.AppendChild(_dec)

            Dim _root As Xml.XmlElement = doc.CreateElement("Review")
            _root.SetAttribute("title", title)
            doc.AppendChild(_root)

            Dim _intro As Xml.XmlNode = doc.CreateElement("intro")
            _intro.InnerText = intro
            _root.AppendChild(_intro)

            Dim _story As Xml.XmlElement = doc.CreateElement("story")
            _story.InnerText = story
            _story.SetAttribute("score", story_score)
            _root.AppendChild(_story)

            Dim _art As Xml.XmlElement = doc.CreateElement("art")
            _art.InnerText = art
            _art.SetAttribute("score", art_score)
            _root.AppendChild(_art)

            Dim _sound As Xml.XmlElement = doc.CreateElement("sound")
            _sound.InnerText = sound
            _sound.SetAttribute("score", sound_score)
            _root.AppendChild(_sound)

            Dim _characters As Xml.XmlElement = doc.CreateElement("characters")
            _characters.InnerText = characters
            _characters.SetAttribute("score", characters_score)
            _root.AppendChild(_characters)

            Dim _enjoyment As Xml.XmlElement = doc.CreateElement("enjoyment")
            _enjoyment.InnerText = enjoyment
            _enjoyment.SetAttribute("score", enjoyment_score)
            _root.AppendChild(_enjoyment)

            Dim _overall As Xml.XmlElement = doc.CreateElement("overall")
            _overall.InnerText = overall
            _overall.SetAttribute("score", ((story_score + art_score + sound_score + characters_score + enjoyment_score) / 5).ToString("0.0"))
            _root.AppendChild(_overall)

            doc.Save(sFile.FileName)
        End If

    End Sub

    Public Shared Sub OpenReview()
        Dim oFile As OpenFileDialog = New OpenFileDialog
        oFile.Filter = "XML File (*.xml)|*.xml"

        If oFile.ShowDialog() = DialogResult.OK Then
            Dim doc As Xml.XmlDocument = New Xml.XmlDocument()
            doc.Load(oFile.FileName)

            fMain._title.Text = doc.GetElementsByTagName("review").Item(0).Attributes.Item(0).Value
            fMain._intro.Text = doc.GetElementsByTagName("intro").Item(0).InnerText
            fMain._story.Text = doc.GetElementsByTagName("story").Item(0).InnerText
            fMain._story_score.Value = doc.GetElementsByTagName("story").Item(0).Attributes.Item(0).Value
            fMain._art.Text = doc.GetElementsByTagName("art").Item(0).InnerText
            fMain._art_score.Value = doc.GetElementsByTagName("art").Item(0).Attributes.Item(0).Value
            fMain._sound.Text = doc.GetElementsByTagName("sound").Item(0).InnerText
            fMain._sound_score.Value = doc.GetElementsByTagName("sound").Item(0).Attributes.Item(0).Value
            fMain._characters.Text = doc.GetElementsByTagName("characters").Item(0).InnerText
            fMain._characters_score.Value = doc.GetElementsByTagName("characters").Item(0).Attributes.Item(0).Value
            fMain._enjoyment.Text = doc.GetElementsByTagName("enjoyment").Item(0).InnerText
            fMain._enjoyment_score.Value = doc.GetElementsByTagName("enjoyment").Item(0).Attributes.Item(0).Value
            fMain._overall.Text = doc.GetElementsByTagName("overall").Item(0).InnerText

        End If
    End Sub
End Class
