Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports MySql.Data.MySqlClient

Class ConfigMySql
    Public Shared port As String = ";port=3306"
    Public Shared time As String = ";pooling = false; convert zero datetime=True"
    Public Shared MyConn As String '= "Data Source=localhost; User Id=root;Password=;database=test;charset=utf8" & port & time
    Private Shared connection As New MySqlConnection

    Public Shared Function SetConnect(ByVal Host As String, ByVal User_ID As String, ByVal Password As String, ByVal database As String, Optional Ports As String = "3306") As String
        MyConn = ""
        If Host <> "" Then
            MyConn &= "Data Source=" & Host & ";"
        Else
            MyConn &= "Data Source=localhost;"
        End If
        If User_ID <> "" Then
            MyConn &= "User Id=" & User_ID & ";"
        Else
            MyConn &= "User Id=root;"
        End If
        If Password <> "" Then
            MyConn &= "Password=" & Password & ";"
        Else
            MyConn &= "Password=;"
        End If
        If database <> "" Then
            MyConn &= "database=" & database & ";"
        Else
            MyConn &= "database=test;"
        End If

        If Ports <> "" Then
            MyConn &= "port=" & Ports & ";"
        Else
            MyConn &= "port=3306;"
        End If

        If Test_connect(MyConn) = True Then
            Return MyConn
        Else
            Return MyConn
        End If
    End Function
    Private Shared Sub CREATE_DATABASE(ByRef Conn As String, ByRef DATABASE_ST As String)
        Dim connection As MySqlConnection = New MySqlConnection(Conn)
        Dim command As MySqlCommand = New MySqlCommand("CREATE DATABASE  IF NOT EXISTS '" & DATABASE_ST & "';", connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Public Shared Function Test_connect(conns As String) As Boolean
        Try
            connection = New MySqlConnection(conns)
            connection.Open()
            connection.Close()
            Return True
        Catch ex As MySqlException
            Return False
        End Try
    End Function

    Public Shared Function OpenConnect(conns As String) As Boolean
        Try
            connection = New MySqlConnection(conns)
            connection.Open()
            connection.Close()
            Return True
        Catch ex As MySqlException
            Return False
        End Try
    End Function

    Public Shared Function SelectData(ByRef Conn As String, ByVal sql As String) As DataTable
        Dim con As MySqlConnection = New MySqlConnection()
        con.ConnectionString = (Conn)
        Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
        con.Open()
        Dim tb As System.Data.DataTable = New System.Data.DataTable()
        tb.Load(cmd.ExecuteReader())
        con.Close()
        Return tb
    End Function
    Public Shared Function deleteData(ByRef Conn As String, ByVal sql As String) As Boolean
        Try
            Dim con As MySqlConnection = New MySqlConnection()
            con.ConnectionString = (Conn)
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function insertData(ByRef Conn As String, ByVal sql As String) As Boolean
        Try
            Dim con As MySqlConnection = New MySqlConnection()
            con.ConnectionString = (Conn)
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As MySqlException
            Return False
        End Try
    End Function
    Public Shared Function updateData(ByRef Conn As String, ByVal sql As String) As Boolean
        Try
            Dim con As MySqlConnection = New MySqlConnection()
            con.ConnectionString = (Conn)
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function GetMytosetX(ByRef Conn As String, ByVal sqlx As String, ByVal tablename As String) As DataSet
        Dim daCountry As MySqlDataAdapter
        Dim dsCountry As DataSet
        Try
            dsCountry = New DataSet
            Dim con As MySqlConnection = New MySqlConnection(Conn)
            daCountry = New MySqlDataAdapter(sqlx, con)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(daCountry)
            dsCountry = New DataSet()
            con.Clone()
            daCountry.Fill(dsCountry, tablename)
            Return dsCountry
        Catch ex As Exception
            dsCountry = New DataSet
            Return dsCountry
        End Try

    End Function

    Public Shared Function truncatetable(ByRef Conn As String, ByVal sql As String) As Boolean
        Try
            Dim con As MySqlConnection = New MySqlConnection()
            con.ConnectionString = (Conn)
            Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function CountData(ByRef Conn As String, ByVal query As String) As Integer
        Dim CountS As Integer = 0
        Dim con As MySqlConnection = New MySqlConnection()
        con.ConnectionString = (Conn)
        Dim cmd As MySqlCommand = New MySqlCommand(query, con)
        con.Open()
        Dim tb As System.Data.DataTable = New System.Data.DataTable()
        tb.Load(cmd.ExecuteReader())
        con.Close()
        CountS = tb.Rows.Count()
        Return CountS
    End Function
    Public Shared OutputStream As System.IO.StreamWriter
    Public Shared Sub CreateBackup()
        Try
            Dim mysqldumpPath1, Database As String
            Dim mysqldumpPath As String = mysqldumpPath1 & "\mysqldump.exe"
            Dim host As String = "localhost"
            Dim user As String = "root"
            Dim pswd As String = "-p {2}"
            Dim dbnm As String = Database
            Dim cmd As String = String.Format("-h {0} -u {1}  {2} -r ", host, user, dbnm)
            Dim SaveDirectory As String = Application.StartupPath() & "\backup\"

            Try
                If Not Directory.Exists(SaveDirectory) Then
                    Directory.CreateDirectory(SaveDirectory)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'WAMP Server
            'Process.Start("C:\wamp64\bin\mysql\mysql5.7.14\bin\mysqldump.exe", "-u root skripsi -r """ & BackupPath & "" & DatabaseName & ".sql""") 
            'XAMPP SERVER
            Process.Start(mysqldumpPath, cmd & " """ & SaveDirectory & "" & dbnm & ".sql""")
            'MySQL 8.0 Above
            'Process.Start("C:\wamp64\bin\mysql\mysql8.0.21\bin\mysqldump.exe", "--replace --column-statistics=0 -u root -proot --databases audioelektronik -r """ & BackupPath & "" & DatabaseName & ".sql""")
            MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub OnDataReceived1(ByVal Sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            Dim text As String = e.Data
            Dim bytes As Byte() = Encoding.Default.GetBytes(text)
            text = Encoding.UTF8.GetString(bytes)
            OutputStream.WriteLine(text)
        End If
    End Sub
End Class
