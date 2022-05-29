Imports System.Data.OleDb
Module Module1
    Public conn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\AMS.accdb")
    Public Username As String

    Function Connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
