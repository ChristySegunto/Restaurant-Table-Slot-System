Imports System.Data.OleDb ' piniling format or details kay database

' To open a connection from database
Module Connection
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\chris\Downloads\TSS.mdb"

    Public conn As OleDbConnection = New OleDbConnection(connStr)


    Function ExecuteQuery(ByVal Query As String) As DataTable
        ' for add, delete, update ng database
        ' ieexecute niya yung nasa baba

        Dim sqlDT As New DataTable ' nag declare ng data table
        Dim sqlCon As New OleDbConnection(connStr)
        Dim sqlDA As New OleDbDataAdapter(Query, sqlCon)
        Dim sqlCB As New OleDbCommandBuilder(sqlDA)

        sqlDA.Fill(sqlDT)
        Return sqlDT

    End Function
End Module

