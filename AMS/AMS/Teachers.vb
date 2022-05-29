Imports System.Data.OleDb
Public Class Teachers
    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMSDataSet.Teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.AMSDataSet.Teacher)
    End Sub
End Class