Public Class Sections
    Private Sub Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMSDataSet.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.AMSDataSet.Course)
    End Sub
End Class