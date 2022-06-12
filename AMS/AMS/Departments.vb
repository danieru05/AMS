Imports System.Data.OleDb
Public Class Departments
    Dim Title As String
    Sub LoadDepartment()
        Department_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Department", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Department_DataGrid.Rows.Add(dr.Item("Department"))
        End While
        Department_DataGrid.Sort(Department_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub LoadNormalDepartment()
        Search.Text = ""
        Cancel_Button.Visible = False
        Add_Button.Text = "Add"
        Delete_Button.Text = "Delete"
        Update_Button.Text = "Update"
        Add_Button.Enabled = True
        Delete_Button.Enabled = True
        Update_Button.Enabled = True
        Add_Button.BackColor = Color.SteelBlue
        Delete_Button.BackColor = Color.SteelBlue
        Update_Button.BackColor = Color.SteelBlue
        LoadDepartment()
    End Sub
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartment()
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Search.ForeColor = Color.Black
        Search.Text = ""
    End Sub
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Add_Button.Text = "Add" And Update_Button.Text = "Update" Then
            Department_DataGrid.Rows.Clear()
            Dim cmd As New OleDbCommand("Select Department from Department where Department like '%" & Search.Text & "%'", conn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Department_DataGrid.Rows.Add(dr.Item("Department"))
            End While
        End If
    End Sub
    Private Sub Department_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Department_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Department_DataGrid.Rows(e.RowIndex)
        Title = row.Cells(0).Value.ToString()
        Department___Teachers.Title.Text = Title
        Department___Teachers.Text = "Department of " + Title
        Department___Teachers.Show()
    End Sub
    Private Sub Department_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Department_DataGrid.CellClick
        Dim row As DataGridViewRow = Department_DataGrid.Rows(e.RowIndex)
        Title = row.Cells(0).Value.ToString()
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        If Add_Button.Text = "Add" Then
            Add_Button.Text = "ADD"
            Delete_Button.Enabled = False
            Delete_Button.BackColor = Color.Transparent
            Update_Button.Enabled = False
            Update_Button.BackColor = Color.Transparent
            Cancel_Button.Visible = True
            Search.ForeColor = Color.Gray
            Search.Text = "Type Here to Add Department"
            LoadDepartment()
        Else
            Dim cmd As New OleDbCommand("Insert into Department(Department) values('" & Search.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Added Successfully")
            LoadNormalDepartment()
        End If
    End Sub
    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If Delete_Button.Text = "Delete" Then
            Delete_Button.Text = "DELETE"
            Add_Button.Enabled = False
            Add_Button.BackColor = Color.Transparent
            Update_Button.Enabled = False
            Update_Button.BackColor = Color.Transparent
            Cancel_Button.Visible = True
        Else
            If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Delete from Department where [Department] ='" & Title & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted Successfully")
                LoadNormalDepartment()
            End If
        End If
    End Sub
    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        If Update_Button.Text = "Update" Then
            Update_Button.Text = "UPDATE"
            Add_Button.Enabled = False
            Add_Button.BackColor = Color.Transparent
            Delete_Button.Enabled = False
            Delete_Button.BackColor = Color.Transparent
            Cancel_Button.Visible = True
            Search.ForeColor = Color.Gray
            Search.Text = "Type Here to Update Department"
            LoadDepartment()
        Else
            If MsgBox("Do you want to update this?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Update Department set [Department] ='" & Search.Text & "' where [Department] ='" & Title & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Updated Successfully")
                LoadNormalDepartment()
            End If
        End If
    End Sub
    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        LoadNormalDepartment()
    End Sub
End Class