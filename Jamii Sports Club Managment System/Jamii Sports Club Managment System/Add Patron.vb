Public Class Add_Patron

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Patrons.Show()
        Me.Close()
    End Sub

    Private Sub Add_Patron_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class