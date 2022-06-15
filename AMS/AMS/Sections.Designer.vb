<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sections))
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Section_DataGrid = New System.Windows.Forms.DataGridView()
        Me.Section = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Display_Panel = New System.Windows.Forms.Panel()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Back_Button = New System.Windows.Forms.Button()
        CType(Me.Section_DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Display_Panel.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_DataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Section_DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Section_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Section_DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Section_DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.Section_DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Section_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Section_DataGrid.ColumnHeadersVisible = False
        Me.Section_DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Section})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Section_DataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Section_DataGrid.Location = New System.Drawing.Point(0, 75)
        Me.Section_DataGrid.Name = "Section_DataGrid"
        Me.Section_DataGrid.ReadOnly = True
        Me.Section_DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Section_DataGrid.RowHeadersVisible = False
        Me.Section_DataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Berlin Sans FB", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_DataGrid.RowTemplate.DividerHeight = 1
        Me.Section_DataGrid.RowTemplate.Height = 100
        Me.Section_DataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Section_DataGrid.Size = New System.Drawing.Size(871, 499)
        Me.Section_DataGrid.TabIndex = 2
        '
        'Section
        '
        Me.Section.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Section.HeaderText = "Section"
        Me.Section.Name = "Section"
        Me.Section.ReadOnly = True
        '
        'Display_Panel
        '
        Me.Display_Panel.Controls.Add(Me.Delete_Button)
        Me.Display_Panel.Controls.Add(Me.Add_Button)
        Me.Display_Panel.Controls.Add(Me.Back_Button)
        Me.Display_Panel.Controls.Add(Me.Search)
        Me.Display_Panel.Controls.Add(Me.Section_DataGrid)
        Me.Display_Panel.Location = New System.Drawing.Point(12, 12)
        Me.Display_Panel.Name = "Display_Panel"
        Me.Display_Panel.Size = New System.Drawing.Size(871, 577)
        Me.Display_Panel.TabIndex = 3
        '
        'Delete_Button
        '
        Me.Delete_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Button.FlatAppearance.BorderSize = 0
        Me.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.ForeColor = System.Drawing.Color.White
        Me.Delete_Button.Location = New System.Drawing.Point(775, 43)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(96, 28)
        Me.Delete_Button.TabIndex = 12
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_Button.UseVisualStyleBackColor = False
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(673, 43)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(96, 28)
        Me.Add_Button.TabIndex = 9
        Me.Add_Button.Text = "Add"
        Me.Add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Back_Button
        '
        Me.Back_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back_Button.ForeColor = System.Drawing.Color.DimGray
        Me.Back_Button.Image = CType(resources.GetObject("Back_Button.Image"), System.Drawing.Image)
        Me.Back_Button.Location = New System.Drawing.Point(0, 0)
        Me.Back_Button.Name = "Back_Button"
        Me.Back_Button.Size = New System.Drawing.Size(100, 37)
        Me.Back_Button.TabIndex = 3
        Me.Back_Button.Text = "Back"
        Me.Back_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Back_Button.UseVisualStyleBackColor = True
        '
        'Sections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 601)
        Me.Controls.Add(Me.Display_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sections"
        Me.Text = "Form1"
        CType(Me.Section_DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Display_Panel.ResumeLayout(False)
        Me.Display_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Search As TextBox
    Friend WithEvents Section_DataGrid As DataGridView
    Friend WithEvents Section As DataGridViewTextBoxColumn
    Friend WithEvents Display_Panel As Panel
    Friend WithEvents Back_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Add_Button As Button
    Friend WithEvents Delete_Button As Button
End Class
