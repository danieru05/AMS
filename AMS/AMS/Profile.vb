Imports System.Data.OleDb
Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New OleDbCommand("select * from Admin where user ='" & Username & "'", conn)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        Admin.Text = dr("Admin ID")
        LastName.Text = dr("Last Name")
        FirstName.Text = dr("First Name")
        MiddleName.Text = dr("MIddle Name")
        Email.Text = dr("Email")
    End Sub
End Class