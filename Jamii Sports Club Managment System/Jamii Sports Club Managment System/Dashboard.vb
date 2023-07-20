Public Class Dashboard

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Members.ShowDialog()
    End Sub

    Private Sub btnSports_Click(sender As Object, e As EventArgs) Handles btnSports.Click
        Sports.ShowDialog()
    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs) Handles btnStore.Click
        Store.ShowDialog()
    End Sub

    Private Sub btnPurchases_Click(sender As Object, e As EventArgs) Handles btnPurchases.Click
        Purchases.ShowDialog()
    End Sub

    Private Sub btnFscilitation_Click(sender As Object, e As EventArgs) Handles btnFacilitation.Click
        Facilitation.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnPatrons_Click(sender As Object, e As EventArgs) Handles btnPatrons.Click
        Patrons.ShowDialog()
    End Sub

    Private Sub btnSurcharges_Click(sender As Object, e As EventArgs) Handles btnSurcharges.Click
        Surcharges.ShowDialog()
    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        SportEvents.ShowDialog()
    End Sub

    Private Sub btnAddmember_Click(sender As Object, e As EventArgs) Handles btnAddmember.Click
        Add_Member.ShowDialog()
    End Sub

    Private Sub btnAddsport_Click(sender As Object, e As EventArgs) Handles btnAddsport.Click
        Add_Sport.ShowDialog()
    End Sub

    Private Sub btnAddevent_Click(sender As Object, e As EventArgs) Handles btnAddevent.Click
        Add_Events.ShowDialog()
    End Sub

    Private Sub btnAddpatron_Click(sender As Object, e As EventArgs) Handles btnAddpatron.Click
        Add_Patron.ShowDialog()
    End Sub

    Private Sub btnAddpurchase_Click(sender As Object, e As EventArgs) Handles btnAddpurchase.Click
        Add_Purchase.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Log_In.Show()
        Me.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CloseAllForms()
        ' Iterate through the open forms and close them
        For Each form As Form In Application.OpenForms
            form.Close()
        Next
    End Sub
End Class