Imports System.Data.OleDb
Imports System.IO
Public Class Login
    Dim opt As Integer
    Sub LoadOverview()
        Admin.Overview_Tab.BackColor = Color.LightSkyBlue
        Admin.Departments_Tab.BackColor = Color.Transparent
        Admin.Teachers_Tab.BackColor = Color.Transparent
        Admin.Sections_Tab.BackColor = Color.Transparent
        Admin.Students_Tab.BackColor = Color.Transparent
        Admin.Profile_Button.BackColor = Color.Transparent
        Admin.Tabs(Overview)
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
            Overview.Full_Name.Text = dr("Last Name") + ", " + dr("First Name") + " " + dr("Middle Name")
            LoadOverview()
            Profile.Admin.Text = dr("Teacher ID")
            Profile.LastName.Text = dr("Last Name")
            Profile.FirstName.Text = dr("First Name")
            Profile.MiddleName.Text = dr("Middle Name")
            Profile.Email.Text = dr("Email")
            Profile.Dept.Text = dr("Department")
            Profile.Subj.Text = dr("Subject Name")
            Role = "Teacher"
            Profile.Teacher_Panel.Visible = True
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
            LoadOverview()
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
