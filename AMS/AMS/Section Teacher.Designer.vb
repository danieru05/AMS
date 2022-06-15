<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Section_Teacher
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Display_Panel = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        Me.Students_DataGrid = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Full_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attendance = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Section_DataGrid = New System.Windows.Forms.DataGridView()
        Me.Section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Display_Panel.SuspendLayout()
        CType(Me.Students_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Section_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Display_Panel
        '
        Me.Display_Panel.Controls.Add(Me.DateTimePicker1)
        Me.Display_Panel.Controls.Add(Me.Save_Button)
        Me.Display_Panel.Controls.Add(Me.Back_Button)
        Me.Display_Panel.Controls.Add(Me.Students_DataGrid)
        Me.Display_Panel.Controls.Add(Me.Search)
        Me.Display_Panel.Controls.Add(Me.Section_DataGrid)
        Me.Display_Panel.Location = New System.Drawing.Point(12, 12)
        Me.Display_Panel.Name = "Display_Panel"
        Me.Display_Panel.Size = New System.Drawing.Size(871, 577)
        Me.Display_Panel.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(610, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(261, 25)
        Me.DateTimePicker1.TabIndex = 53
        Me.DateTimePicker1.Value = New Date(2022, 6, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'Save_Button
        '
        Me.Save_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Save_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Button.FlatAppearance.BorderSize = 0
        Me.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Button.ForeColor = System.Drawing.Color.White
        Me.Save_Button.Location = New System.Drawing.Point(758, 538)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(113, 36)
        Me.Save_Button.TabIndex = 52
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = False
        Me.Save_Button.Visible = False
        '
        'Back_Button
        '
        Me.Back_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Back_Button.Location = New System.Drawing.Point(0, 0)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(100, 37)
        Me.Back_Button.TabIndex = 51
        Me.Back_Button.Text = "Back"
        Me.Back_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Students_DataGrid
        '
        Me.Students_DataGrid.AllowUserToResizeRows = False
        Me.Students_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Students_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Students_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        Me.Students_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Students_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Students_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Students_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Full_Name, Me.Attendance})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Students_DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.Students_DataGrid.Location = New System.Drawing.Point(0, 46)
        Me.Students_DataGrid.Name = "Students_DataGrid"
        Me.Students_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Students_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Students_DataGrid.RowHeadersVisible = False
        Me.Students_DataGrid.RowTemplate.DividerHeight = 1
        Me.Students_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Students_DataGrid.Size = New System.Drawing.Size(871, 531)
        Me.Students_DataGrid.TabIndex = 50
        Me.Students_DataGrid.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 101
        '
        'Full_Name
        '
        Me.Full_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Full_Name.HeaderText = "Full Name"
        Me.Full_Name.Name = "Full_Name"
        '
        'Attendance
        '
        Me.Attendance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Attendance.HeaderText = "Attendance"
        Me.Attendance.Name = "Attendance"
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(0, 0)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(871, 37)
        Me.Search.TabIndex = 1
        '
        'Section_DataGrid
        '
        Me.Section_DataGrid.AllowUserToAddRows = False
        Me.Section_DataGrid.AllowUserToDeleteRows = False
        Me.Section_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Section_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Section_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Section_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Section_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Section_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Section_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Section_DataGrid.ColumnHeadersVisible = False
        Me.Section_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Section})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Section_DataGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.Section_DataGrid.Location = New System.Drawing.Point(0, 43)
        Me.Section_DataGrid.Name = "Section_DataGrid"
        Me.Section_DataGrid.ReadOnly = True
        Me.Section_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Section_DataGrid.RowHeadersVisible = False
        Me.Section_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_DataGrid.RowTemplate.DividerHeight = 1
        Me.Section_DataGrid.RowTemplate.Height = 100
        Me.Section_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.Size = New System.Drawing.Size(871, 531)
        Me.Section_DataGrid.TabIndex = 2
        '
        'Section
        '
        Me.Section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Section.HeaderText = "Section"
        Me.Section.Name = "Section"
        Me.Section.ReadOnly = True
        '
        'Section_Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Display_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section_Teacher"
        Me.Text = "Section_Teacher"
        Me.Display_Panel.ResumeLayout(False)
        Me.Display_Panel.PerformLayout()
        CType(Me.Students_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Section_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Display_Panel As Panel
    Friend WithEvents Search As TextBox
    Friend WithEvents Section_DataGrid As DataGridView
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Students_DataGrid As DataGridView
    Friend WithEvents Back_Button As Button
    Friend WithEvents Save_Button As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Full_Name As DataGridViewTextBoxColumn
    Friend WithEvents Attendance As DataGridViewComboBoxColumn
End Class
