Imports System.Data.OleDb
Public Class Department___Teachers
    Dim TheName As String
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
        Teacher_ADD.Hide()
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As New OleDbCommand("Delete from Teacher where [last Name] ='" & TheName & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            LoadTeacher()
        End If
    End Sub

    Private Sub Teachers_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teachers_DataGrid.CellClick
        Dim row As DataGridViewRow = Teachers_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(1).Value.ToString()
    End Sub
End Class