Public Class Formsplash

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblwelcome.Click

    End Sub

    Private Sub Formsplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 5
        If RectangleShape2.Width >= 220 Then
            FormLogIn.Show()
            Me.Close()

        End If

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

    End Sub
End Class
