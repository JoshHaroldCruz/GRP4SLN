Imports System.Data.SQLite

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateUsersTable()

        ' Insert data into the "users" table
        InsertUser("john_doe", "password123", "2024-04-24", "12:00 PM")
    End Sub

    Private Function GetSQLiteConnection() As SQLiteConnection
        Dim connectionString As String = "Data Source=users.db;Version=3;"
        Return New SQLiteConnection(connectionString)
    End Function

    Private Sub CreateUsersTable()
        Dim sql As String = "CREATE TABLE IF NOT EXISTS users (username TEXT, password TEXT, date TEXT, time TEXT);"
        Using connection As SQLiteConnection = GetSQLiteConnection()
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub InsertUser(username As String, password As String, [date] As String, time As String)
        Dim sql As String = "INSERT INTO users (username, password, date, time) VALUES (@username, @password, @date, @time);"
        Using connection As SQLiteConnection = GetSQLiteConnection()
            connection.Open()
            Using command As New SQLiteCommand(sql, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@date", [date])
                command.Parameters.AddWithValue("@time", time)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
