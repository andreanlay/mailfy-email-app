﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerForm))
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.strengthLabel = New System.Windows.Forms.Label()
        Me.passStrengthLabel = New System.Windows.Forms.Label()
        Me.confirmLabel = New System.Windows.Forms.Label()
        Me.panelConfirm = New System.Windows.Forms.Panel()
        Me.repeatPassTB = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.panelPassword = New System.Windows.Forms.Panel()
        Me.passwordTB = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.panelEmail = New System.Windows.Forms.Panel()
        Me.emailTB = New System.Windows.Forms.TextBox()
        Me.lastNameLabel = New System.Windows.Forms.Label()
        Me.panelLastName = New System.Windows.Forms.Panel()
        Me.lastNameTB = New System.Windows.Forms.TextBox()
        Me.firstNameLabel = New System.Windows.Forms.Label()
        Me.panelFirstName = New System.Windows.Forms.Panel()
        Me.firstNameTB = New System.Windows.Forms.TextBox()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backIcon = New System.Windows.Forms.PictureBox()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Account_dataTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.account_dataTableAdapter()
        Me.loginPanel.SuspendLayout()
        Me.panelConfirm.SuspendLayout()
        Me.panelPassword.SuspendLayout()
        Me.panelEmail.SuspendLayout()
        Me.panelLastName.SuspendLayout()
        Me.panelFirstName.SuspendLayout()
        Me.titlePanel.SuspendLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginPanel
        '
        Me.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.loginPanel.Controls.Add(Me.registerButton)
        Me.loginPanel.Controls.Add(Me.strengthLabel)
        Me.loginPanel.Controls.Add(Me.passStrengthLabel)
        Me.loginPanel.Controls.Add(Me.confirmLabel)
        Me.loginPanel.Controls.Add(Me.panelConfirm)
        Me.loginPanel.Controls.Add(Me.passwordLabel)
        Me.loginPanel.Controls.Add(Me.panelPassword)
        Me.loginPanel.Controls.Add(Me.emailLabel)
        Me.loginPanel.Controls.Add(Me.panelEmail)
        Me.loginPanel.Controls.Add(Me.lastNameLabel)
        Me.loginPanel.Controls.Add(Me.panelLastName)
        Me.loginPanel.Controls.Add(Me.firstNameLabel)
        Me.loginPanel.Controls.Add(Me.panelFirstName)
        Me.loginPanel.Location = New System.Drawing.Point(151, 64)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(439, 364)
        Me.loginPanel.TabIndex = 1
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.registerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.registerButton.FlatAppearance.BorderSize = 0
        Me.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerButton.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.Location = New System.Drawing.Point(170, 309)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(98, 35)
        Me.registerButton.TabIndex = 16
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'strengthLabel
        '
        Me.strengthLabel.AutoSize = True
        Me.strengthLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strengthLabel.Location = New System.Drawing.Point(301, 278)
        Me.strengthLabel.Name = "strengthLabel"
        Me.strengthLabel.Size = New System.Drawing.Size(0, 18)
        Me.strengthLabel.TabIndex = 15
        '
        'passStrengthLabel
        '
        Me.passStrengthLabel.AutoSize = True
        Me.passStrengthLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passStrengthLabel.Location = New System.Drawing.Point(180, 278)
        Me.passStrengthLabel.Name = "passStrengthLabel"
        Me.passStrengthLabel.Size = New System.Drawing.Size(126, 18)
        Me.passStrengthLabel.TabIndex = 14
        Me.passStrengthLabel.Text = "Password strength :"
        '
        'confirmLabel
        '
        Me.confirmLabel.AutoSize = True
        Me.confirmLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmLabel.Location = New System.Drawing.Point(23, 248)
        Me.confirmLabel.Name = "confirmLabel"
        Me.confirmLabel.Size = New System.Drawing.Size(156, 22)
        Me.confirmLabel.TabIndex = 13
        Me.confirmLabel.Text = "Confirm Password"
        '
        'panelConfirm
        '
        Me.panelConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelConfirm.Controls.Add(Me.repeatPassTB)
        Me.panelConfirm.Location = New System.Drawing.Point(183, 242)
        Me.panelConfirm.Name = "panelConfirm"
        Me.panelConfirm.Size = New System.Drawing.Size(232, 33)
        Me.panelConfirm.TabIndex = 12
        '
        'repeatPassTB
        '
        Me.repeatPassTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.repeatPassTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.repeatPassTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repeatPassTB.Location = New System.Drawing.Point(3, 4)
        Me.repeatPassTB.Name = "repeatPassTB"
        Me.repeatPassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repeatPassTB.Size = New System.Drawing.Size(224, 18)
        Me.repeatPassTB.TabIndex = 0
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(22, 197)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(87, 22)
        Me.passwordLabel.TabIndex = 11
        Me.passwordLabel.Text = "Password"
        '
        'panelPassword
        '
        Me.panelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPassword.Controls.Add(Me.passwordTB)
        Me.panelPassword.Location = New System.Drawing.Point(183, 191)
        Me.panelPassword.Name = "panelPassword"
        Me.panelPassword.Size = New System.Drawing.Size(232, 33)
        Me.panelPassword.TabIndex = 10
        '
        'passwordTB
        '
        Me.passwordTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTB.Location = New System.Drawing.Point(3, 4)
        Me.passwordTB.Name = "passwordTB"
        Me.passwordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTB.Size = New System.Drawing.Size(224, 18)
        Me.passwordTB.TabIndex = 0
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(22, 147)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(122, 22)
        Me.emailLabel.TabIndex = 9
        Me.emailLabel.Text = "Email Address"
        '
        'panelEmail
        '
        Me.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmail.Controls.Add(Me.emailTB)
        Me.panelEmail.Location = New System.Drawing.Point(183, 141)
        Me.panelEmail.Name = "panelEmail"
        Me.panelEmail.Size = New System.Drawing.Size(232, 33)
        Me.panelEmail.TabIndex = 8
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
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(22, 95)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(96, 22)
        Me.lastNameLabel.TabIndex = 7
        Me.lastNameLabel.Text = "Last Name"
        '
        'panelLastName
        '
        Me.panelLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLastName.Controls.Add(Me.lastNameTB)
        Me.panelLastName.Location = New System.Drawing.Point(183, 89)
        Me.panelLastName.Name = "panelLastName"
        Me.panelLastName.Size = New System.Drawing.Size(232, 33)
        Me.panelLastName.TabIndex = 6
        '
        'lastNameTB
        '
        Me.lastNameTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lastNameTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameTB.Location = New System.Drawing.Point(3, 4)
        Me.lastNameTB.Name = "lastNameTB"
        Me.lastNameTB.Size = New System.Drawing.Size(224, 18)
        Me.lastNameTB.TabIndex = 0
        '
        'firstNameLabel
        '
        Me.firstNameLabel.AutoSize = True
        Me.firstNameLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLabel.Location = New System.Drawing.Point(22, 42)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(98, 22)
        Me.firstNameLabel.TabIndex = 5
        Me.firstNameLabel.Text = "First Name"
        '
        'panelFirstName
        '
        Me.panelFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelFirstName.Controls.Add(Me.firstNameTB)
        Me.panelFirstName.Location = New System.Drawing.Point(183, 36)
        Me.panelFirstName.Name = "panelFirstName"
        Me.panelFirstName.Size = New System.Drawing.Size(232, 33)
        Me.panelFirstName.TabIndex = 4
        '
        'firstNameTB
        '
        Me.firstNameTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstNameTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameTB.Location = New System.Drawing.Point(3, 4)
        Me.firstNameTB.Name = "firstNameTB"
        Me.firstNameTB.Size = New System.Drawing.Size(224, 18)
        Me.firstNameTB.TabIndex = 0
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
        Me.titleLabel.Size = New System.Drawing.Size(665, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Mailfy - Create new account"
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
        'Account_dataTableAdapter
        '
        Me.Account_dataTableAdapter.ClearBeforeFill = True
        '
        'registerForm
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
        Me.Name = "registerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy"
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.panelConfirm.ResumeLayout(False)
        Me.panelConfirm.PerformLayout()
        Me.panelPassword.ResumeLayout(False)
        Me.panelPassword.PerformLayout()
        Me.panelEmail.ResumeLayout(False)
        Me.panelEmail.PerformLayout()
        Me.panelLastName.ResumeLayout(False)
        Me.panelLastName.PerformLayout()
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
    Friend WithEvents loginPanel As Panel
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents exitIcon As PictureBox
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents strengthLabel As Label
    Friend WithEvents passStrengthLabel As Label
    Friend WithEvents confirmLabel As Label
    Friend WithEvents panelConfirm As Panel
    Friend WithEvents repeatPassTB As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents panelPassword As Panel
    Friend WithEvents passwordTB As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents panelEmail As Panel
    Friend WithEvents emailTB As TextBox
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents panelLastName As Panel
    Friend WithEvents lastNameTB As TextBox
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents panelFirstName As Panel
    Friend WithEvents firstNameTB As TextBox
    Friend WithEvents registerButton As Button
    Friend WithEvents backIcon As PictureBox
    Friend WithEvents Account_dataTableAdapter As emailDataSetTableAdapters.account_dataTableAdapter
End Class
