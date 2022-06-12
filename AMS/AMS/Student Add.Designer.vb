<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Add))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Sec_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Course_ComboBox = New System.Windows.Forms.ComboBox()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Stat_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(-5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 46)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB Demi", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(110, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 31)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "NEW STUDENT"
        '
        'Sec_ComboBox
        '
        Me.Sec_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sec_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec_ComboBox.FormattingEnabled = True
        Me.Sec_ComboBox.Location = New System.Drawing.Point(88, 257)
        Me.Sec_ComboBox.Name = "Sec_ComboBox"
        Me.Sec_ComboBox.Size = New System.Drawing.Size(292, 31)
        Me.Sec_ComboBox.TabIndex = 41
        '
        'Course_ComboBox
        '
        Me.Course_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Course_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_ComboBox.FormattingEnabled = True
        Me.Course_ComboBox.Location = New System.Drawing.Point(95, 211)
        Me.Course_ComboBox.Name = "Course_ComboBox"
        Me.Course_ComboBox.Size = New System.Drawing.Size(285, 31)
        Me.Course_ComboBox.TabIndex = 40
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(148, 165)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.Size = New System.Drawing.Size(231, 29)
        Me.MName_TextBox.TabIndex = 38
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(128, 119)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.Size = New System.Drawing.Size(252, 29)
        Me.FName_TextBox.TabIndex = 37
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(128, 73)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.Size = New System.Drawing.Size(251, 29)
        Me.LName_TextBox.TabIndex = 36
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(16, 214)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(71, 23)
        Me.Email.TabIndex = 35
        Me.Email.Text = "Course:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Last Name:"
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(16, 260)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(73, 23)
        Me.MiddleName.TabIndex = 34
        Me.MiddleName.Text = "Section:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Middle Name:"
        '
        'Stat_ComboBox
        '
        Me.Stat_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Stat_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat_ComboBox.FormattingEnabled = True
        Me.Stat_ComboBox.Location = New System.Drawing.Point(87, 303)
        Me.Stat_ComboBox.Name = "Stat_ComboBox"
        Me.Stat_ComboBox.Size = New System.Drawing.Size(292, 31)
        Me.Stat_ComboBox.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Status:"
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(138, 378)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(113, 36)
        Me.Add_Button.TabIndex = 45
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Student_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(400, 443)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Stat_ComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Sec_ComboBox)
        Me.Controls.Add(Me.Course_ComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MName_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FName_TextBox)
        Me.Controls.Add(Me.MiddleName)
        Me.Controls.Add(Me.LName_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Email)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Student_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Sec_ComboBox As ComboBox
    Friend WithEvents Course_ComboBox As ComboBox
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MiddleName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Stat_ComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Add_Button As Button
End Class
