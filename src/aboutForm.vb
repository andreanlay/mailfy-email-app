Public Class aboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = dashboardForm.theme
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles exitIcon.Click
        Me.Close()
    End Sub
End Class