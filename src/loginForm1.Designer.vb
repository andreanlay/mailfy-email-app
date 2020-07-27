<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.loginLabel = New System.Windows.Forms.Label()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.panelPassLogin = New System.Windows.Forms.Panel()
        Me.passTB = New System.Windows.Forms.TextBox()
        Me.panelEmailLogin = New System.Windows.Forms.Panel()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.userPicture = New System.Windows.Forms.PictureBox()
        Me.loginFooter = New System.Windows.Forms.Panel()
        Me.createAccLabel = New System.Windows.Forms.Label()
        Me.footerLabel = New System.Windows.Forms.Label()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.loginPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPassLogin.SuspendLayout()
        Me.panelEmailLogin.SuspendLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginFooter.SuspendLayout()
        Me.titlePanel.SuspendLayout()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginLabel
        '
        Me.loginLabel.AutoSize = True
        Me.loginLabel.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLabel.Location = New System.Drawing.Point(98, 119)
        Me.loginLabel.Name = "loginLabel"
        Me.loginLabel.Size = New System.Drawing.Size(89, 33)
        Me.loginLabel.TabIndex = 0
        Me.loginLabel.Text = "Mailfy"
        '
        'loginPanel
        '
        Me.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.loginPanel.Controls.Add(Me.PictureBox2)
        Me.loginPanel.Controls.Add(Me.PictureBox1)
        Me.loginPanel.Controls.Add(Me.Label1)
        Me.loginPanel.Controls.Add(Me.loginButton)
        Me.loginPanel.Controls.Add(Me.panelPassLogin)
        Me.loginPanel.Controls.Add(Me.panelEmailLogin)
        Me.loginPanel.Controls.Add(Me.userPicture)
        Me.loginPanel.Controls.Add(Me.loginFooter)
        Me.loginPanel.Controls.Add(Me.loginLabel)
        Me.loginPanel.Location = New System.Drawing.Point(228, 64)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(284, 364)
        Me.loginPanel.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Final_Project__Email_App_.My.Resources.Resources.key
        Me.PictureBox2.Location = New System.Drawing.Point(18, 212)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Final_Project__Email_App_.My.Resources.Resources.mail
        Me.PictureBox1.Location = New System.Drawing.Point(18, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(176, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Forgot password ?"
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.loginButton.FlatAppearance.BorderSize = 0
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(93, 251)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(98, 35)
        Me.loginButton.TabIndex = 5
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'panelPassLogin
        '
        Me.panelPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPassLogin.Controls.Add(Me.passTB)
        Me.panelPassLogin.Location = New System.Drawing.Point(55, 207)
        Me.panelPassLogin.Name = "panelPassLogin"
        Me.panelPassLogin.Size = New System.Drawing.Size(213, 33)
        Me.panelPassLogin.TabIndex = 4
        '
        'passTB
        '
        Me.passTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.passTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTB.Location = New System.Drawing.Point(3, 4)
        Me.passTB.Name = "passTB"
        Me.passTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTB.Size = New System.Drawing.Size(205, 18)
        Me.passTB.TabIndex = 0
        '
        'panelEmailLogin
        '
        Me.panelEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmailLogin.Controls.Add(Me.emailTB)
        Me.panelEmailLogin.Location = New System.Drawing.Point(55, 164)
        Me.panelEmailLogin.Name = "panelEmailLogin"
        Me.panelEmailLogin.Size = New System.Drawing.Size(213, 33)
        Me.panelEmailLogin.TabIndex = 3
        '
        'emailTB
        '
        Me.emailTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTB.Location = New System.Drawing.Point(3, 4)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.Size = New System.Drawing.Size(205, 18)
        Me.emailTB.TabIndex = 0
        '
        'userPicture
        '
        Me.userPicture.Image = CType(resources.GetObject("userPicture.Image"), System.Drawing.Image)
        Me.userPicture.Location = New System.Drawing.Point(102, 41)
        Me.userPicture.Name = "userPicture"
        Me.userPicture.Size = New System.Drawing.Size(81, 76)
        Me.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userPicture.TabIndex = 2
        Me.userPicture.TabStop = False
        '
        'loginFooter
        '
        Me.loginFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.loginFooter.Controls.Add(Me.createAccLabel)
        Me.loginFooter.Controls.Add(Me.footerLabel)
        Me.loginFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.loginFooter.Location = New System.Drawing.Point(0, 311)
        Me.loginFooter.Name = "loginFooter"
        Me.loginFooter.Size = New System.Drawing.Size(284, 53)
        Me.loginFooter.TabIndex = 1
        '
        'createAccLabel
        '
        Me.createAccLabel.AutoSize = True
        Me.createAccLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createAccLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.createAccLabel.Location = New System.Drawing.Point(135, 16)
        Me.createAccLabel.Name = "createAccLabel"
        Me.createAccLabel.Size = New System.Drawing.Size(110, 18)
        Me.createAccLabel.TabIndex = 1
        Me.createAccLabel.Text = "Create Account"
        '
        'footerLabel
        '
        Me.footerLabel.AutoSize = True
        Me.footerLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.footerLabel.Location = New System.Drawing.Point(28, 16)
        Me.footerLabel.Name = "footerLabel"
        Me.footerLabel.Size = New System.Drawing.Size(111, 18)
        Me.footerLabel.TabIndex = 0
        Me.footerLabel.Text = "Not a Member ?"
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.minimizeIcon)
        Me.titlePanel.Controls.Add(Me.exitIcon)
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(741, 24)
        Me.titlePanel.TabIndex = 2
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
        Me.titleLabel.Location = New System.Drawing.Point(2, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 475, 0)
        Me.titleLabel.Size = New System.Drawing.Size(691, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Mailfy - Your trusted e-mail app!"
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
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.loginPanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy"
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPassLogin.ResumeLayout(False)
        Me.panelPassLogin.PerformLayout()
        Me.panelEmailLogin.ResumeLayout(False)
        Me.panelEmailLogin.PerformLayout()
        CType(Me.userPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginFooter.ResumeLayout(False)
        Me.loginFooter.PerformLayout()
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginLabel As Label
    Friend WithEvents loginPanel As Panel
    Friend WithEvents loginFooter As Panel
    Friend WithEvents userPicture As PictureBox
    Friend WithEvents footerLabel As Label
    Friend WithEvents panelEmailLogin As Panel
    Friend WithEvents emailTB As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents panelPassLogin As Panel
    Friend WithEvents passTB As TextBox
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents exitIcon As PictureBox
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents createAccLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
