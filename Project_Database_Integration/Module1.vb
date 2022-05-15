Imports MySql.Data.MySqlClient


Module Module1
    Public Function openCon() As MySqlConnection
        Return New MySqlConnection("server = localhost ; user id = root; password = ; database = finals_db")
    End Function

    Public con As MySqlConnection = openCon()   'connection to the database
    Public result As String
    Public cmd As New MySqlCommand              'method that enables to perform the sql commands/query
    Public adapter As New MySqlDataAdapter      'fetching of data when SELECT QUERY is used
    Public table As New DataTable               'used to show data in data grid view

    'functions of NEW button
    Public Sub newData(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("SAVING FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'functions of UPDATE button
    Public Sub updates(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("UPDATE FAILED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'functions of DELETE button
    Public Sub delete(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO DELETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DELETED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'functions of LOAD TABLE button
    Public Sub loadtable(ByVal sql As String, ByVal DTG As Object)
        Try
            table = New DataTable
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(table)
            DTG.datasource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            adapter.Dispose()
        End Try
    End Sub
End Module
