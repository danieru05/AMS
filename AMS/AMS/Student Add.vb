Imports System.Data.OleDb
Public Class Student_Add
    Dim x As String
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
    Sub AllStudents()
        Students.Students_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("Select * from Student", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Students.Students_DataGrid.Rows.Add(dr.Item("Student ID"), dr.Item("Last Name"), dr.Item("First Name"),
            dr.Item("Middle Name"), dr.Item("Section"), dr.Item("Status"))
        End While
        Students.Students_DataGrid.Sort(Students.Students_DataGrid.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub
    Sub ComboBoxSection()
        Dim sec As New OleDbCommand("Select [Section] from [Section] where [Section] ='" & x & "'", conn)
        Dim dr As OleDbDataReader
        dr = sec.ExecuteReader
        While dr.Read()
            Sec_ComboBox.Items.Add(dr.Item("Section"))
        End While
    End Sub

    Sub ComboBox()
        Dim course As New OleDbCommand("Select [Course Name] from [Course]", conn)
        Dim stat As New OleDbCommand("Select [Status] from Status", conn)
        Dim dr As OleDbDataReader


        If opt = 0 Then
            Course_ComboBox.Items.Add(Sections.Search.Text)
            Course_ComboBox.SelectedIndex = 0
            Sec_ComboBox.Items.Add(Section___Students.Title.Text)
            Sec_ComboBox.SelectedIndex = 0
        Else
            dr = course.ExecuteReader
            While dr.Read()
                Course_ComboBox.Items.Add(dr.Item("Course Name"))
            End While

        End If
        dr = stat.ExecuteReader
        While dr.Read()
            If dr.Item("Status") = "Dropped" Then
                Exit While
            End If
            Stat_ComboBox.Items.Add(dr.Item("Status"))
        End While

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
    Private Sub Student_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox()
    End Sub
    Private Sub Student_Add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        opt = 0
    End Sub

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Dim add As New OleDbCommand("Insert into Student([Last Name], [First Name], [Middle Name], [Section], [Status]) 
        values('" & LName_TextBox.Text & "','" & FName_TextBox.Text & "','" & MName_TextBox.Text & "','" & Sec_ComboBox.Text & "','" & Stat_ComboBox.Text & "')", conn)
        add.ExecuteNonQuery()
        Section()
        AllStudents()
        LName_TextBox.Text = ""
        FName_TextBox.Text = ""
        MName_TextBox.Text = ""
        Course_ComboBox.Items.Clear()
        Sec_ComboBox.Items.Clear()
        Stat_ComboBox.Items.Clear()
        ComboBox()
    End Sub
End Class