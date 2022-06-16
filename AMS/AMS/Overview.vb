Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Overview
    Sub Noice()
        If Role = "Teacher" Then
            LoadTeacherChart()
        End If
        If Role = "Admin" Then
            LoadAdminChart()
        End If
    End Sub
    Public Sub LoadTeacherChart()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim cmd As New OleDbDataAdapter("Select [Attendance], COUNT(Attendance) AS Total from AMS where [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "' 
        and [Teacher] ='" & Full_Name.Text & "' group by [Attendance] ", conn)
        Dim naku As New DataSet

        cmd.Fill(naku, "Attendance")
        Chart1.DataSource = naku.Tables("Attendance")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Doughnut
        series1.Name = "Attendance"


        Dim dafont As New Font("Berlin Sans FB", 15, FontStyle.Regular)

        With Chart1
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(series1.Name).XValueMember = "Attendance"
            .Series(series1.Name).YValueMembers = "Total"
            .Series(0).LabelFormat = "{#,##0}"
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LabelForeColor = Color.White
            .Series(0).Font = dafont
            .Series(0).LegendText = "#VALX (#PERCENT)"
        End With

    End Sub
    Public Sub LoadAdminChart()
        With Chart1
            .Series.Clear()
            .Series.Add("Series1")
        End With

        Dim cmd As New OleDbDataAdapter("Select [Attendance], COUNT(Attendance) AS Total from AMS where 
        [Petsa] ='" & DateTimePicker1.Value.Date.ToString & "'group by [Attendance] ", conn)
        Dim naku As New DataSet

        cmd.Fill(naku, "Attendance")
        Chart1.DataSource = naku.Tables("Attendance")
        Dim series1 As Series = Chart1.Series("Series1")
        series1.ChartType = SeriesChartType.Doughnut
        series1.Name = "Attendance"

        Dim dafont As New Font("Berlin Sans FB", 15, FontStyle.Regular)

        With Chart1
            .ChartAreas(0).Area3DStyle.Enable3D = True
            .Series(series1.Name).XValueMember = "Attendance"
            .Series(series1.Name).YValueMembers = "Total"
            .Series(0).LabelFormat = "{#,##0}"
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LabelForeColor = Color.White
            .Series(0).Font = dafont
            .Series(0).LegendText = "#VALX (#PERCENT)"
        End With
    End Sub
    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Noice()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Noice()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Noice()
    End Sub
End Class