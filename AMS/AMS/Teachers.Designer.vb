<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teachers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Teachers_DataGrid = New System.Windows.Forms.DataGridView()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMSDataSet = New AMS.AMSDataSet()
        Me.TeacherTableAdapter = New AMS.AMSDataSetTableAdapters.TeacherTableAdapter()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttendanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentTableAdapter1 = New AMS.AMSDataSetTableAdapters.DepartmentTableAdapter()
        Me.AttendanceTableAdapter1 = New AMS.AMSDataSetTableAdapters.AttendanceTableAdapter()
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Typo Formal Demo", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(871, 42)
        Me.TextBox1.TabIndex = 1
        '
        'Teachers_DataGrid
        '
        Me.Teachers_DataGrid.AllowUserToAddRows = False
        Me.Teachers_DataGrid.AllowUserToDeleteRows = False
        Me.Teachers_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Teachers_DataGrid.AutoGenerateColumns = False
        Me.Teachers_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Teachers_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Teachers_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Teachers_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.Teachers_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Typo Formal Demo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Teachers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Teachers_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherIDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.AttendanceDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn})
        Me.Teachers_DataGrid.DataSource = Me.TeacherBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Typo Formal Demo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Teachers_DataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Teachers_DataGrid.Location = New System.Drawing.Point(12, 78)
        Me.Teachers_DataGrid.Name = "Teachers_DataGrid"
        Me.Teachers_DataGrid.ReadOnly = True
        Me.Teachers_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Typo Formal Demo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Teachers_DataGrid.RowHeadersVisible = False
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Typo Formal Demo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
        Me.Teachers_DataGrid.RowTemplate.DividerHeight = 1
        Me.Teachers_DataGrid.RowTemplate.Height = 100
        Me.Teachers_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.Size = New System.Drawing.Size(871, 511)
        Me.Teachers_DataGrid.TabIndex = 3
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "Teacher"
        Me.TeacherBindingSource.DataSource = Me.AMSDataSet
        '
        'AMSDataSet
        '
        Me.AMSDataSet.DataSetName = "AMSDataSet"
        Me.AMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        Me.DepartmentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttendanceDataGridViewTextBoxColumn
        '
        Me.AttendanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AttendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance"
        Me.AttendanceDataGridViewTextBoxColumn.HeaderText = "Attendance"
        Me.AttendanceDataGridViewTextBoxColumn.Name = "AttendanceDataGridViewTextBoxColumn"
        Me.AttendanceDataGridViewTextBoxColumn.ReadOnly = True
        Me.AttendanceDataGridViewTextBoxColumn.Width = 105
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        Me.MiddleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeacherIDDataGridViewTextBoxColumn
        '
        Me.TeacherIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TeacherIDDataGridViewTextBoxColumn.DataPropertyName = "Teacher ID"
        Me.TeacherIDDataGridViewTextBoxColumn.HeaderText = "Teacher ID"
        Me.TeacherIDDataGridViewTextBoxColumn.Name = "TeacherIDDataGridViewTextBoxColumn"
        Me.TeacherIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentTableAdapter1
        '
        Me.DepartmentTableAdapter1.ClearBeforeFill = True
        '
        'AttendanceTableAdapter1
        '
        Me.AttendanceTableAdapter1.ClearBeforeFill = True
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Teachers_DataGrid)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teachers"
        Me.Text = "Teacher"
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Teachers_DataGrid As DataGridView
    Friend WithEvents AMSDataSet As AMSDataSet
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As AMSDataSetTableAdapters.TeacherTableAdapter
    Friend WithEvents TeacherIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentTableAdapter1 As AMSDataSetTableAdapters.DepartmentTableAdapter
    Friend WithEvents AttendanceTableAdapter1 As AMSDataSetTableAdapters.AttendanceTableAdapter
End Class
