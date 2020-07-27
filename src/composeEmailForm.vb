Public Class composeEmailForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point

    Private senderID As Integer
    Private recipientID As Integer = -1

    Public Sub New(senderID As Integer)
        InitializeComponent()
        Me.senderID = senderID
    End Sub
    Public Sub New(senderID As Integer, recipientID As Integer)
        InitializeComponent()
        recipientCB.Enabled = False
        Me.senderID = recipientID
        Me.recipientID = senderID


    End Sub

    Private Sub composeEmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccountsTableAdapter.Fill(Me.EmailDataSet.accounts)

        recipientCB.SelectedIndex = recipientCB.FindStringExact(AccountsTableAdapter.getEmail(recipientID))

        titlePanel.BackColor = dashboardForm.theme
        sendButton.BackColor = dashboardForm.theme
    End Sub

    Private Sub RemoveChooserHighlight(sender As Object, e As EventArgs) Handles recipientCB.SelectedIndexChanged
        recipientLabel.Focus()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        MailsTableAdapter.newEmail(senderID, recipientCB.SelectedValue, subjectTB.Text, emailBodyTB.Text, "Sent", DateTime.Now.ToString("yyyy/MM/dd HH:mm"))
        MessageBox.Show("Mail sent!", "Information")
        dashboardForm.RefreshInbox()
        Me.Close()
    End Sub


    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimizeIcon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backIcon.Click
        Me.Close()
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
End Class