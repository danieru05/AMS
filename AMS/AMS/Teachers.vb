Imports System.Data.OleDb
Public Class Teachers
    Public TheName As String
    Sub LoadTeacher()
        Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
    End Sub
    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacher()
    End Sub
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher where 
        [Teacher ID] like '" & Search.Text & "%' or [Last Name] like '" & Search.Text & "%' or 
        [First Name] like '" & Search.Text & "%' or [Middle Name] like '" & Search.Text & "%' or
        [Department] like '" & Search.Text & "%' or [Subject Name] like '" & Search.Text & "%'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Search.ForeColor = Color.Black
        Search.Text = ""
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        opt += 1
        Teacher_ADD.Show()
    End Sub

    'Private Sub Teachers_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teachers_DataGrid.CellClick
    '    Dim row As DataGridViewRow = Teachers_DataGrid.Rows(e.RowIndex)
    '    TheName = row.Cells(1).Value.ToString()
    'End Sub

    Private Sub Teachers_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teachers_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Teachers_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
        Edit_Teacher.Show()
    End Sub
End Class