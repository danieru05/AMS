Imports System.Data.OleDb
Imports System.IO
Public Class Login
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Connect()
        Dim cmd As New OleDbCommand("select * from Admin where user=@username AND pass=@password", conn)
        Dim dr As OleDbDataReader
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@username", User.Text)
        cmd.Parameters.AddWithValue("@password", Pass.Text)
        dr = cmd.ExecuteReader
        Username = User.Text

        If (dr.Read() = True) Then
            Me.Hide()
            User.Text = ""
            Pass.Text = ""
            Overview.Full_Name.Text = dr("Last Name") + ", " + dr("First Name") + " " + dr("Middle Name")
            Admin.Show()
        ElseIf User.Text = "" And Pass.Text = "" Then
            MsgBox("Please input username and password!", vbCritical)
        Else
            MsgBox("Invalid Credentials!", vbCritical)
        End If

    End Sub
End Class
