<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutForm))
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.teamMemberLabel = New System.Windows.Forms.Label()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Open Sans", 20.75!, System.Drawing.FontStyle.Bold)
        Me.titleLabel.Location = New System.Drawing.Point(176, 73)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(140, 38)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "About us"
        '
        'headerLabel
        '
        Me.headerLabel.AutoSize = True
        Me.headerLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.headerLabel.Location = New System.Drawing.Point(116, 143)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(261, 22)
        Me.headerLabel.TabIndex = 1
        Me.headerLabel.Text = "Mailfy - your trusted email app!"
        '
        'teamMemberLabel
        '
        Me.teamMemberLabel.AutoSize = True
        Me.teamMemberLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.teamMemberLabel.Location = New System.Drawing.Point(148, 191)
        Me.teamMemberLabel.Name = "teamMemberLabel"
        Me.teamMemberLabel.Size = New System.Drawing.Size(0, 22)
        Me.teamMemberLabel.TabIndex = 2
        Me.teamMemberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitIcon
        '
        Me.exitIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.redCircle
        Me.exitIcon.Location = New System.Drawing.Point(480, 3)
        Me.exitIcon.Name = "exitIcon"
        Me.exitIcon.Size = New System.Drawing.Size(10, 10)
        Me.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitIcon.TabIndex = 5
        Me.exitIcon.TabStop = False
        '
        'aboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 389)
        Me.Controls.Add(Me.exitIcon)
        Me.Controls.Add(Me.teamMemberLabel)
        Me.Controls.Add(Me.headerLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy - About us"
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents headerLabel As Label
    Friend WithEvents teamMemberLabel As Label
    Friend WithEvents exitIcon As PictureBox
End Class
