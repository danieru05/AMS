Imports System.Data.OleDb
Public Class Edit_Teacher
    Dim department, subject As String
    Sub DefaultComboBox()
        Dim dept As New OleDbCommand("Select Department from Department where Department ='" & department & "'", conn)
        Dim subj As New OleDbCommand("Select [Subject Name] from Subject where [Subject Name] ='" & subject & "'", conn)
        Dim dr As OleDbDataReader
        dr = dept.ExecuteReader
        While dr.Read()
            Dept_ComboBox.Items.Add(dr.Item("Department"))
        End While
        dr = subj.ExecuteReader
        While dr.Read()
            Subj_ComboBox.Items.Add(dr.Item("Subject Name"))
        End While
    End Sub
    Sub AllTeachers()
        Teachers.Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            Teachers.Teachers_DataGrid.Rows.Add(dr.Item("Teacher ID"), dr.Item("Last Name"), dr.Item("First Name"), dr.Item("Middle Name"), dr.Item("Department"), dr.Item("Subject Name"))
        End While
    End Sub
    Sub Combobox()
        Dim dept As New OleDbCommand("Select Department from Department", conn)
        Dim sec As New OleDbCommand("Select [Subject Name] from Subject", conn)
        Dim dr As OleDbDataReader
        dr = dept.ExecuteReader
        While dr.Read()
            Dept_ComboBox.Items.Add(dr.Item("Department"))
        End While
        dr = sec.ExecuteReader
        While dr.Read()
            Subj_ComboBox.Items.Add(dr.Item("Subject Name"))
        End While
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        If SignIn.Text = "Update" Then
            Dept_ComboBox.Items.Clear()
            Subj_ComboBox.Items.Clear()
            Combobox()
            SignIn.Text = "SAVE"
            LName_TextBox.Enabled = False
            FName_TextBox.Enabled = False
            MName_TextBox.Enabled = False
            Email_TextBox.Enabled = False
        Else
            If MsgBox("Do you really want to update this?", vbQuestion + vbYesNo) = vbYes Then
                Dim add As New OleDbCommand("Update Teacher set [Department] = '" & Dept_ComboBox.Text & "', 
                [Subject Name] ='" & Subj_ComboBox.Text & "' where [Last Name] ='" & Teachers.TheName & "'", conn)
                add.ExecuteNonQuery()
                MsgBox("Updated Successfully")
                AllTeachers()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        If MsgBox("Do you want to delete this?", vbQuestion + vbYesNo) = vbYes Then
            Dim cmd As New OleDbCommand("Delete from Teacher where [last Name] ='" & Teachers.TheName & "'or [Last Name] ='" & Department___Teachers.TheName & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully")
            Teachers.LoadTeacher()
            Department___Teachers.LoadTeacher()
            Departments.LoadDepartment()
            Me.Close()
        End If
    End Sub

    Private Sub Edit_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Department___Teachers.Teachers_DataGrid.Rows.Clear()
        Dim cmd As New OleDbCommand("select * from Teacher where [Last Name] = '" & Teachers.TheName & "' or [Last Name] ='" & Department___Teachers.TheName & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        LName_TextBox.Text = dr("Last Name")
        FName_TextBox.Text = dr("First Name")
        MName_TextBox.Text = dr("Middle Name")
        Email_TextBox.Text = dr("Email")
        department = dr("Department")
        subject = dr("Subject Name")
        DefaultComboBox()
        Dept_ComboBox.SelectedIndex = 0
        Subj_ComboBox.SelectedIndex = 0
    End Sub
End Class