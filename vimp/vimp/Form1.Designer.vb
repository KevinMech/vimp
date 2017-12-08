<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trkBrightness = New System.Windows.Forms.TrackBar()
        Me.cbBrightness = New System.Windows.Forms.CheckBox()
        Me.cbContrast = New System.Windows.Forms.CheckBox()
        Me.trkContrast = New System.Windows.Forms.TrackBar()
        Me.cbSaturation = New System.Windows.Forms.CheckBox()
        Me.trkSaturation = New System.Windows.Forms.TrackBar()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbImage
        '
        Me.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImage.Location = New System.Drawing.Point(343, 36)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(333, 313)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(424, 356)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(252, 22)
        Me.txtDirectory.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(343, 356)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ImageToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'trkBrightness
        '
        Me.trkBrightness.Enabled = False
        Me.trkBrightness.LargeChange = 20
        Me.trkBrightness.Location = New System.Drawing.Point(0, 56)
        Me.trkBrightness.Maximum = 100
        Me.trkBrightness.Minimum = -100
        Me.trkBrightness.Name = "trkBrightness"
        Me.trkBrightness.Size = New System.Drawing.Size(337, 56)
        Me.trkBrightness.SmallChange = 5
        Me.trkBrightness.TabIndex = 6
        Me.trkBrightness.TickFrequency = 20
        '
        'cbBrightness
        '
        Me.cbBrightness.AutoSize = True
        Me.cbBrightness.Enabled = False
        Me.cbBrightness.Location = New System.Drawing.Point(12, 36)
        Me.cbBrightness.Name = "cbBrightness"
        Me.cbBrightness.Size = New System.Drawing.Size(97, 21)
        Me.cbBrightness.TabIndex = 7
        Me.cbBrightness.Text = "Brightness"
        Me.cbBrightness.UseVisualStyleBackColor = True
        '
        'cbContrast
        '
        Me.cbContrast.AutoSize = True
        Me.cbContrast.Enabled = False
        Me.cbContrast.Location = New System.Drawing.Point(12, 110)
        Me.cbContrast.Name = "cbContrast"
        Me.cbContrast.Size = New System.Drawing.Size(83, 21)
        Me.cbContrast.TabIndex = 9
        Me.cbContrast.Text = "Contrast"
        Me.cbContrast.UseVisualStyleBackColor = True
        '
        'trkContrast
        '
        Me.trkContrast.Enabled = False
        Me.trkContrast.LargeChange = 20
        Me.trkContrast.Location = New System.Drawing.Point(0, 130)
        Me.trkContrast.Maximum = 100
        Me.trkContrast.Minimum = -100
        Me.trkContrast.Name = "trkContrast"
        Me.trkContrast.Size = New System.Drawing.Size(337, 56)
        Me.trkContrast.SmallChange = 5
        Me.trkContrast.TabIndex = 8
        Me.trkContrast.TickFrequency = 20
        '
        'cbSaturation
        '
        Me.cbSaturation.AutoSize = True
        Me.cbSaturation.Enabled = False
        Me.cbSaturation.Location = New System.Drawing.Point(12, 185)
        Me.cbSaturation.Name = "cbSaturation"
        Me.cbSaturation.Size = New System.Drawing.Size(95, 21)
        Me.cbSaturation.TabIndex = 11
        Me.cbSaturation.Text = "Saturation"
        Me.cbSaturation.UseVisualStyleBackColor = True
        '
        'trkSaturation
        '
        Me.trkSaturation.Enabled = False
        Me.trkSaturation.LargeChange = 20
        Me.trkSaturation.Location = New System.Drawing.Point(0, 205)
        Me.trkSaturation.Maximum = 100
        Me.trkSaturation.Minimum = -100
        Me.trkSaturation.Name = "trkSaturation"
        Me.trkSaturation.Size = New System.Drawing.Size(337, 56)
        Me.trkSaturation.SmallChange = 5
        Me.trkSaturation.TabIndex = 10
        Me.trkSaturation.TickFrequency = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 391)
        Me.Controls.Add(Me.cbSaturation)
        Me.Controls.Add(Me.trkSaturation)
        Me.Controls.Add(Me.cbContrast)
        Me.Controls.Add(Me.trkContrast)
        Me.Controls.Add(Me.cbBrightness)
        Me.Controls.Add(Me.trkBrightness)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbImage As PictureBox
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents trkBrightness As TrackBar
    Friend WithEvents cbBrightness As CheckBox
    Friend WithEvents cbContrast As CheckBox
    Friend WithEvents trkContrast As TrackBar
    Friend WithEvents cbSaturation As CheckBox
    Friend WithEvents trkSaturation As TrackBar
End Class
