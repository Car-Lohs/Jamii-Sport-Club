Public Class Add_Sport

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Sports.Show()
        Me.Close()
    End Sub
End Class