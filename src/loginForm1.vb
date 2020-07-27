Public Class loginForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If AccountsTableAdapter.verifyLogin(emailTB.Text, passTB.Text) Then
            MessageBox.Show("Sign in success!", "Information")
            Me.Hide()
            dashboardForm.Show()
            emailTB.Text = ""
            passTB.Text = ""
        Else
            MessageBox.Show("Failed to sign in, please check your email/password", "Information")
        End If
    End Sub


    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles exitIcon.Click
        Application.Exit()
    End Sub
    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles minimizeIcon.Click
        Me.WindowState = FormWindowState.Minimized
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


    Private Sub New_AccountHover(sender As Object, e As EventArgs) Handles createAccLabel.MouseHover
        createAccLabel.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub New_AccountLeave(sender As Object, e As EventArgs) Handles createAccLabel.MouseLeave
        createAccLabel.ForeColor = Color.FromArgb(0, 102, 204)
    End Sub
    Private Sub New_Account(sender As Object, e As EventArgs) Handles createAccLabel.Click
        Me.Hide()
        registerForm.Show()
    End Sub


    Private Sub Forgot_PasswordHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub Forgot_PasswordLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.FromArgb(0, 102, 204)
    End Sub
    Private Sub Forgot_Password(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        forgotPasswordForm.Show()
    End Sub
End Class