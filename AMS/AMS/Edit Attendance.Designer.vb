<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Attendance))
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Course_TextBox = New System.Windows.Forms.TextBox()
        Me.Section_TextBox = New System.Windows.Forms.TextBox()
        Me.Status_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Add_Button
        '
        Me.Add_Button.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_Button.FlatAppearance.BorderSize = 0
        Me.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Button.ForeColor = System.Drawing.Color.White
        Me.Add_Button.Location = New System.Drawing.Point(146, 409)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(113, 36)
        Me.Add_Button.TabIndex = 59
        Me.Add_Button.Text = "Add"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Status:"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(-7, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 46)
        Me.Panel3.TabIndex = 47
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
        Me.Label8.Location = New System.Drawing.Point(62, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 31)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "STUDENT ATTENDANCE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Middle Name:"
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(146, 166)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.ReadOnly = True
        Me.MName_TextBox.Size = New System.Drawing.Size(231, 29)
        Me.MName_TextBox.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "First Name:"
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(126, 120)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.ReadOnly = True
        Me.FName_TextBox.Size = New System.Drawing.Size(252, 29)
        Me.FName_TextBox.TabIndex = 53
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(14, 261)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(73, 23)
        Me.MiddleName.TabIndex = 50
        Me.MiddleName.Text = "Section:"
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(126, 74)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.ReadOnly = True
        Me.LName_TextBox.Size = New System.Drawing.Size(251, 29)
        Me.LName_TextBox.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Last Name:"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(14, 215)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(71, 23)
        Me.Email.TabIndex = 51
        Me.Email.Text = "Course:"
        '
        'Course_TextBox
        '
        Me.Course_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_TextBox.Location = New System.Drawing.Point(93, 212)
        Me.Course_TextBox.Name = "Course_TextBox"
        Me.Course_TextBox.ReadOnly = True
        Me.Course_TextBox.Size = New System.Drawing.Size(284, 29)
        Me.Course_TextBox.TabIndex = 60
        '
        'Section_TextBox
        '
        Me.Section_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_TextBox.Location = New System.Drawing.Point(93, 258)
        Me.Section_TextBox.Name = "Section_TextBox"
        Me.Section_TextBox.ReadOnly = True
        Me.Section_TextBox.Size = New System.Drawing.Size(284, 29)
        Me.Section_TextBox.TabIndex = 61
        '
        'Status_TextBox
        '
        Me.Status_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_TextBox.Location = New System.Drawing.Point(85, 304)
        Me.Status_TextBox.Name = "Status_TextBox"
        Me.Status_TextBox.ReadOnly = True
        Me.Status_TextBox.Size = New System.Drawing.Size(292, 29)
        Me.Status_TextBox.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Attendance:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(132, 350)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(246, 31)
        Me.ComboBox1.TabIndex = 64
        '
        'Edit_Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 468)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Status_TextBox)
        Me.Controls.Add(Me.Section_TextBox)
        Me.Controls.Add(Me.Course_TextBox)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
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
        Me.Name = "Edit_Attendance"
        Me.Text = "Attendance"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add_Button As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents MiddleName As Label
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Email As Label
    Friend WithEvents Course_TextBox As TextBox
    Friend WithEvents Section_TextBox As TextBox
    Friend WithEvents Status_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
