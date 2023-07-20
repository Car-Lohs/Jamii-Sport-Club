Public Class Add_Purchase

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Purchases.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Add_Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class