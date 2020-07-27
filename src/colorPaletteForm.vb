Public Class colorPaletteForm
    Dim dragFlag As Boolean
    Dim pointClicked As Point

    Private Sub colorPaletteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlePanel.BackColor = dashboardForm.theme
        Me.BackColor = dashboardForm.theme
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
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backIcon.Click
        Me.Close()
    End Sub
    Private Sub RedPalette_Click(sender As Object, e As EventArgs) Handles redPalette.Click, emeraldPalette.Click, pinkPalette.Click, greyPalette.Click, creamPalette.Click, lightBluePalette.Click
        dashboardForm.theme = sender.BackColor
        titlePanel.BackColor = dashboardForm.theme
        dashboardForm.RefreshDashboard()
    End Sub
End Class