Imports System.Text.RegularExpressions

Public Class dashboardForm
    Private email As String = loginForm.emailTB.Text.ToLower
    Private id As Integer

    Public theme As Color = Color.FromArgb(39, 174, 96)
    Private colorList() As Color = New Color() {Color.FromArgb(255, 128, 255), Color.FromArgb(128, 128, 255),
                                           Color.FromArgb(128, 255, 255), Color.FromArgb(128, 255, 128),
                                           Color.FromArgb(255, 255, 128), Color.FromArgb(255, 192, 128),
                                           Color.FromArgb(255, 128, 128), Color.FromArgb(224, 224, 224)}
    Private emailList As ArrayList = New ArrayList()
    Private colorCounter As Integer

    Dim dragFlag As Boolean
    Dim pointClicked As Point


    Private data As DataTable


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameLabel.Text = AccountsTableAdapter.getFirstName(email) + " " + AccountsTableAdapter.getLastName(email)
        id = AccountsTableAdapter.getID(email)
        RefreshInbox()

        Dim newCount As Integer = MailsTableAdapter.countSentEmail(id)
        Dim oldCount As Integer = Account_dataTableAdapter.getUnreadMail(id)
        If oldCount < newCount Then
            MessageBox.Show("You have a new mail!")
        End If
    End Sub
    Public Sub RefreshDashboard()
        usernameLabel.Text = AccountsTableAdapter.getFirstName(email) + " " + AccountsTableAdapter.getLastName(email)
        titlePanel.BackColor = theme
        usernameLabel.ForeColor = theme
    End Sub
    Private Sub displayEmail(id As String, sender As String, subject As String, body As String, status As String, time As String)
        Dim senderName As Label = New Label
        Dim emailSubject As Label = New Label
        Dim emailBody As Label = New Label
        Dim emailTime As Label = New Label
        Dim panel As Panel = New Panel
        Dim colorTag As Panel = New Panel
        Dim checkBox As CheckBox = New CheckBox

        emailList.Add(id)

        senderName.Name = "sender" + id
        senderName.Text = sender
        If status = "Sent" Then
            senderName.Font = New Font("Open Sans Semibold", 11.25)
        Else
            senderName.Font = New Font("Open Sans", 11.25)
        End If
        senderName.Size = New Size(180, 23)

        emailSubject.Name = "subject" + id
        emailSubject.Text = subject
        emailSubject.Font = New Font("Open Sans", 11.25)
        emailSubject.Size = New Size(180, 23)

        emailBody.Name = "body" + id
        emailBody.Text = body
        emailBody.Font = New Font("Open Sans", 11.25)
        emailBody.Size = New Size(517, 41)

        emailTime.Name = "time" + id
        emailTime.Text = time
        emailTime.Font = New Font("Open Sans", 9)
        emailTime.Size = New Size(115, 23)
        emailTime.TextAlign = ContentAlignment.TopRight

        colorTag.Name = "TagPanel" + id
        colorTag.BackColor = colorList(colorCounter Mod 8)
        colorTag.Size = New Size(10, 25)
        colorCounter += 1

        checkBox.Name = "checkBox" + id
        checkBox.FlatStyle = FlatStyle.Flat
        checkBox.Text = ""

        panel.Name = "Panel" + id
        panel.Dock = DockStyle.Fill
        panel.Margin = New Padding(0, 0, 0, 0)

        panel.Controls.Add(senderName)
        panel.Controls.Add(emailSubject)
        panel.Controls.Add(emailBody)
        panel.Controls.Add(emailTime)
        panel.Controls.Add(colorTag)
        panel.Controls.Add(checkBox)

        senderName.Location = New Point(16, 8)
        emailSubject.Location = New Point(202, 8)
        emailBody.Location = New Point(16, 33)
        emailTime.Location = New Point(413, 2)
        colorTag.Location = New Point(0, 0)
        checkBox.Location = New Point(0, 35)

        AddHandler panel.MouseHover, AddressOf Me.InboxItem_Hover
        AddHandler senderName.MouseHover, AddressOf Me.InboxItem_Hover
        AddHandler emailSubject.MouseHover, AddressOf Me.InboxItem_Hover
        AddHandler emailBody.MouseHover, AddressOf Me.InboxItem_Hover
        AddHandler emailTime.MouseHover, AddressOf Me.InboxItem_Hover
        AddHandler colorTag.MouseHover, AddressOf Me.InboxItem_Hover

        AddHandler panel.MouseLeave, AddressOf Me.InboxItem_Leave
        AddHandler senderName.MouseLeave, AddressOf Me.InboxItem_Leave
        AddHandler emailSubject.MouseLeave, AddressOf Me.InboxItem_Leave
        AddHandler emailBody.MouseLeave, AddressOf Me.InboxItem_Leave
        AddHandler emailTime.MouseLeave, AddressOf Me.InboxItem_Leave
        AddHandler colorTag.MouseLeave, AddressOf Me.InboxItem_Leave

        AddHandler panel.Click, AddressOf Me.InboxItem_Click
        AddHandler senderName.Click, AddressOf Me.InboxItem_Click
        AddHandler emailSubject.Click, AddressOf Me.InboxItem_Click
        AddHandler emailBody.Click, AddressOf Me.InboxItem_Click
        AddHandler emailTime.Click, AddressOf Me.InboxItem_Click
        AddHandler colorTag.Click, AddressOf Me.InboxItem_Click

        inboxTablePanel.RowCount += 1
        inboxTablePanel.RowStyles.Add(New RowStyle(SizeType.Absolute = 75))
        inboxTablePanel.Controls.Add(panel)
    End Sub
    Public Sub RefreshInbox()
        inboxTablePanel.Controls.Clear()
        Dim emailID As String
        Dim sender As String
        Dim subject As String
        Dim body As String
        Dim status As String
        Dim time As String

        data = MailsTableAdapter.GetDataByRecipient(id)
        For Each row As DataRow In data.Rows
            emailID = row.Field(Of Integer)(0)
            sender = AccountsTableAdapter.getNameByID(row.Field(Of Integer)(1))
            subject = row.Field(Of String)(3)
            body = row.Field(Of String)(4)
            status = row.Field(Of String)(5)
            time = row.Field(Of String)(6)
            displayEmail(emailID, sender, subject, body, status, time)
        Next
    End Sub


    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles exitIcon.Click
        Account_dataTableAdapter.updateMailData(MailsTableAdapter.countReadEmail(id), MailsTableAdapter.countSentEmail(id), id)
        Application.Exit()
    End Sub
    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimizeIcon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub TitleBar_Down(sender As Object, e As MouseEventArgs) Handles titleLabel.MouseDown
        If e.Button = MouseButtons.Left Then
            dragFlag = True
            pointClicked = New Point(e.X, e.Y)
        Else
            dragFlag = False
        End If
    End Sub
    Private Sub TitleBar_Move(sender As Object, e As MouseEventArgs) Handles titleLabel.MouseMove
        If dragFlag Then
            Dim newPoint As Point
            newPoint = Me.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(-pointClicked.X, -pointClicked.Y - (Me.Height - Me.DisplayRectangle.Height))
            Me.Location = newPoint
        End If
    End Sub
    Private Sub TitleBar_Up(sender As Object, e As MouseEventArgs) Handles titleLabel.MouseUp
        dragFlag = False
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logoutLabel.Click
        Me.Close()
        Account_dataTableAdapter.updateMailData(MailsTableAdapter.countReadEmail(id), MailsTableAdapter.countSentEmail(id), id)
        loginForm.Show()
    End Sub


    Private Sub MarkAsReadLabel_Click(sender As Object, e As EventArgs) Handles markAsReadLabel.Click
        Dim cb As CheckBox
        Dim flag As Boolean = False
        For i = 0 To emailList.Count - 1
            If inboxTablePanel.Controls.Find("checkBox" + emailList(i), True).Count = 1 Then
                cb = inboxTablePanel.Controls.Find("checkBox" + emailList(i), True)(0)
            Else
                Continue For
            End If
            If cb.Checked Then
                MailsTableAdapter.updateEmailStatus(Val(emailList(i)))
                flag = True
            End If
        Next
        If flag Then
            RefreshInbox()
        Else
            MessageBox.Show("Select a mail to mark!", "Error")
        End If
    End Sub
    Private Sub DeleteLabel_Click(sender As Object, e As EventArgs) Handles deleteLabel.Click
        Dim cb As CheckBox
        Dim flag As Boolean = False
        For i = 0 To emailList.Count - 1
            If inboxTablePanel.Controls.Find("checkBox" + emailList(i), True).Count = 1 Then
                cb = inboxTablePanel.Controls.Find("checkBox" + emailList(i), True)(0)
            Else
                Continue For
            End If
            If cb.Checked Then
                MailsTableAdapter.deleteMail(Val(emailList(i)))
                flag = True
            End If
        Next
        If flag Then
            RefreshInbox()
        Else
            MessageBox.Show("Select a mail to delete!", "Error")
        End If
    End Sub
    Private Sub accountSetting_Click(sender As Object, e As EventArgs) Handles accountSettingLabel.Click, accountSettingPanel.Click, settingIcon.Click
        Dim settings As New accountSettingForm(email)
        settings.Show()
    End Sub
    Private Sub ColorTheme_Click(sender As Object, e As EventArgs) Handles themeLabel.Click, themePanel.Click, themeIcon.Click
        colorPaletteForm.Show()
    End Sub
    Private Sub AboutAppLabel_Click(sender As Object, e As EventArgs) Handles aboutAppLabel.Click, aboutPanel.Click, aboutIcon.Click
        aboutForm.Show()
    End Sub
    Private Sub ComposeLabel_Click(sender As Object, e As EventArgs) Handles composeLabel.Click, deletePanel.Click, deleteIcon.Click
        Dim compose As New composeEmailForm(id)
        compose.Show()
    End Sub


    Private Sub MarkAsReadPanel_Hover(sender As Object, e As EventArgs) Handles markAsReadPanel.MouseHover, markAsReadIcon.MouseHover, markAsReadLabel.MouseHover
        markAsReadPanel.BackColor = theme
    End Sub
    Private Sub MarkAsReadPanel_Leave(sender As Object, e As EventArgs) Handles markAsReadPanel.MouseLeave, markAsReadIcon.MouseLeave, markAsReadLabel.MouseLeave
        markAsReadPanel.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub DeletePanel_Hover(sender As Object, e As EventArgs) Handles deletePanel.MouseHover, deleteIcon.MouseHover, deleteLabel.MouseHover
        deletePanel.BackColor = theme
    End Sub
    Private Sub DeletePanel_Leave(sender As Object, e As EventArgs) Handles deletePanel.MouseLeave, deleteIcon.MouseLeave, deleteLabel.MouseLeave
        deletePanel.BackColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub AboutPanel_Hover(sender As Object, e As EventArgs) Handles aboutPanel.MouseHover, aboutIcon.MouseHover, aboutAppLabel.MouseHover
        aboutPanel.BackColor = theme
    End Sub
    Private Sub AboutPanel_Leave(sender As Object, e As EventArgs) Handles aboutPanel.MouseLeave, aboutIcon.MouseLeave, aboutAppLabel.MouseLeave
        aboutPanel.BackColor = Color.FromArgb(245, 245, 245)
    End Sub
    Private Sub ThemePanel_Hover(sender As Object, e As EventArgs) Handles themePanel.MouseHover, themeIcon.MouseHover, themeLabel.MouseHover
        themePanel.BackColor = theme
    End Sub
    Private Sub ThemePanel_Leave(sender As Object, e As EventArgs) Handles themePanel.MouseLeave, themeIcon.MouseLeave, themeLabel.MouseLeave
        themePanel.BackColor = Color.FromArgb(245, 245, 245)
    End Sub
    Private Sub AccountSetting_Hover(sender As Object, e As EventArgs) Handles accountSettingPanel.MouseHover, settingIcon.MouseHover, accountSettingLabel.MouseHover
        accountSettingPanel.BackColor = theme
    End Sub
    Private Sub AccountSetting_Leave(sender As Object, e As EventArgs) Handles accountSettingPanel.MouseLeave, settingIcon.MouseLeave, accountSettingLabel.MouseLeave
        accountSettingPanel.BackColor = Color.FromArgb(245, 245, 245)
    End Sub
    Private Sub ComposePanel_Hover(sender As Object, e As EventArgs) Handles composePanel.MouseHover, composeIcon.MouseHover, composeLabel.MouseHover
        composePanel.BackColor = theme
    End Sub
    Private Sub ComposePanel_Leave(sender As Object, e As EventArgs) Handles composePanel.MouseLeave, composeIcon.MouseLeave, composeLabel.MouseLeave
        composePanel.BackColor = Color.FromArgb(245, 245, 245)
    End Sub


    Private Sub InboxItem_Hover(sender As Object, e As EventArgs)
        Dim id As String
        If TypeOf sender Is Panel Then
            Dim src As Panel = DirectCast(sender, Panel)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        Else
            Dim src As Label = DirectCast(sender, Label)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        End If
        Dim tagPanel As Panel = Me.Controls.Find("tagPanel" + id, True)(0)
        tagPanel.BackColor = theme
    End Sub
    Private Sub InboxItem_Leave(sender As Object, e As EventArgs)
        Dim id As String
        If TypeOf sender Is Panel Then
            Dim src As Panel = DirectCast(sender, Panel)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        Else
            Dim src As Label = DirectCast(sender, Label)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        End If
        Dim tagPanel As Panel = Me.Controls.Find("tagPanel" + id, True)(0)
        tagPanel.BackColor = colorList(emailList.IndexOf(id) Mod 8)
    End Sub
    Private Sub InboxItem_Click(sender As Object, e As EventArgs)
        Dim id As String
        If TypeOf sender Is Panel Then
            Dim src As Panel = DirectCast(sender, Panel)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        Else
            Dim src As Label = DirectCast(sender, Label)
            id = Integer.Parse(Regex.Replace(src.Name, "[^\d]", ""))
        End If
        MailsTableAdapter.updateEmailStatus(id)
        Dim info As New emailInfoForm(id)
        info.Show()
        RefreshInbox()
    End Sub
End Class