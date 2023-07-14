Public Class splashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 5
        If RectangleShape2.Width >= 370 Then
            Log_In.Show()
            Me.Close()
        End If
       
    End Sub
End Class
