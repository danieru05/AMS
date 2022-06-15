Imports System.Data.OleDb
Public Class Student_Teacher
    Public TheName, naku As String
    Private Sub Student_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Students_DataGrid.Rows.Clear()
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            Students_DataGrid.Rows.Add(myreader2.Item("Student ID"), myreader2.Item("Student Name"), myreader2.Item("Attendance"))
        End While
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Students_DataGrid.Rows.Clear()
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            Students_DataGrid.Rows.Add(myreader2.Item("Student ID"), myreader2.Item("Student Name"), myreader2.Item("Attendance"))
        End While
    End Sub

    Private Sub Students_DataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Students_DataGrid.CellFormatting
        If e.ColumnIndex = 2 And e.Value IsNot Nothing Then
            e.CellStyle.ForeColor = Color.White
            If e.Value.ToString = "Present" Then
                e.CellStyle.BackColor = Color.LimeGreen
            ElseIf e.Value.ToString = "Absent" Then
                e.CellStyle.BackColor = Color.Tomato
            ElseIf e.Value.ToString = "Late" Then
                e.CellStyle.BackColor = Color.Goldenrod
            ElseIf e.Value.ToString = "Excuse" Then
                e.CellStyle.BackColor = Color.DodgerBlue
            Else
                e.CellStyle.BackColor = Color.White
            End If
        End If
    End Sub
End Class