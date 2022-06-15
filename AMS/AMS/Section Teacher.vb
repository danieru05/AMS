Imports System.Data.OleDb
Public Class Section_Teacher
    Sub Tabs(ByVal panel As Form)
        Display_Panel.Controls.Clear()
        panel.TopLevel = False
        Display_Panel.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Section_Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim secteach As New OleDbCommand("Select * from [Sections Handled] where [Teacher]='" & Overview.Full_Name.Text & "'", conn)
        Dim dr As OleDbDataReader
        dr = secteach.ExecuteReader
        While dr.Read
            Section_DataGrid.Rows.Add(dr.Item("Section"))
        End While
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Section_DataGrid.Rows.Clear()
        Dim secteach As New OleDbCommand("Select [Section] from [Sections Handled] where [Section] like '" & Search.Text & "%' AND [Teacher] like '" & Overview.Full_Name.Text & "%'", conn)
        Dim dr As OleDbDataReader
        dr = secteach.ExecuteReader
        While dr.Read
            Section_DataGrid.Rows.Add(dr.Item("Section"))
        End While
    End Sub

    Private Sub Section_DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Section_DataGrid.CellDoubleClick
        Dim row As DataGridViewRow = Section_DataGrid.Rows(e.RowIndex)
        Search.Text = (row.Cells(0).Value.ToString())
        Search.ReadOnly = True
        Search.TextAlign = HorizontalAlignment.Center
        Back_Button.Visible = True
        Save_Button.Visible = True
        Students_DataGrid.Visible = True
        Students_DataGrid.Rows.Clear()
        Dim attend As New OleDbCommand("Select [Attendance] from Attendance", conn)
        Dim myreader1 As OleDbDataReader = attend.ExecuteReader
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Teacher] ='" & Overview.Full_Name.Text & "' and [Petsa] = '" & DateTimePicker1.Value.Date.ToString & "' and [Section] ='" & Search.Text & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        Attendance.Items.Clear()
        While myreader2.Read()
            Students_DataGrid.Rows.Add(myreader2.Item("Student ID"), myreader2.Item("Student Name"))
            While myreader1.Read
                Attendance.Items.Add(myreader1("Attendance"))
            End While
        End While
    End Sub

    Private Sub Back_Button_Click(sender As Object, e As EventArgs) Handles Back_Button.Click
        Back_Button.Visible = False
        Save_Button.Visible = False
        Students_DataGrid.Visible = False
        Search.ReadOnly = False
        Search.Text = ""
        Search.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Save_Button_Click(sender As Object, e As EventArgs) Handles Save_Button.Click
        Dim opt As Integer = 0
        Dim write As New OleDbCommand("SELECT * FROM AMS where [Teacher] ='" & Overview.Full_Name.Text & "' and [Petsa] = '" & DateTimePicker1.Value.Date.ToString & "' and [Section] ='" & Search.Text & "'", conn)
        Dim myreader2 As OleDbDataReader = write.ExecuteReader
        While myreader2.Read()
            If Students_DataGrid.Rows(opt).Cells(2).Value = "" Then
                Dim cmd As New OleDbCommand("Update AMS set [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "', [Attendance] ='-'
                where [Teacher] ='" & Overview.Full_Name.Text & "' and [Petsa] = '" & DateTimePicker1.Value.Date.Date.ToString & "' and [Section] ='" & Search.Text & "' and [Student ID] ='" & myreader2("Student ID") & "'", conn)
                cmd.ExecuteNonQuery()
            Else
                Dim cmd As New OleDbCommand("Update AMS set [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "', [Attendance] ='" & Students_DataGrid.Rows(opt).Cells(2).Value & "'
                where [Teacher] ='" & Overview.Full_Name.Text & "' and [Petsa] = '" & DateTimePicker1.Value.Date.Date.ToString & "' and [Section] ='" & Search.Text & "' and [Student ID] ='" & myreader2("Student ID") & "'", conn)
                cmd.ExecuteNonQuery()
            End If
            opt += 1
        End While
        MsgBox("Attendance Saved Successfully!")
    End Sub


End Class