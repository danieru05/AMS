<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Departments
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Department_DataGrid = New System.Windows.Forms.DataGridView()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Teachers = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Department_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.ForeColor = System.Drawing.Color.DimGray
        Me.Search.Location = New System.Drawing.Point(12, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(871, 37)
        Me.Search.TabIndex = 0
        '
        'Department_DataGrid
        '
        Me.Department_DataGrid.AllowUserToAddRows = False
        Me.Department_DataGrid.AllowUserToDeleteRows = False
        Me.Department_DataGrid.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Department_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Department_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Department_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Department_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Department_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Department_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Department_DataGrid.ColumnHeadersVisible = False
        Me.Department_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Department, Me.Teachers})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Department_DataGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.Department_DataGrid.Location = New System.Drawing.Point(12, 89)
        Me.Department_DataGrid.Name = "Department_DataGrid"
        Me.Department_DataGrid.ReadOnly = True
        Me.Department_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Department_DataGrid.RowHeadersVisible = False
        Me.Department_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department_DataGrid.RowTemplate.DividerHeight = 1
        Me.Department_DataGrid.RowTemplate.Height = 100
        Me.Department_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Department_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Department_DataGrid.Size = New System.Drawing.Size(871, 500)
        Me.Department_DataGrid.TabIndex = 1
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(583, 55)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(96, 28)
        Me.Add_Button.TabIndex = 7
        Me.Add_Button.Text = "Add"
        Me.Add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.Crimson
        Me.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel_Button.FlatAppearance.BorderSize = 0
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.Location = New System.Drawing.Point(481, 55)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(96, 28)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancel_Button.UseVisualStyleBackColor = False
        Me.Cancel_Button.Visible = False
        '
        'Delete_Button
        '
        Me.Delete_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Button.FlatAppearance.BorderSize = 0
        Me.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.ForeColor = System.Drawing.Color.White
        Me.Delete_Button.Location = New System.Drawing.Point(787, 55)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(96, 28)
        Me.Delete_Button.TabIndex = 9
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_Button.UseVisualStyleBackColor = False
        '
        'Update_Button
        '
        Me.Update_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Button.FlatAppearance.BorderSize = 0
        Me.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Update_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Button.ForeColor = System.Drawing.Color.White
        Me.Update_Button.Location = New System.Drawing.Point(685, 55)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(96, 28)
        Me.Update_Button.TabIndex = 10
        Me.Update_Button.Text = "Update"
        Me.Update_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Update_Button.UseVisualStyleBackColor = False
        '
        'Department
        '
        Me.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Department.HeaderText = "Departments"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        '
        'Teachers
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Teachers.DefaultCellStyle = DataGridViewCellStyle3
        Me.Teachers.HeaderText = "N"
        Me.Teachers.Name = "Teachers"
        Me.Teachers.ReadOnly = True
        '
        'Departments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Department_DataGrid)
        Me.Controls.Add(Me.Search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Departments"
        Me.Text = "Form1"
        CType(Me.Department_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As TextBox
    Friend WithEvents Department_DataGrid As DataGridView
    Friend WithEvents Add_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Teachers As DataGridViewTextBoxColumn
End Class
