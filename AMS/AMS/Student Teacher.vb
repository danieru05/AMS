Imports System.Data.OleDb
Public Class Student_Teacher
    Public TheName, naku As String
    Sub Attend()
        Students_DataGrid.Rows.Clear()
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            Students_DataGrid.Rows.Add(myreader2.Item("Student ID"), myreader2.Item("Student Name"), myreader2.Item("Section"), myreader2.Item("Attendance"))
        End While
    End Sub
    Private Sub Student_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Attend()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Attend()
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Students_DataGrid.Rows.Clear()
        Dim write As New OleDbCommand("SELECT * FROM AMS where ([Petsa] ='" & DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "')
        and ([Student ID]  like '" & Search.Text & "%' or [Student Name] like '%" & Search.Text & "%'
        or [Section] ='" & Search.Text & "%')", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            Students_DataGrid.Rows.Add(myreader2.Item("Student ID"), myreader2.Item("Student Name"), myreader2.Item("Section"), myreader2.Item("Attendance"))
        End While
        If Search.Text = "" Then
            Attend()
        End If
    End Sub

    Private Sub Students_DataGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Students_DataGrid.CellFormatting
        If e.ColumnIndex = 3 And e.Value IsNot Nothing Then
            e.CellStyle.ForeColor = Color.White
            If e.Value.ToString = "Present" Then
                e.CellStyle.BackColor = Color.LimeGreen
            ElseIf e.Value.ToString = "Absent" Then
                e.CellStyle.BackColor = Color.Tomato
            ElseIf e.Value.ToString = "Late" Then
                e.CellStyle.BackColor = Color.Goldenrod
            ElseIf e.Value.ToString = "Excuse" Then
                e.CellStyle.BackColor = Color.MediumOrchid
            Else
                e.CellStyle.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub Students_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Students_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
        Edit_Attendance.Show()
    End Sub
End Class