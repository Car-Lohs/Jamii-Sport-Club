Public Class Formhome

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        FormLogIn.Show()
        Me.Close()

    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles Lblpatronscommission.Click

    End Sub

    Private Sub Formhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles Btnmanagemebers.Click


    End Sub

    Private Sub Lbltextlogo_Click(sender As Object, e As EventArgs) Handles Lbltextlogo.Click

    End Sub

    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub GunaLabel10_Click(sender As Object, e As EventArgs) Handles GunaLabel10.Click
        ' Set the current date and time to the Label or TextBox control
        GunaLabel10.Text = DateTime.Now.ToString()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label1.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        Formaddgame.Show()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles Btnstoremanagment.Click

    End Sub

    Private Sub GunaGroupBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        Formaddmember.Show()
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        Formadditem.Show()
    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        Formaddpatron.Show()
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        Formaddevent.Show()
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Formaddpurchase.Show()
    End Sub
End Class