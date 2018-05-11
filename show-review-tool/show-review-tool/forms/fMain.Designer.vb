<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pHeader = New System.Windows.Forms.Panel()
        Me.rtbIntro = New System.Windows.Forms.RichTextBox()
        Me.lIntro = New System.Windows.Forms.Label()
        Me.tbShow = New System.Windows.Forms.TextBox()
        Me.lTitle = New System.Windows.Forms.Label()
        Me.tcTabs = New System.Windows.Forms.TabControl()
        Me.tpStory = New System.Windows.Forms.TabPage()
        Me.rtbStoryDesc = New System.Windows.Forms.RichTextBox()
        Me.nudStoryRating = New System.Windows.Forms.NumericUpDown()
        Me.lStoryRating = New System.Windows.Forms.Label()
        Me.tpArt = New System.Windows.Forms.TabPage()
        Me.rtbArtDesc = New System.Windows.Forms.RichTextBox()
        Me.nudArtRating = New System.Windows.Forms.NumericUpDown()
        Me.lArtRating = New System.Windows.Forms.Label()
        Me.tpSound = New System.Windows.Forms.TabPage()
        Me.rtbSoundDesc = New System.Windows.Forms.RichTextBox()
        Me.nudSoundRating = New System.Windows.Forms.NumericUpDown()
        Me.lSoundRating = New System.Windows.Forms.Label()
        Me.tpCharacter = New System.Windows.Forms.TabPage()
        Me.rtbCharacterDesc = New System.Windows.Forms.RichTextBox()
        Me.nudCharacterRating = New System.Windows.Forms.NumericUpDown()
        Me.lCharacterRating = New System.Windows.Forms.Label()
        Me.tpEnjoyment = New System.Windows.Forms.TabPage()
        Me.rtbEnjoymentDesc = New System.Windows.Forms.RichTextBox()
        Me.nudEnjoymentRating = New System.Windows.Forms.NumericUpDown()
        Me.lEnjoymentRating = New System.Windows.Forms.Label()
        Me.tpOverall = New System.Windows.Forms.TabPage()
        Me.rtbOverallDesc = New System.Windows.Forms.RichTextBox()
        Me.msMenu.SuspendLayout()
        Me.pHeader.SuspendLayout()
        Me.tcTabs.SuspendLayout()
        Me.tpStory.SuspendLayout()
        CType(Me.nudStoryRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpArt.SuspendLayout()
        CType(Me.nudArtRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpSound.SuspendLayout()
        CType(Me.nudSoundRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCharacter.SuspendLayout()
        CType(Me.nudCharacterRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEnjoyment.SuspendLayout()
        CType(Me.nudEnjoymentRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOverall.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenu
        '
        Me.msMenu.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.msMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(478, 24)
        Me.msMenu.TabIndex = 0
        Me.msMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ExportToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.show_review_tool.My.Resources.Resources.icon_new
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Image = Global.show_review_tool.My.Resources.Resources.icon_export
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Image = Global.show_review_tool.My.Resources.Resources.icon_close
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.show_review_tool.My.Resources.Resources.icon_info
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'pHeader
        '
        Me.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pHeader.Controls.Add(Me.rtbIntro)
        Me.pHeader.Controls.Add(Me.lIntro)
        Me.pHeader.Controls.Add(Me.tbShow)
        Me.pHeader.Controls.Add(Me.lTitle)
        Me.pHeader.Location = New System.Drawing.Point(12, 36)
        Me.pHeader.Name = "pHeader"
        Me.pHeader.Size = New System.Drawing.Size(452, 160)
        Me.pHeader.TabIndex = 1
        '
        'rtbIntro
        '
        Me.rtbIntro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbIntro.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbIntro.Location = New System.Drawing.Point(72, 50)
        Me.rtbIntro.Name = "rtbIntro"
        Me.rtbIntro.Size = New System.Drawing.Size(360, 96)
        Me.rtbIntro.TabIndex = 3
        Me.rtbIntro.Text = ""
        '
        'lIntro
        '
        Me.lIntro.AutoSize = True
        Me.lIntro.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lIntro.Location = New System.Drawing.Point(17, 50)
        Me.lIntro.Name = "lIntro"
        Me.lIntro.Size = New System.Drawing.Size(36, 16)
        Me.lIntro.TabIndex = 2
        Me.lIntro.Text = "Intro"
        '
        'tbShow
        '
        Me.tbShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbShow.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbShow.Location = New System.Drawing.Point(72, 14)
        Me.tbShow.Name = "tbShow"
        Me.tbShow.Size = New System.Drawing.Size(360, 23)
        Me.tbShow.TabIndex = 1
        '
        'lTitle
        '
        Me.lTitle.AutoSize = True
        Me.lTitle.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTitle.Location = New System.Drawing.Point(17, 16)
        Me.lTitle.Name = "lTitle"
        Me.lTitle.Size = New System.Drawing.Size(40, 16)
        Me.lTitle.TabIndex = 0
        Me.lTitle.Text = "Show"
        '
        'tcTabs
        '
        Me.tcTabs.Controls.Add(Me.tpStory)
        Me.tcTabs.Controls.Add(Me.tpArt)
        Me.tcTabs.Controls.Add(Me.tpSound)
        Me.tcTabs.Controls.Add(Me.tpCharacter)
        Me.tcTabs.Controls.Add(Me.tpEnjoyment)
        Me.tcTabs.Controls.Add(Me.tpOverall)
        Me.tcTabs.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcTabs.ItemSize = New System.Drawing.Size(42, 30)
        Me.tcTabs.Location = New System.Drawing.Point(12, 202)
        Me.tcTabs.Multiline = True
        Me.tcTabs.Name = "tcTabs"
        Me.tcTabs.SelectedIndex = 0
        Me.tcTabs.ShowToolTips = True
        Me.tcTabs.Size = New System.Drawing.Size(452, 336)
        Me.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tcTabs.TabIndex = 2
        '
        'tpStory
        '
        Me.tpStory.Controls.Add(Me.rtbStoryDesc)
        Me.tpStory.Controls.Add(Me.nudStoryRating)
        Me.tpStory.Controls.Add(Me.lStoryRating)
        Me.tpStory.Location = New System.Drawing.Point(4, 34)
        Me.tpStory.Name = "tpStory"
        Me.tpStory.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStory.Size = New System.Drawing.Size(444, 298)
        Me.tpStory.TabIndex = 0
        Me.tpStory.Text = "Story"
        Me.tpStory.UseVisualStyleBackColor = True
        '
        'rtbStoryDesc
        '
        Me.rtbStoryDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbStoryDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbStoryDesc.Location = New System.Drawing.Point(16, 42)
        Me.rtbStoryDesc.Name = "rtbStoryDesc"
        Me.rtbStoryDesc.Size = New System.Drawing.Size(412, 212)
        Me.rtbStoryDesc.TabIndex = 4
        Me.rtbStoryDesc.Text = ""
        '
        'nudStoryRating
        '
        Me.nudStoryRating.DecimalPlaces = 1
        Me.nudStoryRating.Location = New System.Drawing.Point(61, 13)
        Me.nudStoryRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudStoryRating.Name = "nudStoryRating"
        Me.nudStoryRating.Size = New System.Drawing.Size(43, 23)
        Me.nudStoryRating.TabIndex = 5
        Me.nudStoryRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lStoryRating
        '
        Me.lStoryRating.AutoSize = True
        Me.lStoryRating.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStoryRating.Location = New System.Drawing.Point(13, 15)
        Me.lStoryRating.Name = "lStoryRating"
        Me.lStoryRating.Size = New System.Drawing.Size(42, 16)
        Me.lStoryRating.TabIndex = 4
        Me.lStoryRating.Text = "Score"
        '
        'tpArt
        '
        Me.tpArt.Controls.Add(Me.rtbArtDesc)
        Me.tpArt.Controls.Add(Me.nudArtRating)
        Me.tpArt.Controls.Add(Me.lArtRating)
        Me.tpArt.Location = New System.Drawing.Point(4, 34)
        Me.tpArt.Name = "tpArt"
        Me.tpArt.Padding = New System.Windows.Forms.Padding(3)
        Me.tpArt.Size = New System.Drawing.Size(444, 298)
        Me.tpArt.TabIndex = 1
        Me.tpArt.Text = "Art"
        Me.tpArt.UseVisualStyleBackColor = True
        '
        'rtbArtDesc
        '
        Me.rtbArtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbArtDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbArtDesc.Location = New System.Drawing.Point(16, 42)
        Me.rtbArtDesc.Name = "rtbArtDesc"
        Me.rtbArtDesc.Size = New System.Drawing.Size(412, 212)
        Me.rtbArtDesc.TabIndex = 6
        Me.rtbArtDesc.Text = ""
        '
        'nudArtRating
        '
        Me.nudArtRating.DecimalPlaces = 1
        Me.nudArtRating.Location = New System.Drawing.Point(61, 13)
        Me.nudArtRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudArtRating.Name = "nudArtRating"
        Me.nudArtRating.Size = New System.Drawing.Size(43, 23)
        Me.nudArtRating.TabIndex = 8
        Me.nudArtRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lArtRating
        '
        Me.lArtRating.AutoSize = True
        Me.lArtRating.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lArtRating.Location = New System.Drawing.Point(13, 15)
        Me.lArtRating.Name = "lArtRating"
        Me.lArtRating.Size = New System.Drawing.Size(42, 16)
        Me.lArtRating.TabIndex = 7
        Me.lArtRating.Text = "Score"
        '
        'tpSound
        '
        Me.tpSound.Controls.Add(Me.rtbSoundDesc)
        Me.tpSound.Controls.Add(Me.nudSoundRating)
        Me.tpSound.Controls.Add(Me.lSoundRating)
        Me.tpSound.Location = New System.Drawing.Point(4, 34)
        Me.tpSound.Name = "tpSound"
        Me.tpSound.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSound.Size = New System.Drawing.Size(444, 298)
        Me.tpSound.TabIndex = 2
        Me.tpSound.Text = "Sound"
        Me.tpSound.UseVisualStyleBackColor = True
        '
        'rtbSoundDesc
        '
        Me.rtbSoundDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbSoundDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSoundDesc.Location = New System.Drawing.Point(16, 42)
        Me.rtbSoundDesc.Name = "rtbSoundDesc"
        Me.rtbSoundDesc.Size = New System.Drawing.Size(412, 212)
        Me.rtbSoundDesc.TabIndex = 6
        Me.rtbSoundDesc.Text = ""
        '
        'nudSoundRating
        '
        Me.nudSoundRating.DecimalPlaces = 1
        Me.nudSoundRating.Location = New System.Drawing.Point(61, 13)
        Me.nudSoundRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSoundRating.Name = "nudSoundRating"
        Me.nudSoundRating.Size = New System.Drawing.Size(43, 23)
        Me.nudSoundRating.TabIndex = 8
        Me.nudSoundRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lSoundRating
        '
        Me.lSoundRating.AutoSize = True
        Me.lSoundRating.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSoundRating.Location = New System.Drawing.Point(13, 15)
        Me.lSoundRating.Name = "lSoundRating"
        Me.lSoundRating.Size = New System.Drawing.Size(42, 16)
        Me.lSoundRating.TabIndex = 7
        Me.lSoundRating.Text = "Score"
        '
        'tpCharacter
        '
        Me.tpCharacter.Controls.Add(Me.rtbCharacterDesc)
        Me.tpCharacter.Controls.Add(Me.nudCharacterRating)
        Me.tpCharacter.Controls.Add(Me.lCharacterRating)
        Me.tpCharacter.Location = New System.Drawing.Point(4, 34)
        Me.tpCharacter.Name = "tpCharacter"
        Me.tpCharacter.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCharacter.Size = New System.Drawing.Size(444, 298)
        Me.tpCharacter.TabIndex = 3
        Me.tpCharacter.Text = "Character"
        Me.tpCharacter.UseVisualStyleBackColor = True
        '
        'rtbCharacterDesc
        '
        Me.rtbCharacterDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbCharacterDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCharacterDesc.Location = New System.Drawing.Point(16, 42)
        Me.rtbCharacterDesc.Name = "rtbCharacterDesc"
        Me.rtbCharacterDesc.Size = New System.Drawing.Size(412, 212)
        Me.rtbCharacterDesc.TabIndex = 6
        Me.rtbCharacterDesc.Text = ""
        '
        'nudCharacterRating
        '
        Me.nudCharacterRating.DecimalPlaces = 1
        Me.nudCharacterRating.Location = New System.Drawing.Point(61, 13)
        Me.nudCharacterRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCharacterRating.Name = "nudCharacterRating"
        Me.nudCharacterRating.Size = New System.Drawing.Size(43, 23)
        Me.nudCharacterRating.TabIndex = 8
        Me.nudCharacterRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lCharacterRating
        '
        Me.lCharacterRating.AutoSize = True
        Me.lCharacterRating.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCharacterRating.Location = New System.Drawing.Point(13, 15)
        Me.lCharacterRating.Name = "lCharacterRating"
        Me.lCharacterRating.Size = New System.Drawing.Size(42, 16)
        Me.lCharacterRating.TabIndex = 7
        Me.lCharacterRating.Text = "Score"
        '
        'tpEnjoyment
        '
        Me.tpEnjoyment.Controls.Add(Me.rtbEnjoymentDesc)
        Me.tpEnjoyment.Controls.Add(Me.nudEnjoymentRating)
        Me.tpEnjoyment.Controls.Add(Me.lEnjoymentRating)
        Me.tpEnjoyment.Location = New System.Drawing.Point(4, 34)
        Me.tpEnjoyment.Name = "tpEnjoyment"
        Me.tpEnjoyment.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEnjoyment.Size = New System.Drawing.Size(444, 298)
        Me.tpEnjoyment.TabIndex = 4
        Me.tpEnjoyment.Text = "Enjoyment"
        Me.tpEnjoyment.UseVisualStyleBackColor = True
        '
        'rtbEnjoymentDesc
        '
        Me.rtbEnjoymentDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbEnjoymentDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbEnjoymentDesc.Location = New System.Drawing.Point(16, 42)
        Me.rtbEnjoymentDesc.Name = "rtbEnjoymentDesc"
        Me.rtbEnjoymentDesc.Size = New System.Drawing.Size(412, 212)
        Me.rtbEnjoymentDesc.TabIndex = 6
        Me.rtbEnjoymentDesc.Text = ""
        '
        'nudEnjoymentRating
        '
        Me.nudEnjoymentRating.DecimalPlaces = 1
        Me.nudEnjoymentRating.Location = New System.Drawing.Point(61, 13)
        Me.nudEnjoymentRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudEnjoymentRating.Name = "nudEnjoymentRating"
        Me.nudEnjoymentRating.Size = New System.Drawing.Size(43, 23)
        Me.nudEnjoymentRating.TabIndex = 8
        Me.nudEnjoymentRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lEnjoymentRating
        '
        Me.lEnjoymentRating.AutoSize = True
        Me.lEnjoymentRating.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEnjoymentRating.Location = New System.Drawing.Point(13, 15)
        Me.lEnjoymentRating.Name = "lEnjoymentRating"
        Me.lEnjoymentRating.Size = New System.Drawing.Size(42, 16)
        Me.lEnjoymentRating.TabIndex = 7
        Me.lEnjoymentRating.Text = "Score"
        '
        'tpOverall
        '
        Me.tpOverall.Controls.Add(Me.rtbOverallDesc)
        Me.tpOverall.Location = New System.Drawing.Point(4, 34)
        Me.tpOverall.Name = "tpOverall"
        Me.tpOverall.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOverall.Size = New System.Drawing.Size(444, 298)
        Me.tpOverall.TabIndex = 5
        Me.tpOverall.Text = "Overall"
        Me.tpOverall.UseVisualStyleBackColor = True
        '
        'rtbOverallDesc
        '
        Me.rtbOverallDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbOverallDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOverallDesc.Location = New System.Drawing.Point(16, 18)
        Me.rtbOverallDesc.Name = "rtbOverallDesc"
        Me.rtbOverallDesc.Size = New System.Drawing.Size(412, 236)
        Me.rtbOverallDesc.TabIndex = 6
        Me.rtbOverallDesc.Text = ""
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 550)
        Me.Controls.Add(Me.tcTabs)
        Me.Controls.Add(Me.pHeader)
        Me.Controls.Add(Me.msMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMenu
        Me.MaximizeBox = False
        Me.Name = "fMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show review tool"
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.pHeader.ResumeLayout(False)
        Me.pHeader.PerformLayout()
        Me.tcTabs.ResumeLayout(False)
        Me.tpStory.ResumeLayout(False)
        Me.tpStory.PerformLayout()
        CType(Me.nudStoryRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpArt.ResumeLayout(False)
        Me.tpArt.PerformLayout()
        CType(Me.nudArtRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpSound.ResumeLayout(False)
        Me.tpSound.PerformLayout()
        CType(Me.nudSoundRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCharacter.ResumeLayout(False)
        Me.tpCharacter.PerformLayout()
        CType(Me.nudCharacterRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEnjoyment.ResumeLayout(False)
        Me.tpEnjoyment.PerformLayout()
        CType(Me.nudEnjoymentRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOverall.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pHeader As Panel
    Friend WithEvents rtbIntro As RichTextBox
    Friend WithEvents lIntro As Label
    Friend WithEvents tbShow As TextBox
    Friend WithEvents lTitle As Label
    Friend WithEvents tcTabs As TabControl
    Friend WithEvents tpStory As TabPage
    Friend WithEvents tpArt As TabPage
    Friend WithEvents tpSound As TabPage
    Friend WithEvents tpCharacter As TabPage
    Friend WithEvents tpEnjoyment As TabPage
    Friend WithEvents tpOverall As TabPage
    Friend WithEvents lStoryRating As Label
    Friend WithEvents nudStoryRating As NumericUpDown
    Friend WithEvents rtbStoryDesc As RichTextBox
    Friend WithEvents rtbArtDesc As RichTextBox
    Friend WithEvents nudArtRating As NumericUpDown
    Friend WithEvents lArtRating As Label
    Friend WithEvents rtbSoundDesc As RichTextBox
    Friend WithEvents nudSoundRating As NumericUpDown
    Friend WithEvents lSoundRating As Label
    Friend WithEvents rtbCharacterDesc As RichTextBox
    Friend WithEvents nudCharacterRating As NumericUpDown
    Friend WithEvents lCharacterRating As Label
    Friend WithEvents rtbEnjoymentDesc As RichTextBox
    Friend WithEvents nudEnjoymentRating As NumericUpDown
    Friend WithEvents lEnjoymentRating As Label
    Friend WithEvents rtbOverallDesc As RichTextBox
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
End Class
