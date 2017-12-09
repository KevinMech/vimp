<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.trkBrightness = New System.Windows.Forms.TrackBar()
        Me.cbBrightness = New System.Windows.Forms.CheckBox()
        Me.cbContrast = New System.Windows.Forms.CheckBox()
        Me.trkContrast = New System.Windows.Forms.TrackBar()
        Me.cbSaturation = New System.Windows.Forms.CheckBox()
        Me.trkSaturation = New System.Windows.Forms.TrackBar()
        Me.lblBrightness = New System.Windows.Forms.Label()
        Me.lblContrast = New System.Windows.Forms.Label()
        Me.lblSaturation = New System.Windows.Forms.Label()
        Me.grpSave = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmboFormat = New System.Windows.Forms.ComboBox()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSave.SuspendLayout()
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
        Me.txtDirectory.ReadOnly = True
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.CreditsToolStripMenuItem})
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
        'lblBrightness
        '
        Me.lblBrightness.AutoSize = True
        Me.lblBrightness.Location = New System.Drawing.Point(298, 37)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(28, 17)
        Me.lblBrightness.TabIndex = 12
        Me.lblBrightness.Text = "0%"
        '
        'lblContrast
        '
        Me.lblContrast.AutoSize = True
        Me.lblContrast.Location = New System.Drawing.Point(298, 114)
        Me.lblContrast.Name = "lblContrast"
        Me.lblContrast.Size = New System.Drawing.Size(28, 17)
        Me.lblContrast.TabIndex = 13
        Me.lblContrast.Text = "0%"
        '
        'lblSaturation
        '
        Me.lblSaturation.AutoSize = True
        Me.lblSaturation.Location = New System.Drawing.Point(298, 189)
        Me.lblSaturation.Name = "lblSaturation"
        Me.lblSaturation.Size = New System.Drawing.Size(28, 17)
        Me.lblSaturation.TabIndex = 14
        Me.lblSaturation.Text = "0%"
        '
        'grpSave
        '
        Me.grpSave.Controls.Add(Me.btnSave)
        Me.grpSave.Controls.Add(Me.txtName)
        Me.grpSave.Controls.Add(Me.cmboFormat)
        Me.grpSave.Enabled = False
        Me.grpSave.Location = New System.Drawing.Point(12, 249)
        Me.grpSave.Name = "grpSave"
        Me.grpSave.Size = New System.Drawing.Size(314, 130)
        Me.grpSave.TabIndex = 15
        Me.grpSave.TabStop = False
        Me.grpSave.Text = "Save"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 76)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(299, 34)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(9, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(225, 22)
        Me.txtName.TabIndex = 18
        '
        'cmboFormat
        '
        Me.cmboFormat.FormattingEnabled = True
        Me.cmboFormat.Items.AddRange(New Object() {".png", ".jpg", ".jpeg"})
        Me.cmboFormat.Location = New System.Drawing.Point(240, 33)
        Me.cmboFormat.Name = "cmboFormat"
        Me.cmboFormat.Size = New System.Drawing.Size(68, 24)
        Me.cmboFormat.TabIndex = 16
        Me.cmboFormat.Text = ".png"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 391)
        Me.Controls.Add(Me.grpSave)
        Me.Controls.Add(Me.lblSaturation)
        Me.Controls.Add(Me.lblContrast)
        Me.Controls.Add(Me.lblBrightness)
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
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Image Manipulation Program"
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.trkBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSave.ResumeLayout(False)
        Me.grpSave.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbImage As PictureBox
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents trkBrightness As TrackBar
    Friend WithEvents cbBrightness As CheckBox
    Friend WithEvents cbContrast As CheckBox
    Friend WithEvents trkContrast As TrackBar
    Friend WithEvents cbSaturation As CheckBox
    Friend WithEvents trkSaturation As TrackBar
    Friend WithEvents lblBrightness As Label
    Friend WithEvents lblContrast As Label
    Friend WithEvents lblSaturation As Label
    Friend WithEvents grpSave As GroupBox
    Friend WithEvents cmboFormat As ComboBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
End Class
