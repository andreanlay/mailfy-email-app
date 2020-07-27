<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forgotPasswordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgotPasswordForm))
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.forgotButton = New System.Windows.Forms.Button()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.panelFirstName = New System.Windows.Forms.Panel()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backIcon = New System.Windows.Forms.PictureBox()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mainPanel.SuspendLayout()
        Me.panelFirstName.SuspendLayout()
        Me.titlePanel.SuspendLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mainPanel.Controls.Add(Me.forgotButton)
        Me.mainPanel.Controls.Add(Me.emailLabel)
        Me.mainPanel.Controls.Add(Me.panelFirstName)
        Me.mainPanel.Location = New System.Drawing.Point(151, 163)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(439, 167)
        Me.mainPanel.TabIndex = 1
        '
        'forgotButton
        '
        Me.forgotButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.forgotButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.forgotButton.FlatAppearance.BorderSize = 0
        Me.forgotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotButton.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotButton.Location = New System.Drawing.Point(170, 102)
        Me.forgotButton.Name = "forgotButton"
        Me.forgotButton.Size = New System.Drawing.Size(98, 35)
        Me.forgotButton.TabIndex = 16
        Me.forgotButton.Text = "Submit"
        Me.forgotButton.UseVisualStyleBackColor = False
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(22, 42)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(122, 22)
        Me.emailLabel.TabIndex = 5
        Me.emailLabel.Text = "Email Address"
        '
        'panelFirstName
        '
        Me.panelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelFirstName.Controls.Add(Me.emailTB)
        Me.panelFirstName.Location = New System.Drawing.Point(183, 36)
        Me.panelFirstName.Name = "panelFirstName"
        Me.panelFirstName.Size = New System.Drawing.Size(232, 33)
        Me.panelFirstName.TabIndex = 4
        '
        'emailTB
        '
        Me.emailTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTB.Location = New System.Drawing.Point(3, 4)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(224, 18)
        Me.emailTB.TabIndex = 0
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.backIcon)
        Me.titlePanel.Controls.Add(Me.minimizeIcon)
        Me.titlePanel.Controls.Add(Me.exitIcon)
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(741, 24)
        Me.titlePanel.TabIndex = 2
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
        'exitIcon
        '
        Me.exitIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.redCircle
        Me.exitIcon.Location = New System.Drawing.Point(721, 7)
        Me.exitIcon.Name = "exitIcon"
        Me.exitIcon.Size = New System.Drawing.Size(10, 10)
        Me.exitIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitIcon.TabIndex = 4
        Me.exitIcon.TabStop = False
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(29, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 475, 0)
        Me.titleLabel.Size = New System.Drawing.Size(639, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Mailfy - Forgot password"
        '
        'EmailDataSet
        '
        Me.EmailDataSet.DataSetName = "emailDataSet"
        Me.EmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "accounts"
        Me.AccountsBindingSource.DataSource = Me.EmailDataSet
        '
        'forgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.mainPanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "forgotPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy"
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.panelFirstName.ResumeLayout(False)
        Me.panelFirstName.PerformLayout()
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainPanel As Panel
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents exitIcon As PictureBox
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents emailLabel As Label
    Friend WithEvents panelFirstName As Panel
    Friend WithEvents emailTB As TextBox
    Friend WithEvents forgotButton As Button
    Friend WithEvents backIcon As PictureBox
End Class
