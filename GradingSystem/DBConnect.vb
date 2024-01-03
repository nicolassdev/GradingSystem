Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Module DBConnect
    Public newrecord As Boolean
    Public cmd As New MySqlCommand
    Public MyAdapter As New MySqlDataAdapter
    Public dt As New DataTable
    Public num As Integer
    Public MyCommand As New MySqlCommand
    Public MyCon As MySqlConnection = New MySqlConnection("server=localhost;database=gradingsystemdb;uid=root;password=Nicolas051002;")

    Public Sub ExecButton(ByVal query)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyAdapter.SelectCommand = MyCommand
            Dim MyData As MySqlDataReader = MyCommand.ExecuteReader
            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function getmaxStudID()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(S_NUM),0)AS MAX_NUM FROM student"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyCon.Close()
        getmaxStudID = num '3
    End Function

    'GET TEACHER MAX ID
    Public Function getmaxTeacherID()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(T_NUM),0)AS MAX_NUM FROM teacher"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MyCon.Close()
        getmaxTeacherID = num '3
    End Function
    'GET MAX SUBJECT ID
    Public Function getmaxSubID()
        Try

            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT COALESCE(MAX(SUB_NUM),0)AS MAX_NUM FROM subjects"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            MySQLData.Read()
            num = MySQLData("MAX_NUM") '3


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        MyCon.Close()
        getmaxSubID = num '3
    End Function
    'INSERT AND UPDATE BUTTON
    Public Sub ExecInsertButton(ByVal query As String)
        Try
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = query
            MyCommand.ExecuteNonQuery()
            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
