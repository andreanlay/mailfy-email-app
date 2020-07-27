Public Class emailInfoForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point

    Private emailID As Integer

    Public Sub New(emailID As Integer)
        InitializeComponent()
        Me.emailID = emailID
    End Sub

    Private Sub emailInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim senderID As Integer
        senderID = MailsTableAdapter.getSenderByID(emailID)
        senderTB.Text = String.Format("{0} <{1}>", AccountsTableAdapter.getNameByID(senderID), AccountsTableAdapter.getEmail(senderID))
        subjectTB.Text = MailsTableAdapter.getEmailSubject(emailID)
        emailBodyTB.Text = MailsTableAdapter.getEmailBody(emailID)
        titlePanel.BackColor = dashboardForm.theme
        forwardButton.BackColor = dashboardForm.theme
        replyButton.BackColor = dashboardForm.theme
    End Sub

    Private Sub RemoveChooserHighlight(sender As Object, e As EventArgs)
        senderLabel.Focus()
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles forwardButton.Click
        Dim forward As New composeEmailForm(MailsTableAdapter.getRecipientByID(emailID))
        forward.subjectTB.Text = "FWD : " + MailsTableAdapter.getEmailSubject(emailID)
        Dim header As String = "----Forwarded Message----" + vbNewLine
        Dim from As String = AccountsTableAdapter.getEmail(MailsTableAdapter.getSenderByID(emailID)) + vbNewLine
        forward.emailBodyTB.Text = header + from + MailsTableAdapter.getEmailBody(emailID)
        forward.Show()
    End Sub
    Private Sub ReplyButton_Click(sender As Object, e As EventArgs) Handles replyButton.Click
        Dim reply As New composeEmailForm(MailsTableAdapter.getSenderByID(emailID), MailsTableAdapter.getRecipientByID(emailID))
        reply.Show()
    End Sub



    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimizeIcon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backIcon.Click
        Me.Close()
    End Sub
    Private Sub TitleBar_Down(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles titleLabel.MouseDown
        If e.Button = MouseButtons.Left Then
            dragFlag = True
            pointClicked = New Point(e.X, e.Y)
        Else
            dragFlag = False
        End If
    End Sub
    Private Sub TitleBar_Move(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles titleLabel.MouseMove
        If dragFlag Then
            Dim newPoint As Point
            newPoint = Me.PointToScreen(New Point(e.X, e.Y))
            newPoint.Offset(-pointClicked.X, -pointClicked.Y - (Me.Height - Me.DisplayRectangle.Height))
            Me.Location = newPoint
        End If
    End Sub
    Private Sub TitleBar_Up(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles titleLabel.MouseUp
        dragFlag = False
    End Sub
End Class