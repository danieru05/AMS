Imports System.Data.OleDb
Public Class Section___Students
    Public TheName As String
    Sub LoadSection()
        Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student where [Section] ='" & Title.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"),
            dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
    End Sub
    Private Sub Section___Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSection()
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Student_Add.Show()
    End Sub

    Private Sub Section___Students_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Student_Add.Close()
    End Sub

    Private Sub Students_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Students_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
        Form1.Show()
    End Sub
End Class