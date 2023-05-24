Public Class Formhome

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        FormLogIn.Show()
        Me.Close()

    End Sub

    Private Sub Formhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub


    Private Sub GunaLabel10_Click(sender As Object, e As EventArgs) Handles GunaLabel10.Click
        ' Set the current date and time to the Label or TextBox control
        GunaLabel10.Text = DateTime.Now.ToString()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub
    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        Formaddmember.Show()
    End Sub
End Class