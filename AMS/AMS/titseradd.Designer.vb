<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Teacher))
        Me.Teacher_ID_LabelText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.New_Teacher = New System.Windows.Forms.Label()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Dept_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Subj_ComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMSDataSet = New AMS.AMSDataSet()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherTableAdapter = New AMS.AMSDataSetTableAdapters.TeacherTableAdapter()
        Me.DepartmentTableAdapter = New AMS.AMSDataSetTableAdapters.DepartmentTableAdapter()
        Me.Panel3.SuspendLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Teacher_ID_LabelText
        '
        Me.Teacher_ID_LabelText.AutoSize = True
        Me.Teacher_ID_LabelText.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Teacher_ID_LabelText.Location = New System.Drawing.Point(23, 74)
        Me.Teacher_ID_LabelText.Name = "Teacher_ID_LabelText"
        Me.Teacher_ID_LabelText.Size = New System.Drawing.Size(99, 23)
        Me.Teacher_ID_LabelText.TabIndex = 14
        Me.Teacher_ID_LabelText.Text = "Teacher ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Middle Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Department:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Subject:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 394)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 23)
        Me.Label11.TabIndex = 22
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_TextBox.Location = New System.Drawing.Point(90, 255)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(324, 29)
        Me.Email_TextBox.TabIndex = 24
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(134, 117)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.Size = New System.Drawing.Size(280, 29)
        Me.LName_TextBox.TabIndex = 28
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(135, 163)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.Size = New System.Drawing.Size(279, 29)
        Me.FName_TextBox.TabIndex = 29
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(155, 209)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.Size = New System.Drawing.Size(259, 29)
        Me.MName_TextBox.TabIndex = 30
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.New_Teacher)
        Me.Panel3.Location = New System.Drawing.Point(-3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 47)
        Me.Panel3.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(792, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 23)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Time"
        '
        'New_Teacher
        '
        Me.New_Teacher.AutoSize = True
        Me.New_Teacher.BackColor = System.Drawing.Color.Transparent
        Me.New_Teacher.Font = New System.Drawing.Font("Berlin Sans FB Demi", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.New_Teacher.ForeColor = System.Drawing.Color.Wheat
        Me.New_Teacher.Location = New System.Drawing.Point(106, 9)
        Me.New_Teacher.Name = "New_Teacher"
        Me.New_Teacher.Size = New System.Drawing.Size(212, 33)
        Me.New_Teacher.TabIndex = 4
        Me.New_Teacher.Text = "NEW TEACHER"
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(147, 410)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(130, 39)
        Me.Add_Button.TabIndex = 9
        Me.Add_Button.Text = "Add"
        Me.Add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Dept_ComboBox
        '
        Me.Dept_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DepartmentBindingSource, "Department", True))
        Me.Dept_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dept_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_ComboBox.FormattingEnabled = True
        Me.Dept_ComboBox.Location = New System.Drawing.Point(147, 301)
        Me.Dept_ComboBox.Name = "Dept_ComboBox"
        Me.Dept_ComboBox.Size = New System.Drawing.Size(267, 31)
        Me.Dept_ComboBox.TabIndex = 32
        '
        'Subj_ComboBox
        '
        Me.Subj_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subj_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subj_ComboBox.FormattingEnabled = True
        Me.Subj_ComboBox.Location = New System.Drawing.Point(109, 345)
        Me.Subj_ComboBox.Name = "Subj_ComboBox"
        Me.Subj_ComboBox.Size = New System.Drawing.Size(305, 31)
        Me.Subj_ComboBox.TabIndex = 33
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.AMSDataSet
        '
        'AMSDataSet
        '
        Me.AMSDataSet.DataSetName = "AMSDataSet"
        Me.AMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "Teacher"
        Me.TeacherBindingSource.DataSource = Me.AMSDataSet
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'Add_Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 468)
        Me.Controls.Add(Me.Subj_ComboBox)
        Me.Controls.Add(Me.Dept_ComboBox)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MName_TextBox)
        Me.Controls.Add(Me.FName_TextBox)
        Me.Controls.Add(Me.LName_TextBox)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Teacher_ID_LabelText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Add_Teacher"
        Me.Text = "Add_Teacher"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Teacher_ID_LabelText As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents New_Teacher As Label
    Friend WithEvents Add_Button As Button
    Friend WithEvents Dept_ComboBox As ComboBox
    Friend WithEvents Subj_ComboBox As ComboBox
    Friend WithEvents AMSDataSet As AMSDataSet
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As AMSDataSetTableAdapters.TeacherTableAdapter
    Friend WithEvents DepartmentBindingSource As BindingSource
    Friend WithEvents DepartmentTableAdapter As AMSDataSetTableAdapters.DepartmentTableAdapter
End Class
