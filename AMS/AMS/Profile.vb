Imports System.Data.OleDb
Imports System.IO
Public Class Profile
    Dim noice As String
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using img1 As New OpenFileDialog()
            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"
            If img1.ShowDialog = DialogResult.OK Then
                noice = Path.GetFileName(img1.FileName)
                PictureBox1.Image = Image.FromFile(img1.FileName)
            End If
        End Using
        Button1.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Role = "Teacher" Then
            Dim command As New OleDbCommand("Update Teacher set [Image] = @picture where [user]='" & Username & "'", conn)
            command.Parameters.Add("@picture", OleDbType.VarChar).Value = noice
            command.ExecuteNonQuery()
            MsgBox("Image Uploaded")
            Button2.Visible = False
            Button1.Visible = True
        Else
            Dim command As New OleDbCommand("Update Admin set [Image] = @picture where [user]='" & Username & "'", conn)
            command.Parameters.Add("@picture", OleDbType.VarChar).Value = noice
            command.ExecuteNonQuery()
            MsgBox("Image Uploaded")
            Button2.Visible = False
            Button1.Visible = True
        End If

    End Sub
End Class