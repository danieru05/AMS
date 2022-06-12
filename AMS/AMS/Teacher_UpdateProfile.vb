Imports System.Data.OleDb
Public Class Teacher_UpdateProfile
    Dim noice As String
    Sub LoadProfile()
        Dim cmd As New OleDbCommand("select * from Teacher where user ='" & Username & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Profile.Admin.Text = dr("Teacher ID")
        Profile.LastName.Text = dr("Last Name")
        Profile.FirstName.Text = dr("First Name")
        Profile.MiddleName.Text = dr("MIddle Name")
        Profile.Email.Text = dr("Email")
    End Sub
    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbCommand("select * from Teacher where user ='" & Username & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Admin.Text = dr("Teacher ID")
        User.Text = dr("user")
        Pass.Text = dr("pass")
        LName.Text = dr("Last Name")
        FName.Text = dr("First Name")
        MName.Text = dr("MIddle Name")
        Email.Text = dr("Email")
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim cmd As New OleDbCommand("Update Teacher set [user] ='" & User.Text & "', [pass] ='" & Pass.Text & "',
        [Last Name] ='" & LName.Text & "', [First Name] ='" & FName.Text & "', 
        [Middle Name] ='" & MName.Text & "', [Email] ='" & Email.Text & "'
        where [user] ='" & Username & "'", conn)
        Username = User.Text
        cmd.ExecuteNonQuery()
        MsgBox("Updated Successfully")
        LoadProfile()
        Me.Close()
    End Sub


End Class