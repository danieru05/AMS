Imports System.Data.OleDb
Public Class Section_Attendance
    Private Sub Section_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stat As New OleDbCommand("Select [Attendance] from Attendance", conn)
        Dim dr As OleDbDataReader

        dr = stat.ExecuteReader
        While dr.Read
            Attendance.Items.Add(dr("Attendance"))
        End While

        Dim cmd As New OleDbCommand("Select * from Student where [Section] ='" & Section_Teacher.Search.Text & "'", conn)
        Dim cr As OleDbDataReader = cmd.ExecuteReader
        While cr.Read()
            Students_DataGrid.Rows.Add(cr.Item("Student ID"), cr.Item("Last Name"), cr.Item("First Name"),
            cr.Item("Middle Name"))
        End While


    End Sub
End Class