Imports System.Data.OleDb
Public Class Edit_Attendance

    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click
        Dim cmd As New OleDbCommand("Update AMS set [Attendance] ='" & ComboBox1.Text & "'
        where [Petsa] ='" & Student_Teacher.DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "'
        and [Student Name] ='" & Student_Teacher.TheName & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Attendance Saved Successfully!")
        Student_Teacher.Attend()
        Overview.LoadTeacherChart()
        Me.Close()
    End Sub

    Private Sub Edit_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Petsa] ='" & Student_Teacher.DateTimePicker1.Value.Date.ToString & "' and [Teacher]='" & Overview.Full_Name.Text & "'
        and [Student Name] ='" & Student_Teacher.TheName & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            Dim noice As New OleDbCommand("Select * from Student", conn)
            Dim dr As OleDbDataReader = noice.ExecuteReader
            While dr.Read()
                If dr("Student ID") = myreader2("Student ID") Then
                    LName_TextBox.Text = dr("Last Name")
                    FName_TextBox.Text = dr("First Name")
                    MName_TextBox.Text = dr("Middle Name")
                    Section_TextBox.Text = dr("Section")
                    Status_TextBox.Text = dr("Status")
                    Dim crs As New OleDbCommand("Select * from [Section] where [Section] ='" & Section_TextBox.Text & "'", conn)
                    Dim tite As OleDbDataReader = crs.ExecuteReader
                    While tite.Read()
                        Course_TextBox.Text = tite("Course")
                    End While
                    ComboBox1.Text = myreader2("Attendance")
                    Dim attend As New OleDbCommand("Select [Attendance] from Attendance", conn)
                    Dim myreader1 As OleDbDataReader = attend.ExecuteReader
                    While myreader1.Read
                        ComboBox1.Items.Add(myreader1("Attendance"))
                    End While
                End If
            End While
        End While
    End Sub
End Class