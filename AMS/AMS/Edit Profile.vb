Imports System.Data.OleDb
Public Class Edit_Profile
    Dim noice As String
    Sub LoadProfile()
        Dim cmd As New OleDbCommand("select * from Admin where user ='" & Username & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Profile.Admin.Text = dr("Admin ID")
        Profile.LastName.Text = dr("Last Name")
        Profile.FirstName.Text = dr("First Name")
        Profile.MiddleName.Text = dr("MIddle Name")
        Profile.Email.Text = dr("Email")
    End Sub
    Private Sub Edit_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbCommand("select * from Admin where user ='" & Username & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Admin.Text = dr("Admin ID")
        user_TextBox.Text = dr("user")
        pass_TextBox.Text = dr("pass")
        lname_TextBox.Text = dr("Last Name")
        fname_TextBox.Text = dr("First Name")
        mname_TextBox.Text = dr("MIddle Name")
        email_TextBox.Text = dr("Email")
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim cmd As New OleDbCommand("Update Admin set [user] ='" & user_TextBox.Text & "', [pass] ='" & pass_TextBox.Text & "',
        [Last Name] ='" & lname_TextBox.Text & "', [First Name] ='" & fname_TextBox.Text & "', 
        [Middle Name] ='" & mname_TextBox.Text & "', [Email] ='" & email_TextBox.Text & "'
        where [user] ='" & Username & "'", conn)
        Username = user_TextBox.Text
        cmd.ExecuteNonQuery()
        MsgBox("Updated Successfully")
        LoadProfile()
        Me.Close()
    End Sub

End Class