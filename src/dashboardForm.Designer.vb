<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboardForm))
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.logoutLabel = New System.Windows.Forms.Label()
        Me.minimizeIcon = New System.Windows.Forms.PictureBox()
        Me.exitIcon = New System.Windows.Forms.PictureBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.mainAccountPanel = New System.Windows.Forms.SplitContainer()
        Me.userIcon = New System.Windows.Forms.PictureBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.themePanel = New System.Windows.Forms.Panel()
        Me.themeLabel = New System.Windows.Forms.Label()
        Me.themeIcon = New System.Windows.Forms.PictureBox()
        Me.accountSettingPanel = New System.Windows.Forms.Panel()
        Me.accountSettingLabel = New System.Windows.Forms.Label()
        Me.settingIcon = New System.Windows.Forms.PictureBox()
        Me.composePanel = New System.Windows.Forms.Panel()
        Me.composeLabel = New System.Windows.Forms.Label()
        Me.composeIcon = New System.Windows.Forms.PictureBox()
        Me.aboutPanel = New System.Windows.Forms.Panel()
        Me.aboutAppLabel = New System.Windows.Forms.Label()
        Me.aboutIcon = New System.Windows.Forms.PictureBox()
        Me.mainEmailPanel = New System.Windows.Forms.SplitContainer()
        Me.HeaderMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.markAsReadPanel = New System.Windows.Forms.Panel()
        Me.markAsReadLabel = New System.Windows.Forms.Label()
        Me.markAsReadIcon = New System.Windows.Forms.PictureBox()
        Me.deletePanel = New System.Windows.Forms.Panel()
        Me.deleteLabel = New System.Windows.Forms.Label()
        Me.deleteIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.inboxTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AccountsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.accountsTableAdapter()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailDataSet = New Final_Project__Email_App_.emailDataSet()
        Me.MailsTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.mailsTableAdapter()
        Me.Account_dataTableAdapter = New Final_Project__Email_App_.emailDataSetTableAdapters.account_dataTableAdapter()
        Me.AccountDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.titlePanel.SuspendLayout()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainAccountPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainAccountPanel.Panel1.SuspendLayout()
        Me.mainAccountPanel.Panel2.SuspendLayout()
        Me.mainAccountPanel.SuspendLayout()
        CType(Me.userIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.themePanel.SuspendLayout()
        CType(Me.themeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.accountSettingPanel.SuspendLayout()
        CType(Me.settingIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.composePanel.SuspendLayout()
        CType(Me.composeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.aboutPanel.SuspendLayout()
        CType(Me.aboutIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainEmailPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainEmailPanel.Panel1.SuspendLayout()
        Me.mainEmailPanel.Panel2.SuspendLayout()
        Me.mainEmailPanel.SuspendLayout()
        Me.HeaderMenu.SuspendLayout()
        Me.markAsReadPanel.SuspendLayout()
        CType(Me.markAsReadIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.deletePanel.SuspendLayout()
        CType(Me.deleteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlePanel
        '
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.titlePanel.Controls.Add(Me.logoutLabel)
        Me.titlePanel.Controls.Add(Me.minimizeIcon)
        Me.titlePanel.Controls.Add(Me.exitIcon)
        Me.titlePanel.Controls.Add(Me.titleLabel)
        Me.titlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlePanel.Location = New System.Drawing.Point(0, 0)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(741, 24)
        Me.titlePanel.TabIndex = 2
        '
        'logoutLabel
        '
        Me.logoutLabel.AutoSize = True
        Me.logoutLabel.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutLabel.Location = New System.Drawing.Point(3, 4)
        Me.logoutLabel.Name = "logoutLabel"
        Me.logoutLabel.Size = New System.Drawing.Size(73, 18)
        Me.logoutLabel.TabIndex = 6
        Me.logoutLabel.Text = "< Logout |"
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
        Me.titleLabel.Location = New System.Drawing.Point(73, 4)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Padding = New System.Windows.Forms.Padding(0, 0, 490, 0)
        Me.titleLabel.Size = New System.Drawing.Size(569, 18)
        Me.titleLabel.TabIndex = 3
        Me.titleLabel.Text = "Dashboard"
        '
        'mainAccountPanel
        '
        Me.mainAccountPanel.BackColor = System.Drawing.Color.LightGray
        Me.mainAccountPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.mainAccountPanel.Location = New System.Drawing.Point(0, 24)
        Me.mainAccountPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.mainAccountPanel.Name = "mainAccountPanel"
        Me.mainAccountPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'mainAccountPanel.Panel1
        '
        Me.mainAccountPanel.Panel1.BackColor = System.Drawing.Color.White
        Me.mainAccountPanel.Panel1.Controls.Add(Me.userIcon)
        Me.mainAccountPanel.Panel1.Controls.Add(Me.usernameLabel)
        '
        'mainAccountPanel.Panel2
        '
        Me.mainAccountPanel.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mainAccountPanel.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.mainAccountPanel.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainAccountPanel.Size = New System.Drawing.Size(196, 468)
        Me.mainAccountPanel.SplitterDistance = 65
        Me.mainAccountPanel.SplitterWidth = 1
        Me.mainAccountPanel.TabIndex = 10
        '
        'userIcon
        '
        Me.userIcon.Image = CType(resources.GetObject("userIcon.Image"), System.Drawing.Image)
        Me.userIcon.Location = New System.Drawing.Point(10, 10)
        Me.userIcon.Name = "userIcon"
        Me.userIcon.Size = New System.Drawing.Size(51, 43)
        Me.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.userIcon.TabIndex = 12
        Me.userIcon.TabStop = False
        '
        'usernameLabel
        '
        Me.usernameLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.usernameLabel.Location = New System.Drawing.Point(63, 18)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(126, 25)
        Me.usernameLabel.TabIndex = 11
        Me.usernameLabel.Text = "Test Name"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.themePanel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.accountSettingPanel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.composePanel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.aboutPanel, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(196, 402)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'themePanel
        '
        Me.themePanel.Controls.Add(Me.themeLabel)
        Me.themePanel.Controls.Add(Me.themeIcon)
        Me.themePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.themePanel.Location = New System.Drawing.Point(0, 310)
        Me.themePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.themePanel.Name = "themePanel"
        Me.themePanel.Size = New System.Drawing.Size(196, 45)
        Me.themePanel.TabIndex = 13
        '
        'themeLabel
        '
        Me.themeLabel.AutoSize = True
        Me.themeLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.themeLabel.Location = New System.Drawing.Point(56, 13)
        Me.themeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.themeLabel.Name = "themeLabel"
        Me.themeLabel.Size = New System.Drawing.Size(107, 22)
        Me.themeLabel.TabIndex = 1
        Me.themeLabel.Text = "Color Theme"
        '
        'themeIcon
        '
        Me.themeIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.ColorPalette
        Me.themeIcon.Location = New System.Drawing.Point(7, 8)
        Me.themeIcon.Name = "themeIcon"
        Me.themeIcon.Size = New System.Drawing.Size(46, 34)
        Me.themeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.themeIcon.TabIndex = 1
        Me.themeIcon.TabStop = False
        '
        'accountSettingPanel
        '
        Me.accountSettingPanel.Controls.Add(Me.accountSettingLabel)
        Me.accountSettingPanel.Controls.Add(Me.settingIcon)
        Me.accountSettingPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.accountSettingPanel.Location = New System.Drawing.Point(0, 263)
        Me.accountSettingPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.accountSettingPanel.Name = "accountSettingPanel"
        Me.accountSettingPanel.Size = New System.Drawing.Size(196, 47)
        Me.accountSettingPanel.TabIndex = 12
        '
        'accountSettingLabel
        '
        Me.accountSettingLabel.AutoSize = True
        Me.accountSettingLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.accountSettingLabel.Location = New System.Drawing.Point(56, 13)
        Me.accountSettingLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.accountSettingLabel.Name = "accountSettingLabel"
        Me.accountSettingLabel.Size = New System.Drawing.Size(130, 22)
        Me.accountSettingLabel.TabIndex = 1
        Me.accountSettingLabel.Text = "Account Setting"
        '
        'settingIcon
        '
        Me.settingIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.setting
        Me.settingIcon.Location = New System.Drawing.Point(7, 11)
        Me.settingIcon.Name = "settingIcon"
        Me.settingIcon.Size = New System.Drawing.Size(43, 26)
        Me.settingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.settingIcon.TabIndex = 1
        Me.settingIcon.TabStop = False
        '
        'composePanel
        '
        Me.composePanel.Controls.Add(Me.composeLabel)
        Me.composePanel.Controls.Add(Me.composeIcon)
        Me.composePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.composePanel.Location = New System.Drawing.Point(0, 0)
        Me.composePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.composePanel.Name = "composePanel"
        Me.composePanel.Size = New System.Drawing.Size(196, 48)
        Me.composePanel.TabIndex = 3
        '
        'composeLabel
        '
        Me.composeLabel.AutoSize = True
        Me.composeLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.composeLabel.Location = New System.Drawing.Point(52, 13)
        Me.composeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.composeLabel.Name = "composeLabel"
        Me.composeLabel.Size = New System.Drawing.Size(127, 22)
        Me.composeLabel.TabIndex = 1
        Me.composeLabel.Text = "Compose Email"
        '
        'composeIcon
        '
        Me.composeIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.write
        Me.composeIcon.Location = New System.Drawing.Point(7, 11)
        Me.composeIcon.Name = "composeIcon"
        Me.composeIcon.Size = New System.Drawing.Size(43, 26)
        Me.composeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.composeIcon.TabIndex = 1
        Me.composeIcon.TabStop = False
        '
        'aboutPanel
        '
        Me.aboutPanel.Controls.Add(Me.aboutAppLabel)
        Me.aboutPanel.Controls.Add(Me.aboutIcon)
        Me.aboutPanel.Location = New System.Drawing.Point(0, 355)
        Me.aboutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.aboutPanel.Name = "aboutPanel"
        Me.aboutPanel.Size = New System.Drawing.Size(196, 47)
        Me.aboutPanel.TabIndex = 2
        '
        'aboutAppLabel
        '
        Me.aboutAppLabel.AutoSize = True
        Me.aboutAppLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.aboutAppLabel.Location = New System.Drawing.Point(57, 13)
        Me.aboutAppLabel.Name = "aboutAppLabel"
        Me.aboutAppLabel.Size = New System.Drawing.Size(92, 22)
        Me.aboutAppLabel.TabIndex = 1
        Me.aboutAppLabel.Text = "About App"
        '
        'aboutIcon
        '
        Me.aboutIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.info
        Me.aboutIcon.Location = New System.Drawing.Point(8, 9)
        Me.aboutIcon.Name = "aboutIcon"
        Me.aboutIcon.Size = New System.Drawing.Size(43, 29)
        Me.aboutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.aboutIcon.TabIndex = 1
        Me.aboutIcon.TabStop = False
        '
        'mainEmailPanel
        '
        Me.mainEmailPanel.BackColor = System.Drawing.Color.LightGray
        Me.mainEmailPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainEmailPanel.IsSplitterFixed = True
        Me.mainEmailPanel.Location = New System.Drawing.Point(196, 24)
        Me.mainEmailPanel.Name = "mainEmailPanel"
        Me.mainEmailPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'mainEmailPanel.Panel1
        '
        Me.mainEmailPanel.Panel1.BackColor = System.Drawing.Color.White
        Me.mainEmailPanel.Panel1.Controls.Add(Me.HeaderMenu)
        '
        'mainEmailPanel.Panel2
        '
        Me.mainEmailPanel.Panel2.AutoScroll = True
        Me.mainEmailPanel.Panel2.BackColor = System.Drawing.Color.White
        Me.mainEmailPanel.Panel2.Controls.Add(Me.inboxTablePanel)
        Me.mainEmailPanel.Size = New System.Drawing.Size(545, 468)
        Me.mainEmailPanel.SplitterDistance = 65
        Me.mainEmailPanel.SplitterWidth = 1
        Me.mainEmailPanel.TabIndex = 11
        '
        'HeaderMenu
        '
        Me.HeaderMenu.ColumnCount = 3
        Me.HeaderMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.85417!))
        Me.HeaderMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.14583!))
        Me.HeaderMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.HeaderMenu.Controls.Add(Me.markAsReadPanel, 0, 0)
        Me.HeaderMenu.Controls.Add(Me.deletePanel, 2, 0)
        Me.HeaderMenu.Controls.Add(Me.Panel1, 0, 0)
        Me.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderMenu.Location = New System.Drawing.Point(0, 0)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.RowCount = 1
        Me.HeaderMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.HeaderMenu.Size = New System.Drawing.Size(545, 65)
        Me.HeaderMenu.TabIndex = 0
        '
        'markAsReadPanel
        '
        Me.markAsReadPanel.Controls.Add(Me.markAsReadLabel)
        Me.markAsReadPanel.Controls.Add(Me.markAsReadIcon)
        Me.markAsReadPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markAsReadPanel.Location = New System.Drawing.Point(223, 0)
        Me.markAsReadPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.markAsReadPanel.Name = "markAsReadPanel"
        Me.markAsReadPanel.Size = New System.Drawing.Size(156, 65)
        Me.markAsReadPanel.TabIndex = 3
        '
        'markAsReadLabel
        '
        Me.markAsReadLabel.AutoSize = True
        Me.markAsReadLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.markAsReadLabel.Location = New System.Drawing.Point(45, 23)
        Me.markAsReadLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.markAsReadLabel.Name = "markAsReadLabel"
        Me.markAsReadLabel.Size = New System.Drawing.Size(110, 22)
        Me.markAsReadLabel.TabIndex = 2
        Me.markAsReadLabel.Text = "Mark as read" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'markAsReadIcon
        '
        Me.markAsReadIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.openMail
        Me.markAsReadIcon.Location = New System.Drawing.Point(3, 18)
        Me.markAsReadIcon.Name = "markAsReadIcon"
        Me.markAsReadIcon.Size = New System.Drawing.Size(39, 30)
        Me.markAsReadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.markAsReadIcon.TabIndex = 0
        Me.markAsReadIcon.TabStop = False
        '
        'deletePanel
        '
        Me.deletePanel.Controls.Add(Me.deleteLabel)
        Me.deletePanel.Controls.Add(Me.deleteIcon)
        Me.deletePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deletePanel.Location = New System.Drawing.Point(379, 0)
        Me.deletePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.deletePanel.Name = "deletePanel"
        Me.deletePanel.Size = New System.Drawing.Size(166, 65)
        Me.deletePanel.TabIndex = 0
        '
        'deleteLabel
        '
        Me.deleteLabel.AutoSize = True
        Me.deleteLabel.Font = New System.Drawing.Font("Open Sans SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.deleteLabel.Location = New System.Drawing.Point(45, 23)
        Me.deleteLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.deleteLabel.Name = "deleteLabel"
        Me.deleteLabel.Size = New System.Drawing.Size(104, 22)
        Me.deleteLabel.TabIndex = 2
        Me.deleteLabel.Text = "Delete Email"
        '
        'deleteIcon
        '
        Me.deleteIcon.Image = Global.Final_Project__Email_App_.My.Resources.Resources.trash
        Me.deleteIcon.Location = New System.Drawing.Point(5, 18)
        Me.deleteIcon.Name = "deleteIcon"
        Me.deleteIcon.Size = New System.Drawing.Size(39, 30)
        Me.deleteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deleteIcon.TabIndex = 0
        Me.deleteIcon.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 65)
        Me.Panel1.TabIndex = 1
        '
        'inboxTablePanel
        '
        Me.inboxTablePanel.AutoSize = True
        Me.inboxTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.inboxTablePanel.ColumnCount = 1
        Me.inboxTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.inboxTablePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.inboxTablePanel.Location = New System.Drawing.Point(0, 0)
        Me.inboxTablePanel.Name = "inboxTablePanel"
        Me.inboxTablePanel.RowCount = 5
        Me.inboxTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.inboxTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.inboxTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.inboxTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.inboxTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.inboxTablePanel.Size = New System.Drawing.Size(545, 375)
        Me.inboxTablePanel.TabIndex = 0
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
        'EmailDataSet
        '
        Me.EmailDataSet.DataSetName = "emailDataSet"
        Me.EmailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MailsTableAdapter
        '
        Me.MailsTableAdapter.ClearBeforeFill = True
        '
        'Account_dataTableAdapter
        '
        Me.Account_dataTableAdapter.ClearBeforeFill = True
        '
        'AccountDataBindingSource
        '
        Me.AccountDataBindingSource.DataMember = "Account data"
        Me.AccountDataBindingSource.DataSource = Me.AccountsBindingSource
        '
        'dashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 492)
        Me.Controls.Add(Me.mainEmailPanel)
        Me.Controls.Add(Me.mainAccountPanel)
        Me.Controls.Add(Me.titlePanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mailfy"
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        CType(Me.minimizeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainAccountPanel.Panel1.ResumeLayout(False)
        Me.mainAccountPanel.Panel2.ResumeLayout(False)
        CType(Me.mainAccountPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainAccountPanel.ResumeLayout(False)
        CType(Me.userIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.themePanel.ResumeLayout(False)
        Me.themePanel.PerformLayout()
        CType(Me.themeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.accountSettingPanel.ResumeLayout(False)
        Me.accountSettingPanel.PerformLayout()
        CType(Me.settingIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.composePanel.ResumeLayout(False)
        Me.composePanel.PerformLayout()
        CType(Me.composeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.aboutPanel.ResumeLayout(False)
        Me.aboutPanel.PerformLayout()
        CType(Me.aboutIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainEmailPanel.Panel1.ResumeLayout(False)
        Me.mainEmailPanel.Panel2.ResumeLayout(False)
        Me.mainEmailPanel.Panel2.PerformLayout()
        CType(Me.mainEmailPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainEmailPanel.ResumeLayout(False)
        Me.HeaderMenu.ResumeLayout(False)
        Me.markAsReadPanel.ResumeLayout(False)
        Me.markAsReadPanel.PerformLayout()
        CType(Me.markAsReadIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.deletePanel.ResumeLayout(False)
        Me.deletePanel.PerformLayout()
        CType(Me.deleteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents titlePanel As Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents minimizeIcon As PictureBox
    Friend WithEvents logoutLabel As Label
    Friend WithEvents AccountsTableAdapter As emailDataSetTableAdapters.accountsTableAdapter
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents EmailDataSet As emailDataSet
    Friend WithEvents mainAccountPanel As SplitContainer
    Friend WithEvents userIcon As PictureBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents mainEmailPanel As SplitContainer
    Friend WithEvents aboutPanel As Panel
    Friend WithEvents aboutIcon As PictureBox
    Friend WithEvents aboutAppLabel As Label
    Friend WithEvents composePanel As Panel
    Friend WithEvents composeLabel As Label
    Friend WithEvents composeIcon As PictureBox
    Friend WithEvents accountSettingPanel As Panel
    Friend WithEvents accountSettingLabel As Label
    Friend WithEvents settingIcon As PictureBox
    Friend WithEvents themePanel As Panel
    Friend WithEvents themeLabel As Label
    Friend WithEvents themeIcon As PictureBox
    Friend WithEvents inboxTablePanel As TableLayoutPanel
    Friend WithEvents MailsTableAdapter As emailDataSetTableAdapters.mailsTableAdapter
    Friend WithEvents HeaderMenu As TableLayoutPanel
    Friend WithEvents Account_dataTableAdapter As emailDataSetTableAdapters.account_dataTableAdapter
    Friend WithEvents deletePanel As Panel
    Friend WithEvents deleteLabel As Label
    Friend WithEvents deleteIcon As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AccountDataBindingSource As BindingSource
    Friend WithEvents markAsReadPanel As Panel
    Friend WithEvents markAsReadLabel As Label
    Friend WithEvents markAsReadIcon As PictureBox
    Friend WithEvents exitIcon As PictureBox
End Class
