Public Class Log_In
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Me.Close()
        splashScreen.Timer1.Start()
    End Sub

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class