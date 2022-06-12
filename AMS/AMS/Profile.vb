Imports System.Data.OleDb
Imports System.IO
Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If Role = "Admin" Then
            Edit_Profile.Show()
        End If
        If Role = "Teacher" Then
            Teacher_UpdateProfile.Show()
        End If
    End Sub
End Class