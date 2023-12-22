Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'CCQC
        ' create a connection string
        Dim connectionString As String = "Server=localhost;Database=AliceSmith;User Id=sa;Password=p@ssw0rd"
        ' create an sql connection
        Dim sqlConnection As SqlConnection = New SqlConnection(connectionString)
        ' create query itself
        Dim sqlQuery As String = "SELECT * FROM login WHERE username=@nama AND password=@katalaluan"
        ' create sql command 
        Dim sqlCommand As New SqlCommand(sqlQuery, sqlConnection)

        sqlCommand.Parameters.AddWithValue("@nama", txtUsername.Text)
        sqlCommand.Parameters.AddWithValue("@katalaluan", txtPassword.Text)

        sqlConnection.Open()
        Dim sqlDataReaderObj As SqlDataReader = sqlCommand.ExecuteReader()

        If sqlDataReaderObj.HasRows Then
            Me.Hide()
            frmAdmin.Show()
        Else
            MsgBox("Unauthorized User")
        End If
        sqlConnection.Close()
    End Sub
End Class