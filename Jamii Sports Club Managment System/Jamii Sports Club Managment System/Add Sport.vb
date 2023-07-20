Public Class Add_Sport

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Sports.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Add_Sport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class