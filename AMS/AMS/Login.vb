Imports System.Data.OleDb
Imports System.IO
Public Class Login
    Sub AdminLoadOverview()
        Admin.Overview_Tab.BackColor = Color.LightSkyBlue
        Admin.Departments_Tab.BackColor = Color.Transparent
        Admin.Teachers_Tab.BackColor = Color.Transparent
        Admin.Sections_Tab.BackColor = Color.Transparent
        Admin.Students_Tab.BackColor = Color.Transparent
        Admin.Profile_Button.BackColor = Color.Transparent
        Admin.Tabs(Overview)
    End Sub
    Sub TeacherLoadOverview()
        Teachers_Form1.Overview_Tab.BackColor = Color.LightSkyBlue
        Teachers_Form1.Sections_Tab.BackColor = Color.Transparent
        Teachers_Form1.Students_Tab.BackColor = Color.Transparent
        Teachers_Form1.Profile_Button.BackColor = Color.Transparent
        Teachers_Form1.Tabs(Overview)
    End Sub
    Sub CheckIn()
        Dim crucial As Integer = 0
        Dim check As New OleDbCommand("Select * from [Check In]", conn)
        Dim dr As OleDbDataReader = check.ExecuteReader
        While dr.Read()
            If Overview.Full_Name.Text = dr("Teacher") And DateTimePicker1.Value.Date.ToString = dr("Petsa") Then
                crucial += 1
            End If
        End While
        If crucial = 0 Then
            Dim checkin As New OleDbCommand("Insert into [Check In]([Teacher], [Petsa]) 
            values('" & Overview.Full_Name.Text & "','" & DateTimePicker1.Value.Date.ToString & "')", conn)
            checkin.ExecuteNonQuery()
            Dim checkers As New OleDbCommand("Select * from [Check In]", conn)
            Dim myreader0 As OleDbDataReader = checkers.ExecuteReader
            While myreader0.Read()
                If DateTimePicker1.Value.Date.ToString = myreader0("Petsa") And myreader0("Teacher") = Overview.Full_Name.Text Then
                    Dim secteach As New OleDbCommand("Select * from [Sections Handled] where [Teacher]='" & Overview.Full_Name.Text & "'", conn)
                    Dim myreader1 As OleDbDataReader = secteach.ExecuteReader
                    While myreader1.Read
                        Dim section As New OleDbCommand("Select * from Student where [Section] ='" & myreader1("Section") & "'", conn)
                        Dim myreader2 As OleDbDataReader = section.ExecuteReader
                        While myreader2.Read()
                            Dim name As String = myreader2("Last Name") + ", " + myreader2("First Name") + " " + myreader2("Middle Name")
                            Dim add As New OleDbCommand("Insert into AMS([Petsa], [Student ID], [Student Name], [Section], [Attendance], [Teacher]) 
                            values('" & DateTimePicker1.Value.Date.ToString & "','" & myreader2.Item("Student ID") & "','" & name & "','" & myreader2.Item("Section") & "','-','" & Overview.Full_Name.Text & "')", conn)
                            add.ExecuteNonQuery()
                        End While
                    End While
                End If
            End While
        End If
    End Sub
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Connect()
        Dim teach As New OleDbCommand("select * from Teacher where user ='" & User.Text & "' AND pass ='" & Pass.Text & "'", conn)
        Dim adm As New OleDbCommand("select * from Admin where user ='" & User.Text & "' AND pass ='" & Pass.Text & "'", conn)
        Dim dr As OleDbDataReader
        Dim cr As OleDbDataReader
        dr = teach.ExecuteReader
        cr = adm.ExecuteReader
        If dr.Read() Then
            Username = User.Text
            Me.Hide()
            User.Text = ""
            Pass.Text = ""
            Name = dr("Last Name") + ", " + dr("First Name") + " " + dr("Middle Name")
            Overview.Full_Name.Text = Name
            Profile.Admin.Text = dr("Teacher ID")
            Profile.LastName.Text = dr("Last Name")
            Profile.FirstName.Text = dr("First Name")
            Profile.MiddleName.Text = dr("Middle Name")
            Profile.Email.Text = dr("Email")
            Profile.Dept.Text = dr("Department")
            Profile.Subj.Text = dr("Subject Name")
            Role = "Teacher"
            Profile.Teacher_Panel.Visible = True
            Dim secteach As New OleDbCommand("Select * from [Sections Handled] where [Teacher]='" & Overview.Full_Name.Text & "'", conn)
            dr = secteach.ExecuteReader
            Profile.Sec.Items.Clear()
            While dr.Read
                Profile.Sec.Items.Add(dr.Item("Section"))
            End While
            CheckIn()
            TeacherLoadOverview()
            Teachers_Form1.Show()
        ElseIf cr.Read() Then
            Username = User.Text
            Me.Hide()
            User.Text = ""
            Pass.Text = ""
            Overview.Full_Name.Text = cr("Last Name") + ", " + cr("First Name") + " " + cr("Middle Name")
            Profile.Admin.Text = cr("Admin ID")
            Profile.LastName.Text = cr("Last Name")
            Profile.FirstName.Text = cr("First Name")
            Profile.MiddleName.Text = cr("Middle Name")
            Profile.Email.Text = cr("Email")
            AdminLoadOverview()
            Profile.Teacher_Panel.Visible = False
            Role = "Admin"
            Admin.Show()
        ElseIf User.Text = "" And Pass.Text = "" Then
            MsgBox("Please input username and password!", vbCritical)
        Else
            MsgBox("Invalid Credentials!", vbCritical)
        End If


    End Sub
End Class
