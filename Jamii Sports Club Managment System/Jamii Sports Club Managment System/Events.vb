Imports System.Data.OleDb
Imports System.IO

Public Class SportEvents
    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub txtEventid_TextChanged(sender As Object, e As EventArgs) Handles EventidTextbox.TextChanged

    End Sub

    Private Sub Event_IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SportEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jamii_Sports_ClubDataSet.Events' table. You can move, or remove it, as needed.
        Me.EventsTableAdapter.Fill(Me.Jamii_Sports_ClubDataSet.Events)

    End Sub
End Class