Imports System.Data.OleDb

Public Class Log_In
    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\macca\Documents\Jamii-Sport-Club\Jamii Sports Club Managment System\Jamii Sports Club Managment System\Jamii Sports Club.mdb"

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Create a new OleDbConnection object
        Using connection As New OleDbConnection(connectionString)
            Try
                ' Open the connection
                connection.Open()

                ' Create a query to select the user from the LogIn table
                Dim query As String = "SELECT * FROM LogIn WHERE Username = @Username AND Password = @Password"

                ' Create a new OleDbCommand object with the query and connection
                Using command As New OleDbCommand(query, connection)
                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@Username", txtUsername.Text)
                    command.Parameters.AddWithValue("@Password", txtPassword.Text)

                    ' Execute the command and retrieve the result
                    Dim reader As OleDbDataReader = command.ExecuteReader()

                    ' Check if the user exists
                    If reader.Read() Then
                        ' User exists, perform the login action
                        txtPassword.Text = ""
                        txtUsername.Text = ""
                        MessageBox.Show("Login successful!")
                        Dashboard.Show()
                        Me.Hide()
                        ' Add your code here to navigate to the next form or perform other actions after successful login
                    Else
                        ' User does not exist or credentials are incorrect
                        MessageBox.Show("Invalid username or password.")
                    End If

                    ' Close the data reader
                    reader.Close()
                End Using
            Catch ex As Exception
                ' Handle any errors that may occur during the database connection or query execution
                MessageBox.Show("An error occurred: " + ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
