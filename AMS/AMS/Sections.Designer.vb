<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sections
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Department_DataGrid = New System.Windows.Forms.DataGridView()
        Me.AMSDataSet = New AMS.AMSDataSet()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseTableAdapter = New AMS.AMSDataSetTableAdapters.CourseTableAdapter()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Department_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Department_DataGrid
        '
        Me.Department_DataGrid.AllowUserToAddRows = False
        Me.Department_DataGrid.AllowUserToDeleteRows = False
        Me.Department_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Department_DataGrid.AutoGenerateColumns = False
        Me.Department_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Department_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Department_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Department_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Department_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Department_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Department_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseNameDataGridViewTextBoxColumn})
        Me.Department_DataGrid.DataSource = Me.CourseBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Department_DataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Department_DataGrid.Location = New System.Drawing.Point(12, 78)
        Me.Department_DataGrid.Name = "Department_DataGrid"
        Me.Department_DataGrid.ReadOnly = True
        Me.Department_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Department_DataGrid.RowHeadersVisible = False
        Me.Department_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_DataGrid.RowTemplate.DividerHeight = 1
        Me.Department_DataGrid.RowTemplate.Height = 100
        Me.Department_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.Size = New System.Drawing.Size(871, 499)
        Me.Department_DataGrid.TabIndex = 2
        '
        'AMSDataSet
        '
        Me.AMSDataSet.DataSetName = "AMSDataSet"
        Me.AMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.AMSDataSet
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "Course Name"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Department_DataGrid)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section"
        Me.Text = "Form1"
        CType(Me.Department_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Department_DataGrid As DataGridView
    Friend WithEvents AMSDataSet As AMSDataSet
    Friend WithEvents CourseBindingSource As BindingSource
    Friend WithEvents CourseTableAdapter As AMSDataSetTableAdapters.CourseTableAdapter
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
