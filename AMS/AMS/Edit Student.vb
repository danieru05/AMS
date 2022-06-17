Imports System.Data.OleDb
Public Class Form1
    Sub AllStudents()
        Students.Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Students.Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"),
            dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
        Students.Students_DataGrid.Sort(Students.Students_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub Section()
        Section___Students.Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student where [Section] ='" & Section___Students.Title.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Section___Students.Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"),
            dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
        Section___Students.Students_DataGrid.Sort(Section___Students.Students_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub ComboBox()
        Dim course As New OleDbCommand("Select [Course Name] from [Course]", conn)
        Dim stat As New OleDbCommand("Select [Status] from Status", conn)
        Dim dr As OleDbDataReader
        dr = course.ExecuteReader
        While dr.Read()
            Course_ComboBox.Items.Add(dr.Item("Course Name"))
        End While
        dr = stat.ExecuteReader
        While dr.Read()
            Stat_ComboBox.Items.Add(dr.Item("Status"))
        End While
    End Sub
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        If Add_Button.Text = "Edit" Then
            LName_TextBox.ReadOnly = False
            FName_TextBox.ReadOnly = False
            MName_TextBox.ReadOnly = False
            Course_ComboBox.Items.Clear()
            Sec_ComboBox.Items.Clear()
            Stat_ComboBox.Items.Clear()
            Add_Button.Text = "SAVE"
            ComboBox()
        Else
            If MsgBox("Do you really want to update this?", vbQuestion + vbYesNo) = vbYes Then
                Dim add As New OleDbCommand("Update Student set [Last Name] = '" & LName_TextBox.Text & "', 
                [Middle Name] ='" & MName_TextBox.Text & "', [First Name] ='" & FName_TextBox.Text & "',
                [Section] ='" & Sec_ComboBox.Text & "', [Status] ='" & Stat_ComboBox.Text & "' 
                where [Last Name] ='" & Students.TheName & "'", conn)
                add.ExecuteNonQuery()
                MsgBox("Updated Successfully")
                AllStudents()
                Section___Students.LoadSection()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbCommand("select [Last Name], [First Name], [Middle Name], [Section], [Status] from Student where [Last Name] = '" & Students.TheName & "' or 
        [Last Name]='" & Section___Students.TheName & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        LName_TextBox.Text = dr("Last Name")
        FName_TextBox.Text = dr("First Name")
        MName_TextBox.Text = dr("Middle Name")
        Dim cmd1 As New OleDbCommand("select * from [Section] where [Section] = '" & dr("Section") & "'", conn)
        Dim dr1 As OleDbDataReader = cmd1.ExecuteReader
        dr1.Read()
        Course_ComboBox.Items.Add(dr1.Item("Course"))
        Course_ComboBox.SelectedIndex = 0
        Sec_ComboBox.Items.Clear()
        Sec_ComboBox.Items.Add(dr.Item("Section"))
        Sec_ComboBox.SelectedIndex = 0
        Stat_ComboBox.Items.Add(dr.Item("Status"))
        Stat_ComboBox.SelectedIndex = 0

    End Sub
    Private Sub Course_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Course_ComboBox.SelectedIndexChanged
        Sec_ComboBox.Items.Clear()
        Dim sec As New OleDbCommand("Select [Section] from [Section] where [Course] ='" & Course_ComboBox.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = sec.ExecuteReader
        While dr.Read()
            Sec_ComboBox.Items.Add(dr.Item("Section"))
        End While
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As New OleDbCommand("Delete from Student where [Last Name] ='" & Students.TheName & "' or [Last Name] ='" & Section___Students.TheName & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            Students.LoadStudent()
            Section___Students.LoadSection()
            Sections.LoadAllSection()
            Sections.LoadSection()
            Me.Close()
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Students.TheName = ""
        Section___Students.TheName = ""
    End Sub
End Class