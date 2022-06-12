<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_ADD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher_ADD))
        Me.Email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.Dept_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Subj_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SignIn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(14, 266)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(118, 23)
        Me.Email.TabIndex = 19
        Me.Email.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Last Name:"
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(14, 312)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(75, 23)
        Me.MiddleName.TabIndex = 18
        Me.MiddleName.Text = "Subject:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Email:"
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(126, 79)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.Size = New System.Drawing.Size(251, 29)
        Me.LName_TextBox.TabIndex = 21
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(126, 125)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.Size = New System.Drawing.Size(252, 29)
        Me.FName_TextBox.TabIndex = 22
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(146, 171)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.Size = New System.Drawing.Size(231, 29)
        Me.MName_TextBox.TabIndex = 25
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_TextBox.Location = New System.Drawing.Point(83, 217)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(296, 29)
        Me.Email_TextBox.TabIndex = 26
        '
        'Dept_ComboBox
        '
        Me.Dept_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dept_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_ComboBox.FormattingEnabled = True
        Me.Dept_ComboBox.Location = New System.Drawing.Point(146, 263)
        Me.Dept_ComboBox.Name = "Dept_ComboBox"
        Me.Dept_ComboBox.Size = New System.Drawing.Size(232, 31)
        Me.Dept_ComboBox.TabIndex = 27
        '
        'Subj_ComboBox
        '
        Me.Subj_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subj_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subj_ComboBox.FormattingEnabled = True
        Me.Subj_ComboBox.Location = New System.Drawing.Point(95, 309)
        Me.Subj_ComboBox.Name = "Subj_ComboBox"
        Me.Subj_ComboBox.Size = New System.Drawing.Size(283, 31)
        Me.Subj_ComboBox.TabIndex = 28
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.SteelBlue
        Me.SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignIn.FlatAppearance.BorderSize = 0
        Me.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignIn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIn.ForeColor = System.Drawing.Color.White
        Me.SignIn.Location = New System.Drawing.Point(146, 378)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(113, 36)
        Me.SignIn.TabIndex = 29
        Me.SignIn.Text = "Add"
        Me.SignIn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(-5, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 46)
        Me.Panel3.TabIndex = 30
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
        Me.Label8.Location = New System.Drawing.Point(106, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 31)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "NEW TEACHER"
        '
        'Teacher_ADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 438)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SignIn)
        Me.Controls.Add(Me.Subj_ComboBox)
        Me.Controls.Add(Me.Dept_ComboBox)
        Me.Controls.Add(Me.Email_TextBox)
        Me.Controls.Add(Me.MName_TextBox)
        Me.Controls.Add(Me.FName_TextBox)
        Me.Controls.Add(Me.LName_TextBox)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MiddleName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Teacher_ADD"
        Me.Text = "Add Teacher"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MiddleName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents Dept_ComboBox As ComboBox
    Friend WithEvents Subj_ComboBox As ComboBox
    Friend WithEvents SignIn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
