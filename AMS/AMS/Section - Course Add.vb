Imports System.Data.OleDb
Public Class Section___Course_Add
    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Dim add As New OleDbCommand("Insert into Course([Course Name], [Acronym]) 
        values('" & Course_Name.Text & "','" & Acronym_Box.Text & "')", conn)
        add.ExecuteNonQuery()
        Sections.LoadSection()
        Course_Name.Text = ""
        Acronym_Box.Text = ""
    End Sub
End Class