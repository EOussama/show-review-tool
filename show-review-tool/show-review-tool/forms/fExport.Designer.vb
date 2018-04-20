<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fExport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fExport))
        Me.bExport = New System.Windows.Forms.Button()
        Me.lDesc = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.bCopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bExport
        '
        Me.bExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExport.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExport.Location = New System.Drawing.Point(12, 399)
        Me.bExport.Name = "bExport"
        Me.bExport.Size = New System.Drawing.Size(166, 43)
        Me.bExport.TabIndex = 1
        Me.bExport.Text = "Export"
        Me.bExport.UseVisualStyleBackColor = True
        '
        'lDesc
        '
        Me.lDesc.AutoSize = True
        Me.lDesc.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDesc.Location = New System.Drawing.Point(12, 16)
        Me.lDesc.Name = "lDesc"
        Me.lDesc.Size = New System.Drawing.Size(125, 16)
        Me.lDesc.TabIndex = 3
        Me.lDesc.Text = "The complete review"
        '
        'rtbOutput
        '
        Me.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbOutput.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbOutput.Location = New System.Drawing.Point(12, 45)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.Size = New System.Drawing.Size(378, 344)
        Me.rtbOutput.TabIndex = 7
        Me.rtbOutput.Text = ""
        '
        'bCopy
        '
        Me.bCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCopy.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCopy.Location = New System.Drawing.Point(224, 399)
        Me.bCopy.Name = "bCopy"
        Me.bCopy.Size = New System.Drawing.Size(166, 43)
        Me.bCopy.TabIndex = 8
        Me.bCopy.Text = "Copy"
        Me.bCopy.UseVisualStyleBackColor = True
        '
        'fExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 450)
        Me.Controls.Add(Me.bCopy)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lDesc)
        Me.Controls.Add(Me.bExport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Export section"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bExport As Button
    Friend WithEvents lDesc As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents bCopy As Button
End Class
