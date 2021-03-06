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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Teachers_DataGrid = New System.Windows.Forms.DataGridView()
        Me.Teacher_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middle_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Button = New System.Windows.Forms.Button()
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(12, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(871, 37)
        Me.Search.TabIndex = 1
        '
        'Teachers_DataGrid
        '
        Me.Teachers_DataGrid.AllowUserToAddRows = False
        Me.Teachers_DataGrid.AllowUserToDeleteRows = False
        Me.Teachers_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Teachers_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Teachers_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Teachers_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Teachers_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.Teachers_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Teachers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Teachers_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Teacher_ID, Me.Last_Name, Me.First_Name, Me.Middle_Name, Me.Department, Me.Subject})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Teachers_DataGrid.DefaultCellStyle = DataGridViewCellStyle7
        Me.Teachers_DataGrid.Location = New System.Drawing.Point(12, 89)
        Me.Teachers_DataGrid.MultiSelect = False
        Me.Teachers_DataGrid.Name = "Teachers_DataGrid"
        Me.Teachers_DataGrid.ReadOnly = True
        Me.Teachers_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Teachers_DataGrid.RowHeadersVisible = False
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
        Me.Teachers_DataGrid.RowTemplate.DividerHeight = 1
        Me.Teachers_DataGrid.RowTemplate.Height = 100
        Me.Teachers_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Teachers_DataGrid.Size = New System.Drawing.Size(871, 511)
        Me.Teachers_DataGrid.TabIndex = 3
        '
        'Teacher_ID
        '
        Me.Teacher_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Teacher_ID.HeaderText = "ID"
        Me.Teacher_ID.Name = "Teacher_ID"
        Me.Teacher_ID.ReadOnly = True
        Me.Teacher_ID.Width = 47
        '
        'Last_Name
        '
        Me.Last_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Last_Name.HeaderText = "Last Name"
        Me.Last_Name.Name = "Last_Name"
        Me.Last_Name.ReadOnly = True
        '
        'First_Name
        '
        Me.First_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        '
        'Middle_Name
        '
        Me.Middle_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Middle_Name.HeaderText = "Middle Name"
        Me.Middle_Name.Name = "Middle_Name"
        Me.Middle_Name.ReadOnly = True
        '
        'Department
        '
        Me.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        '
        'Subject
        '
        Me.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(787, 55)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(96, 28)
        Me.Add_Button.TabIndex = 8
        Me.Add_Button.Text = "Add"
        Me.Add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Teachers_DataGrid)
        Me.Controls.Add(Me.Search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teachers"
        Me.Text = "Teacher"
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As TextBox
    Friend WithEvents Teachers_DataGrid As DataGridView
    Friend WithEvents Add_Button As Button
    Friend WithEvents Teacher_ID As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Middle_Name As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
End Class
