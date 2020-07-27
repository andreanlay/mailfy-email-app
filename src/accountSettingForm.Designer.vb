<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accountSettingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accountSettingForm))
        Me.dataPanel = New System.Windows.Forms.Panel()
        Me.strengthLabel = New System.Windows.Forms.Label()
        Me.passStrengthLabel = New System.Windows.Forms.Label()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.passwordPanel = New System.Windows.Forms.Panel()
        Me.currentPasswordTB = New System.Windows.Forms.TextBox()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.confirmLabel = New System.Windows.Forms.Label()
        Me.panelConfirm = New System.Windows.Forms.Panel()
        Me.confirmPassTB = New System.Windows.Forms.TextBox()
        Me.newPasswordLabel = New System.Windows.Forms.Label()
        Me.panelNewPassword = New System.Windows.Forms.Panel()
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
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataPanel.SuspendLayout()
        Me.passwordPanel.SuspendLayout()
        Me.panelConfirm.SuspendLayout()
        Me.panelNewPassword.SuspendLayout()
        Me.panelEmail.SuspendLayout()
        Me.panelLastName.SuspendLayout()
        Me.panelFirstName.SuspendLayout()
        Me.titlePanel.SuspendLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataPanel
        '
        Me.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dataPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dataPanel.Controls.Add(Me.strengthLabel)
        Me.dataPanel.Controls.Add(Me.passStrengthLabel)
        Me.dataPanel.Controls.Add(Me.passwordLabel)
        Me.dataPanel.Controls.Add(Me.passwordPanel)
        Me.dataPanel.Controls.Add(Me.updateButton)
        Me.dataPanel.Controls.Add(Me.confirmLabel)
        Me.dataPanel.Controls.Add(Me.panelConfirm)
        Me.dataPanel.Controls.Add(Me.newPasswordLabel)
        Me.dataPanel.Controls.Add(Me.panelNewPassword)
        Me.dataPanel.Controls.Add(Me.emailLabel)
        Me.dataPanel.Controls.Add(Me.panelEmail)
        Me.dataPanel.Controls.Add(Me.lastNameLabel)
        Me.dataPanel.Controls.Add(Me.panelLastName)
        Me.dataPanel.Controls.Add(Me.firstNameLabel)
        Me.dataPanel.Controls.Add(Me.panelFirstName)
        Me.dataPanel.Location = New System.Drawing.Point(151, 41)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(439, 387)
        Me.dataPanel.TabIndex = 1
        '
        'strengthLabel
        '
        Me.strengthLabel.AutoSize = True
        Me.strengthLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strengthLabel.Location = New System.Drawing.Point(302, 318)
        Me.strengthLabel.Name = "strengthLabel"
        Me.strengthLabel.Size = New System.Drawing.Size(0, 18)
        Me.strengthLabel.TabIndex = 20
        '
        'passStrengthLabel
        '
        Me.passStrengthLabel.AutoSize = True
        Me.passStrengthLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passStrengthLabel.Location = New System.Drawing.Point(180, 318)
        Me.passStrengthLabel.Name = "passStrengthLabel"
        Me.passStrengthLabel.Size = New System.Drawing.Size(126, 18)
        Me.passStrengthLabel.TabIndex = 19
        Me.passStrengthLabel.Text = "Password strength :"
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.Location = New System.Drawing.Point(22, 192)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(153, 22)
        Me.passwordLabel.TabIndex = 18
        Me.passwordLabel.Text = "Current Password"
        '
        'passwordPanel
        '
        Me.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passwordPanel.Controls.Add(Me.currentPasswordTB)
        Me.passwordPanel.Location = New System.Drawing.Point(183, 186)
        Me.passwordPanel.Name = "passwordPanel"
        Me.passwordPanel.Size = New System.Drawing.Size(232, 33)
        Me.passwordPanel.TabIndex = 17
        '
        'currentPasswordTB
        '
        Me.currentPasswordTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.currentPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.currentPasswordTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentPasswordTB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.currentPasswordTB.Location = New System.Drawing.Point(3, 4)
        Me.currentPasswordTB.Name = "currentPasswordTB"
        Me.currentPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.currentPasswordTB.Size = New System.Drawing.Size(224, 18)
        Me.currentPasswordTB.TabIndex = 0
        '
        'updateButton
        '
        Me.updateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.updateButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.updateButton.FlatAppearance.BorderSize = 0
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateButton.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateButton.Location = New System.Drawing.Point(170, 344)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(98, 35)
        Me.updateButton.TabIndex = 16
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = False
        '
        'confirmLabel
        '
        Me.confirmLabel.AutoSize = True
        Me.confirmLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmLabel.Location = New System.Drawing.Point(23, 289)
        Me.confirmLabel.Name = "confirmLabel"
        Me.confirmLabel.Size = New System.Drawing.Size(156, 22)
        Me.confirmLabel.TabIndex = 13
        Me.confirmLabel.Text = "Confirm Password"
        '
        'panelConfirm
        '
        Me.panelConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelConfirm.Controls.Add(Me.confirmPassTB)
        Me.panelConfirm.Location = New System.Drawing.Point(183, 283)
        Me.panelConfirm.Name = "panelConfirm"
        Me.panelConfirm.Size = New System.Drawing.Size(232, 33)
        Me.panelConfirm.TabIndex = 12
        '
        'confirmPassTB
        '
        Me.confirmPassTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.confirmPassTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmPassTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmPassTB.Location = New System.Drawing.Point(3, 4)
        Me.confirmPassTB.Name = "confirmPassTB"
        Me.confirmPassTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmPassTB.Size = New System.Drawing.Size(224, 18)
        Me.confirmPassTB.TabIndex = 0
        '
        'newPasswordLabel
        '
        Me.newPasswordLabel.AutoSize = True
        Me.newPasswordLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPasswordLabel.Location = New System.Drawing.Point(22, 238)
        Me.newPasswordLabel.Name = "newPasswordLabel"
        Me.newPasswordLabel.Size = New System.Drawing.Size(127, 22)
        Me.newPasswordLabel.TabIndex = 11
        Me.newPasswordLabel.Text = "New Password"
        '
        'panelNewPassword
        '
        Me.panelNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelNewPassword.Controls.Add(Me.passwordTB)
        Me.panelNewPassword.Location = New System.Drawing.Point(183, 232)
        Me.panelNewPassword.Name = "panelNewPassword"
        Me.panelNewPassword.Size = New System.Drawing.Size(232, 33)
        Me.panelNewPassword.TabIndex = 10
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
        Me.emailLabel.Location = New System.Drawing.Point(22, 145)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(122, 22)
        Me.emailLabel.TabIndex = 9
        Me.emailLabel.Text = "Email Address"
        '
        'panelEmail
        '
        Me.panelEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmail.Controls.Add(Me.emailTB)
        Me.panelEmail.Location = New System.Drawing.Point(183, 139)
        Me.panelEmail.Name = "panelEmail"
        Me.panelEmail.Size = New System.Drawing.Size(232, 33)
        Me.panelEmail.TabIndex = 8
        '
        'emailTB
        '
        Me.emailTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.emailTB.Cursor = System.Windows.Forms.Cursors.Default
        Me.emailTB.Enabled = False
        Me.emailTB.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTB.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.emailTB.Location = New System.Drawing.Point(3, 4)
        Me.emailTB.Name = "emailTB"
        Me.emailTB.ReadOnly = True
        Me.emailTB.Size = New System.Drawing.Size(224, 18)
        Me.emailTB.TabIndex = 0
        '
        'lastNameLabel
        '
        Me.lastNameLabel.AutoSize = True
        Me.lastNameLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(22, 93)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(96, 22)
        Me.lastNameLabel.TabIndex = 7
        Me.lastNameLabel.Text = "Last Name"
        '
        'panelLastName
        '
        Me.panelLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLastName.Controls.Add(Me.lastNameTB)
        Me.panelLastName.Location = New System.Drawing.Point(183, 87)
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
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(29, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 595, 0)
        Me.titleLabel.Size = New System.Drawing.Size(708, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Account Setting"
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
        'accountSettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.titlePanel)
        Me.Controls.Add(Me.dataPanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accountSettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy - Account Setting"
        Me.dataPanel.ResumeLayout(False)
        Me.dataPanel.PerformLayout()
        Me.passwordPanel.ResumeLayout(False)
        Me.passwordPanel.PerformLayout()
        Me.panelConfirm.ResumeLayout(False)
        Me.panelConfirm.PerformLayout()
        Me.panelNewPassword.ResumeLayout(False)
        Me.panelNewPassword.PerformLayout()
        Me.panelEmail.ResumeLayout(False)
        Me.panelEmail.PerformLayout()
        Me.panelLastName.ResumeLayout(False)
        Me.panelLastName.PerformLayout()
        Me.panelFirstName.ResumeLayout(False)
        Me.panelFirstName.PerformLayout()
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataPanel As Panel
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents confirmLabel As Label
    Friend WithEvents panelConfirm As Panel
    Friend WithEvents confirmPassTB As TextBox
    Friend WithEvents newPasswordLabel As Label
    Friend WithEvents panelNewPassword As Panel
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
    Friend WithEvents updateButton As Button
    Friend WithEvents backIcon As PictureBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordPanel As Panel
    Friend WithEvents currentPasswordTB As TextBox
    Friend WithEvents passStrengthLabel As Label
    Friend WithEvents strengthLabel As Label
End Class
