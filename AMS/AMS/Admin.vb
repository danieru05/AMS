Imports System.Data.OleDb
Public Class Admin
    Sub logout()
        Department___Teachers.Hide()
        Section___Course_Add.Hide()
        Section___Students.Hide()
        Student_Add.Hide()
        Teacher_ADD.Hide()
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub LogOut_Button_Click(sender As Object, e As EventArgs) Handles LogOut_Button.Click
        logout()
    End Sub
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Overview_Tab.BackColor = Color.LightSkyBlue
        Tabs(Overview)
    End Sub
    Sub Tabs(ByVal panel As Form)
        Display_Panel.Controls.Clear()
        panel.TopLevel = False
        Display_Panel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Date_Label.Text = Date.Now.ToString("MMMM dd, yyyy")
        Time_Label.Text = Date.Now.ToString("hh:mm tttt")
        Day_Label.Text = Date.Now.ToString("dddd")
    End Sub

    'TAB HIGHLIGHT'
    Private Sub Overview_Tab_Click(sender As Object, e As EventArgs) Handles Overview_Tab.Click
        Overview_Tab.BackColor = Color.LightSkyBlue
        Departments_Tab.BackColor = Color.Transparent
        Teachers_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Tabs(Overview)
    End Sub
    Private Sub Departments_Tab_Click(sender As Object, e As EventArgs) Handles Departments_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Departments_Tab.BackColor = Color.LightSkyBlue
        Teachers_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Tabs(Departments)
    End Sub
    Private Sub Teachers_Tab_Click(sender As Object, e As EventArgs) Handles Teachers_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Departments_Tab.BackColor = Color.Transparent
        Teachers_Tab.BackColor = Color.LightSkyBlue
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Overview_Tab.BackColor = Color.Transparent
        Tabs(Teachers)
    End Sub
    Private Sub Sections_Tab_Click(sender As Object, e As EventArgs) Handles Sections_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Departments_Tab.BackColor = Color.Transparent
        Teachers_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.LightSkyBlue
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Tabs(Sections)
    End Sub
    Private Sub Students_Tab_Click(sender As Object, e As EventArgs) Handles Students_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Departments_Tab.BackColor = Color.Transparent
        Teachers_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.LightSkyBlue
        Profile_Button.BackColor = Color.Transparent
        Tabs(Students)
    End Sub
    Private Sub Profile_Button_Click(sender As Object, e As EventArgs) Handles Profile_Button.Click
        Overview_Tab.BackColor = Color.Transparent
        Departments_Tab.BackColor = Color.Transparent
        Teachers_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.LightSkyBlue
        Tabs(Profile)
    End Sub
    Private Sub Admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            logout()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Display_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Display_Panel.Paint

    End Sub
End Class