Public Class forgotPasswordForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point


    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles exitIcon.Click
        Application.Exit()
    End Sub
    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimizeIcon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backIcon.Click
        Me.Close()
        loginForm.Show()
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

    Private Sub ForgotButton_Click(sender As Object, e As EventArgs) Handles forgotButton.Click
        If AccountsTableAdapter.verifyEmail(emailTB.Text) Then
            Dim pass As String = AccountsTableAdapter.getPassword(emailTB.Text)
            MessageBox.Show("Your password : " + pass, "Information")
            Me.Close()
            loginForm.Show()
            Return
        End If
        If String.IsNullOrWhiteSpace(emailTB.Text) Then
            MessageBox.Show("Please fill email field!", "Error")
            Return
        Else
            MessageBox.Show("Email not registered!", "Error")
            Return
        End If
    End Sub
End Class