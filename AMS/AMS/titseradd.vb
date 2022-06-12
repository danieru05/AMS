Imports System.Data.OleDb
Public Class Add_Teacher
    Dim i As Integer
    Private Sub Add_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dept As New OleDbCommand("select Department from Department", conn)
        Dim subj As New OleDbCommand("select [Subject Name] from Subject", conn)
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
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Dim cmd As New OleDbCommand("Insert into Teacher([user], [pass], [Last Name], [First Name], [Middle Name], Email, Department, [Subject Name]) 
        values('user', 'pass', '" & LName_TextBox.Text & "','" & FName_TextBox.Text & "','" & MName_TextBox.Text & "','" & Email_TextBox.Text & "',
        1,2)", conn)
        cmd.ExecuteNonQuery()
        i = cmd.ExecuteNonQuery()
        If i > 0 Then
            MsgBox("Added Successfully")
        End If
        Admin.Tabs(Teachers)
    End Sub
End Class