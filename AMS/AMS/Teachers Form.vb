Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Teachers_Form1

    Sub LogoutClosed()
        Overview.Full_Name.Text = ""
        Section_Teacher.Close()
        Student_Teacher.Close()
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub LogOut_Button_Click(sender As Object, e As EventArgs) Handles LogOut_Button.Click
        LogoutClosed()
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
    Private Sub Overview_Tab_Click(sender As Object, e As EventArgs) Handles Overview_Tab.Click
        Overview_Tab.BackColor = Color.LightSkyBlue
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Tabs(Overview)
    End Sub

    Private Sub Sections_Tab_Click(sender As Object, e As EventArgs) Handles Sections_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.LightSkyBlue
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.Transparent
        Tabs(Section_Teacher)
    End Sub

    Private Sub Students_Tab_Click(sender As Object, e As EventArgs) Handles Students_Tab.Click
        Overview_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.LightSkyBlue
        Profile_Button.BackColor = Color.Transparent
        Tabs(Student_Teacher)
    End Sub

    Private Sub Profile_Button_Click(sender As Object, e As EventArgs) Handles Profile_Button.Click
        Overview_Tab.BackColor = Color.Transparent
        Sections_Tab.BackColor = Color.Transparent
        Students_Tab.BackColor = Color.Transparent
        Profile_Button.BackColor = Color.LightSkyBlue
        Tabs(Profile)
    End Sub

    Private Sub Teachers_Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            LogoutClosed()
        Else
            e.Cancel = True
        End If
    End Sub
End Class