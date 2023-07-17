Public Class Log_In
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        splashScreen.Timer1.Start()
    End Sub

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub GunaElipsePanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaElipsePanel1.Paint

    End Sub
End Class