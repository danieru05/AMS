Imports System.Data.OleDb
Public Class Teacher_ADD
    Sub Department()
        Department___Teachers.Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher where Department = '" & Department___Teachers.Title.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Department___Teachers.Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
        Department___Teachers.Teachers_DataGrid.Sort(Department___Teachers.Teachers_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub AllTeachers()
        Teachers.Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Teachers.Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
        Teachers.Teachers_DataGrid.Sort(Teachers.Teachers_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Sub Combobox()
        Dim dept As New OleDbCommand("Select Department from Department", conn)
        Dim sec As New OleDbCommand("Select [Subject Name] from Subject", conn)
        Dim sec1 As New OleDbCommand("Select [Section] from [Section]", conn)
        Dim dr As OleDbDataReader
        If opt = 0 Then
            Dept_ComboBox.Items.Add(Department___Teachers.Title.Text)
        Else
            dr = dept.ExecuteReader
            While dr.Read()
                Dept_ComboBox.Items.Add(dr.Item("Department"))
            End While
        End If

        dr = sec.ExecuteReader
        While dr.Read()
            Subj_ComboBox.Items.Add(dr.Item("Subject Name"))
        End While

        dr = sec1.ExecuteReader
        While dr.Read()
            Sec_Box.Items.Add(dr.Item("Section"))
        End While

    End Sub
    Private Sub Teacher_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combobox()
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Dim add As New OleDbCommand("Insert into Teacher([user], [pass], [Last Name], [First Name], [Middle Name], [Email], [Department], [Subject Name], [Image]) 
            values('" & LName_TextBox.Text & "','" & LName_TextBox.Text & "','" & LName_TextBox.Text & "','" & LName_TextBox.Text & "','" & MName_TextBox.Text & "','" & Email_TextBox.Text & "','" & Dept_ComboBox.Text & "','" & Subj_ComboBox.Text & "','-')", conn)
        add.ExecuteNonQuery()
        For num As Integer = 0 To Sec_Box.CheckedItems.Count - 1
            Dim secteach As New OleDbCommand("Insert into [Sections Handled]([Section], [Teacher]) 
            values('" & Sec_Box.CheckedItems(num) & "','" & LName_TextBox.Text + ", " + FName_TextBox.Text + " " + MName_TextBox.Text & "')", conn)
            secteach.ExecuteNonQuery()
        Next
        Teachers.Teachers_DataGrid.Rows.Clear()
        Department()
        AllTeachers()
        LName_TextBox.Text = ""
        FName_TextBox.Text = ""
        MName_TextBox.Text = ""
        Email_TextBox.Text = ""
        Dept_ComboBox.Items.Clear()
        Subj_ComboBox.Items.Clear()
        Combobox()
    End Sub

    Private Sub Teacher_ADD_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        opt = 0
    End Sub
End Class