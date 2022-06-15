Imports System.Data.OleDb
Public Class Students
    Public TheName, naku As String
    Sub LoadStudent()
        Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"),
            dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
    End Sub
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudent()
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student where 
        [Student ID] like '" & Search.Text & "%' or [Last Name] like '" & Search.Text & "%' or 
        [First Name] like '" & Search.Text & "%' or [Middle Name] like '" & Search.Text & "%' or
        Status like '" & Search.Text & "%' or [Section] like '" & Search.Text & "%'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        opt += 1
        Student_Add.Show()
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As New OleDbCommand("Delete from Student where [Last Name] ='" & TheName & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            LoadStudent()
        End If
    End Sub

    Private Sub Students_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_DataGrid.CellClick
        Dim row As DataGridViewRow = Students_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
    End Sub

    Private Sub Students_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Students_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Students_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
        Form1.Show()
    End Sub
End Class