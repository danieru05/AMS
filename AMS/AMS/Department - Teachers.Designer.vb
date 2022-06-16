<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Department___Teachers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department___Teachers))
        Me.Teachers_DataGrid = New System.Windows.Forms.DataGridView()
        Me.Teacher_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middle_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Display_Panel = New System.Windows.Forms.Panel()
        Me.Add_Button = New System.Windows.Forms.Button()
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Display_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Teachers_DataGrid
        '
        Me.Teachers_DataGrid.AllowUserToAddRows = False
        Me.Teachers_DataGrid.AllowUserToDeleteRows = False
        Me.Teachers_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Teachers_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Teachers_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Teachers_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Teachers_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.Teachers_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Teachers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Teachers_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Teacher_ID, Me.Last_Name, Me.First_Name, Me.Middle_Name, Me.Department, Me.Subject})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Teachers_DataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Teachers_DataGrid.Location = New System.Drawing.Point(0, 87)
        Me.Teachers_DataGrid.MultiSelect = False
        Me.Teachers_DataGrid.Name = "Teachers_DataGrid"
        Me.Teachers_DataGrid.ReadOnly = True
        Me.Teachers_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Teachers_DataGrid.RowHeadersVisible = False
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teachers_DataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DimGray
        Me.Teachers_DataGrid.RowTemplate.DividerHeight = 1
        Me.Teachers_DataGrid.RowTemplate.Height = 100
        Me.Teachers_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Teachers_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Teachers_DataGrid.Size = New System.Drawing.Size(945, 314)
        Me.Teachers_DataGrid.TabIndex = 4
        '
        'Teacher_ID
        '
        Me.Teacher_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.First_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.First_Name.HeaderText = "First Name"
        Me.First_Name.Name = "First_Name"
        Me.First_Name.ReadOnly = True
        Me.First_Name.Width = 97
        '
        'Middle_Name
        '
        Me.Middle_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Middle_Name.HeaderText = "Middle Name"
        Me.Middle_Name.Name = "Middle_Name"
        Me.Middle_Name.ReadOnly = True
        Me.Middle_Name.Width = 111
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
        Me.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        Me.Subject.Width = 79
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.Enabled = False
        Me.Title.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.DimGray
        Me.Title.Location = New System.Drawing.Point(3, 3)
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Size = New System.Drawing.Size(939, 44)
        Me.Title.TabIndex = 5
        Me.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Display_Panel
        '
        Me.Display_Panel.Controls.Add(Me.Add_Button)
        Me.Display_Panel.Controls.Add(Me.Title)
        Me.Display_Panel.Controls.Add(Me.Teachers_DataGrid)
        Me.Display_Panel.Location = New System.Drawing.Point(12, 12)
        Me.Display_Panel.Name = "Display_Panel"
        Me.Display_Panel.Size = New System.Drawing.Size(945, 426)
        Me.Display_Panel.TabIndex = 5
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(846, 53)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(96, 28)
        Me.Add_Button.TabIndex = 10
        Me.Add_Button.Text = "Add"
        Me.Add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Department___Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 450)
        Me.Controls.Add(Me.Display_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Department___Teachers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMS"
        CType(Me.Teachers_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Display_Panel.ResumeLayout(False)
        Me.Display_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Teachers_DataGrid As DataGridView
    Friend WithEvents Title As TextBox
    Friend WithEvents Display_Panel As Panel
    Friend WithEvents Add_Button As Button
    Friend WithEvents Teacher_ID As DataGridViewTextBoxColumn
    Friend WithEvents Last_Name As DataGridViewTextBoxColumn
    Friend WithEvents First_Name As DataGridViewTextBoxColumn
    Friend WithEvents Middle_Name As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Subject As DataGridViewTextBoxColumn
End Class
