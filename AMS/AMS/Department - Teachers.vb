Imports System.Data.OleDb
Public Class Department___Teachers
    Public TheName As String
    Sub LoadTeacher()
        Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher where Department = '" & Title.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
    End Sub
    Private Sub Department___Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTeacher()
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Teacher_ADD.Show()
    End Sub
    Private Sub Department___Teachers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Teacher_ADD.Close()
    End Sub
    Private Sub Teachers_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teachers_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Teachers_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
        Edit_Teacher.Show()
    End Sub
End Class