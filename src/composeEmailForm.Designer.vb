<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class composeEmailForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(composeEmailForm))
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backIcon = New System.Windows.Forms.PictureBox()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.recipientLabel = New System.Windows.Forms.Label()
        Me.recipientCB = New System.Windows.Forms.ComboBox()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.panelRecipient = New System.Windows.Forms.Panel()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.panelSubject = New System.Windows.Forms.Panel()
        Me.subjectTB = New System.Windows.Forms.TextBox()
        Me.sendButton = New System.Windows.Forms.Button()
        Me.emailBodyTB = New System.Windows.Forms.TextBox()
        Me.MailsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.mailsTableAdapter()
        Me.MailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.titlePanel.SuspendLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRecipient.SuspendLayout()
        Me.panelSubject.SuspendLayout()
        CType(Me.MailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.backIcon)
        Me.titlePanel.Controls.Add(Me.minimizeIcon)
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
        Me.minimizeIcon.Location = New System.Drawing.Point(720, 5)
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
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 560, 0)
        Me.titleLabel.Size = New System.Drawing.Size(666, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Compose Email"
        '
        'recipientLabel
        '
        Me.recipientLabel.AutoSize = True
        Me.recipientLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recipientLabel.Location = New System.Drawing.Point(12, 52)
        Me.recipientLabel.Name = "recipientLabel"
        Me.recipientLabel.Size = New System.Drawing.Size(29, 22)
        Me.recipientLabel.TabIndex = 3
        Me.recipientLabel.Text = "To"
        '
        'recipientCB
        '
        Me.recipientCB.BackColor = System.Drawing.Color.White
        Me.recipientCB.DataSource = Me.AccountsBindingSource
        Me.recipientCB.DisplayMember = "email_address"
        Me.recipientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.recipientCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recipientCB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recipientCB.FormattingEnabled = True
        Me.recipientCB.Location = New System.Drawing.Point(-1, -1)
        Me.recipientCB.Margin = New System.Windows.Forms.Padding(0)
        Me.recipientCB.Name = "recipientCB"
        Me.recipientCB.Size = New System.Drawing.Size(337, 30)
        Me.recipientCB.TabIndex = 4
        Me.recipientCB.ValueMember = "id"
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "accounts"
        Me.AccountsBindingSource.DataSource = Me.EmailDataSet
        '
        'EmailDataSet
        '
        Me.EmailDataSet.DataSetName = "emailDataSet"
        Me.EmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelRecipient
        '
        Me.panelRecipient.BackColor = System.Drawing.Color.White
        Me.panelRecipient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRecipient.Controls.Add(Me.recipientCB)
        Me.panelRecipient.Location = New System.Drawing.Point(172, 48)
        Me.panelRecipient.Margin = New System.Windows.Forms.Padding(0)
        Me.panelRecipient.Name = "panelRecipient"
        Me.panelRecipient.Size = New System.Drawing.Size(336, 30)
        Me.panelRecipient.TabIndex = 5
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectLabel.Location = New System.Drawing.Point(12, 97)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(69, 22)
        Me.subjectLabel.TabIndex = 7
        Me.subjectLabel.Text = "Subject"
        '
        'panelSubject
        '
        Me.panelSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelSubject.Controls.Add(Me.subjectTB)
        Me.panelSubject.Location = New System.Drawing.Point(173, 91)
        Me.panelSubject.Name = "panelSubject"
        Me.panelSubject.Size = New System.Drawing.Size(543, 33)
        Me.panelSubject.TabIndex = 6
        '
        'subjectTB
        '
        Me.subjectTB.BackColor = System.Drawing.Color.White
        Me.subjectTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.subjectTB.Font = New System.Drawing.Font("Open Sans SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectTB.Location = New System.Drawing.Point(3, 4)
        Me.subjectTB.Name = "subjectTB"
        Me.subjectTB.Size = New System.Drawing.Size(535, 21)
        Me.subjectTB.TabIndex = 0
        '
        'sendButton
        '
        Me.sendButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sendButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.sendButton.FlatAppearance.BorderSize = 0
        Me.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendButton.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendButton.Location = New System.Drawing.Point(614, 445)
        Me.sendButton.Name = "sendButton"
        Me.sendButton.Size = New System.Drawing.Size(98, 35)
        Me.sendButton.TabIndex = 17
        Me.sendButton.Text = "Send"
        Me.sendButton.UseVisualStyleBackColor = False
        '
        'emailBodyTB
        '
        Me.emailBodyTB.BackColor = System.Drawing.Color.White
        Me.emailBodyTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailBodyTB.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailBodyTB.Location = New System.Drawing.Point(16, 140)
        Me.emailBodyTB.MaxLength = 2147483647
        Me.emailBodyTB.Multiline = True
        Me.emailBodyTB.Name = "emailBodyTB"
        Me.emailBodyTB.Size = New System.Drawing.Size(700, 285)
        Me.emailBodyTB.TabIndex = 1
        '
        'MailsTableAdapter
        '
        Me.MailsTableAdapter.ClearBeforeFill = True
        '
        'MailsBindingSource
        '
        Me.MailsBindingSource.DataMember = "mails"
        Me.MailsBindingSource.DataSource = Me.EmailDataSet
        '
        'composeEmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.emailBodyTB)
        Me.Controls.Add(Me.sendButton)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.panelSubject)
        Me.Controls.Add(Me.panelRecipient)
        Me.Controls.Add(Me.recipientLabel)
        Me.Controls.Add(Me.titlePanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "composeEmailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy - Compose Email"
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRecipient.ResumeLayout(False)
        Me.panelSubject.ResumeLayout(False)
        Me.panelSubject.PerformLayout()
        CType(Me.MailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents backIcon As PictureBox
    Friend WithEvents recipientLabel As Label
    Friend WithEvents recipientCB As ComboBox
    Friend WithEvents panelRecipient As Panel
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents subjectLabel As Label
    Friend WithEvents panelSubject As Panel
    Friend WithEvents subjectTB As TextBox
    Friend WithEvents sendButton As Button
    Friend WithEvents emailBodyTB As TextBox
    Friend WithEvents MailsTableAdapter As emailDataSetTableAdapters.mailsTableAdapter
    Friend WithEvents MailsBindingSource As BindingSource
End Class
