Public Class FormLogIn

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblusername.Click

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Formhome.Show()
        Me.Close()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Me.Close()
    End Sub

    Private Sub FormLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class