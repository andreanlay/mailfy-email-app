<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class colorPaletteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(colorPaletteForm))
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backIcon = New System.Windows.Forms.PictureBox()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.redPalette = New System.Windows.Forms.Panel()
        Me.lightBluePalette = New System.Windows.Forms.Panel()
        Me.creamPalette = New System.Windows.Forms.Panel()
        Me.pinkPalette = New System.Windows.Forms.Panel()
        Me.greyPalette = New System.Windows.Forms.Panel()
        Me.emeraldPalette = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.titlePanel.SuspendLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.backIcon)
        Me.titlePanel.Controls.Add(Me.minimizeIcon)
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(493, 24)
        Me.titlePanel.TabIndex = 6
        '
        'backIcon
        '
        Me.backIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.back
        Me.backIcon.Location = New System.Drawing.Point(6, 5)
        Me.backIcon.Name = "backIcon"
        Me.backIcon.Size = New System.Drawing.Size(15, 15)
        Me.backIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.backIcon.TabIndex = 6
        Me.backIcon.TabStop = False
        '
        'minimizeIcon
        '
        Me.minimizeIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.yellowCircle
        Me.minimizeIcon.Location = New System.Drawing.Point(701, 5)
        Me.minimizeIcon.Name = "minimizeIcon"
        Me.minimizeIcon.Size = New System.Drawing.Size(15, 15)
        Me.minimizeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizeIcon.TabIndex = 5
        Me.minimizeIcon.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(29, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 365, 0)
        Me.titleLabel.Size = New System.Drawing.Size(458, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Color Palette"
        '
        'redPalette
        '
        Me.redPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.redPalette.Location = New System.Drawing.Point(328, 144)
        Me.redPalette.Margin = New System.Windows.Forms.Padding(0)
        Me.redPalette.Name = "redPalette"
        Me.redPalette.Size = New System.Drawing.Size(165, 144)
        Me.redPalette.TabIndex = 7
        '
        'lightBluePalette
        '
        Me.lightBluePalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lightBluePalette.Location = New System.Drawing.Point(163, 144)
        Me.lightBluePalette.Margin = New System.Windows.Forms.Padding(0)
        Me.lightBluePalette.Name = "lightBluePalette"
        Me.lightBluePalette.Size = New System.Drawing.Size(165, 144)
        Me.lightBluePalette.TabIndex = 8
        '
        'creamPalette
        '
        Me.creamPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.creamPalette.Location = New System.Drawing.Point(0, 144)
        Me.creamPalette.Margin = New System.Windows.Forms.Padding(0)
        Me.creamPalette.Name = "creamPalette"
        Me.creamPalette.Size = New System.Drawing.Size(163, 144)
        Me.creamPalette.TabIndex = 8
        '
        'pinkPalette
        '
        Me.pinkPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pinkPalette.Location = New System.Drawing.Point(165, 0)
        Me.pinkPalette.Margin = New System.Windows.Forms.Padding(0)
        Me.pinkPalette.Name = "pinkPalette"
        Me.pinkPalette.Size = New System.Drawing.Size(163, 144)
        Me.pinkPalette.TabIndex = 10
        '
        'greyPalette
        '
        Me.greyPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.greyPalette.Location = New System.Drawing.Point(328, 0)
        Me.greyPalette.Margin = New System.Windows.Forms.Padding(0)
        Me.greyPalette.Name = "greyPalette"
        Me.greyPalette.Size = New System.Drawing.Size(165, 144)
        Me.greyPalette.TabIndex = 9
        '
        'emeraldPalette
        '
        Me.emeraldPalette.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.emeraldPalette.Location = New System.Drawing.Point(0, 0)
        Me.emeraldPalette.Margin = New System.Windows.Forms.Padding(0)
        Me.emeraldPalette.Name = "emeraldPalette"
        Me.emeraldPalette.Size = New System.Drawing.Size(165, 144)
        Me.emeraldPalette.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.emeraldPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.pinkPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.greyPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.creamPalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.lightBluePalette)
        Me.FlowLayoutPanel1.Controls.Add(Me.redPalette)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(493, 288)
        Me.FlowLayoutPanel1.TabIndex = 8
        '
        'colorPaletteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 312)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.titlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "colorPaletteForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy - Theme"
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlePanel As Panel
    Friend WithEvents backIcon As PictureBox
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents redPalette As Panel
    Friend WithEvents lightBluePalette As Panel
    Friend WithEvents creamPalette As Panel
    Friend WithEvents pinkPalette As Panel
    Friend WithEvents greyPalette As Panel
    Friend WithEvents emeraldPalette As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
