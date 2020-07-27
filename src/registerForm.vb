Public Class registerForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point


    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        If String.IsNullOrEmpty(firstNameTB.Text + lastNameTB.Text + emailTB.Text + passwordTB.Text + repeatPassTB.Text) Then
            MessageBox.Show("Please fill all fields!", "Error")
        ElseIf AccountsTableAdapter.verifyEmail(emailTB.Text) Then
            MessageBox.Show("Please select another email address!", "Error")
        ElseIf Not (passwordTB.Text).Equals(repeatPassTB.Text) Then
            MessageBox.Show("Password does not match!", "Error")
        Else
            AccountsTableAdapter.newAccount(firstNameTB.Text, lastNameTB.Text, emailTB.Text, passwordTB.Text)
            MessageBox.Show("Register Success!")
            Account_dataTableAdapter.newAccountInitialData()
            Me.Close()
            loginForm.Show()
        End If
    End Sub


    Private Sub checkPasswordStrength(sender As Object, e As EventArgs) Handles passwordTB.TextChanged
        If String.IsNullOrEmpty(passwordTB.Text) Then
            strengthLabel.Text = ""
            Return
        End If
        Dim upper As Integer
        Dim symbol As Integer
        Dim numbers As Integer
        Dim punct As Integer
        Dim other As Integer
        Dim score As Integer

        For i = 1 To passwordTB.Text.Length - 1
            If Char.IsUpper(passwordTB.Text(i)) Then
                upper += 1
            ElseIf Char.IsSymbol(passwordTB.Text(i)) Then
                symbol += 1
            ElseIf Char.IsNumber(passwordTB.Text(i)) Then
                numbers += 1
            ElseIf Char.IsPunctuation(passwordTB.Text(i)) Then
                punct += 1
            Else
                other += 1
            End If
        Next
        score = other + (1.5 * (numbers + upper)) + (2 * symbol) + (2.5 * punct)
        If score > 15 Then
            strengthLabel.ForeColor = Color.FromArgb(0, 255, 0)
            strengthLabel.Text = "Strong"
        ElseIf score > 7 Then
            strengthLabel.ForeColor = Color.FromArgb(175, 175, 0)
            strengthLabel.Text = "Medium"
        Else
            strengthLabel.ForeColor = Color.FromArgb(150, 0, 0)
            strengthLabel.Text = "Bad"
        End If
    End Sub


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
End Class