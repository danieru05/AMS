Imports System.Data.OleDb
Public Class Sections
    Dim Title As String
    Dim counter As Integer = 0
    Dim TheName As String
    Sub LoadSection()
        Section_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select [Course Name] from Course", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Section_DataGrid.Rows.Add(dr.Item("Course Name"))
        End While
        Section_DataGrid.Sort(Section_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub LoadAllSection()
        Section_DataGrid.Rows.Clear()
        counter = 0
        Dim cmd As New OleDbCommand("Select * from [Section] where Course ='" & Search.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Section_DataGrid.Rows.Add(dr.Item("Section"))
            counter += 1
        End While
    End Sub
    Sub LoadNormalSection()
        Add_Button.Text = "Add"
        Search.Text = ""
        Cancel_Button.Visible = False
        LoadSection()
    End Sub
    Private Sub Sections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSection()
        Back_Button.Visible = False
    End Sub
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Search.Enabled = True Then
            Section_DataGrid.Rows.Clear()
            Dim cmd As New OleDbCommand("Select [Course Name] from Course where [Course Name] like '" & Search.Text & "%'", conn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Section_DataGrid.Rows.Add(dr.Item("Course Name"))
            End While
        End If
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Search.ForeColor = Color.Black
        Search.Text = ""
    End Sub
    Private Sub Section_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Section_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Section_DataGrid.Rows(e.RowIndex)
        If Search.Enabled = True Then
            Title = row.Cells(0).Value.ToString()
            Search.Text = Title
            Search.Enabled = False
            Search.TextAlign = HorizontalAlignment.Center
            Back_Button.Visible = True
            Section_DataGrid.Rows.Clear()
            LoadAllSection()
        Else
            Section___Students.Title.Text = (row.Cells(0).Value.ToString())
            Section___Students.Text = (row.Cells(0).Value.ToString())
            Section___Students.Show()
        End If
    End Sub
    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Search.Text = ""
        Search.Enabled = True
        Search.TextAlign = HorizontalAlignment.Left
        Back_Button.Visible = False
        LoadSection()
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        If Search.Text = "" And Add_Button.Text = "Add" Then
            Section___Course_Add.Show()
        Else
            Dim cmd As New OleDbCommand("Select Acronym from Course where [Course Name] ='" & Search.Text & "'", conn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            If MsgBox("Are you sure you want to add section?", vbQuestion + vbYesNo) = vbYes Then
                Dim Alphabet As String = "ABCDEFGHIJKLMNOPQRSTUVEXYZ"
                Title = dr("Acronym") + " " + Alphabet(counter)
                Dim newsec As New OleDbCommand("Insert into [Section](Course, [Section]) values('" & Search.Text & "','" & Title & "')", conn)
                newsec.ExecuteNonQuery()
                MsgBox("Added Successfully")
                LoadAllSection()
            End If
        End If
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If Search.Enabled = True Then
            If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Delete from Course where [Course Name] ='" & TheName & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted Successfully")
                LoadSection()
            End If
        Else
            If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Delete from [Section] where [Section] ='" & TheName & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Deleted Successfully")
                LoadAllSection()
            End If
        End If
    End Sub

    Private Sub Section_DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Section_DataGrid.CellClick
        Dim row As DataGridViewRow = Section_DataGrid.Rows(e.RowIndex)
        TheName = row.Cells(0).Value.ToString()
    End Sub

End Class