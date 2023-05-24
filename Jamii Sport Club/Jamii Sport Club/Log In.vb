Imports System.Data.OleDb
Imports System.Data

Public Class FormLogIn
    Dim connection As New OleDbConnection(My.Settings.dataConnectionString)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lblusername.Click

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MsgBox("Enter Your Cridentials", MsgBoxStyle.Exclamation)
        Else

        End If
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Me.Close()
    End Sub
End Class