Public Class Departments
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMSDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.AMSDataSet.Department)
        'TODO: This line of code loads data into the 'AMSDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.AMSDataSet.Department)

    End Sub
End Class