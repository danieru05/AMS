Imports System.Data.OleDb
Public Class Section___Students
    Dim TheName As String
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
        Student_Add.Hide()
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As New OleDbCommand("Delete from Student where [Last Name] ='" & TheName & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            LoadSection()
        End If
    End Sub

    Private Sub Students_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_DataGrid.CellClick
        Dim row As DataGridViewRow = Students_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
    End Sub
End Class