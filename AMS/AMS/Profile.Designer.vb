<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Teacher_Panel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Subj = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Edit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Sec = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Teacher_Panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Admin ID:"
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.BackColor = System.Drawing.Color.Transparent
        Me.Admin.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(136, 29)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(87, 23)
        Me.Admin.TabIndex = 5
        Me.Admin.Text = "Admin ID"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.Location = New System.Drawing.Point(146, 129)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(101, 23)
        Me.FirstName.TabIndex = 6
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.Location = New System.Drawing.Point(146, 79)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(100, 23)
        Me.LastName.TabIndex = 7
        Me.LastName.Text = "Last Name"
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(160, 179)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(121, 23)
        Me.MiddleName.TabIndex = 8
        Me.MiddleName.Text = "Middle Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(94, 229)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(56, 23)
        Me.Email.TabIndex = 9
        Me.Email.Text = "Email"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Teacher_Panel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Email)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MiddleName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LastName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.FirstName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Admin)
        Me.Panel1.Location = New System.Drawing.Point(12, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 280)
        Me.Panel1.TabIndex = 10
        '
        'Teacher_Panel
        '
        Me.Teacher_Panel.Controls.Add(Me.Sec)
        Me.Teacher_Panel.Controls.Add(Me.Label10)
        Me.Teacher_Panel.Controls.Add(Me.Label8)
        Me.Teacher_Panel.Controls.Add(Me.Subj)
        Me.Teacher_Panel.Controls.Add(Me.Dept)
        Me.Teacher_Panel.Controls.Add(Me.Label6)
        Me.Teacher_Panel.Location = New System.Drawing.Point(362, 3)
        Me.Teacher_Panel.Name = "Teacher_Panel"
        Me.Teacher_Panel.Size = New System.Drawing.Size(466, 274)
        Me.Teacher_Panel.TabIndex = 10
        Me.Teacher_Panel.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Section Handled:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Subject:"
        '
        'Subj
        '
        Me.Subj.AutoSize = True
        Me.Subj.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subj.Location = New System.Drawing.Point(100, 76)
        Me.Subj.Name = "Subj"
        Me.Subj.Size = New System.Drawing.Size(100, 23)
        Me.Subj.TabIndex = 12
        Me.Subj.Text = "Last Name"
        '
        'Dept
        '
        Me.Dept.AutoSize = True
        Me.Dept.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.Location = New System.Drawing.Point(141, 26)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(92, 23)
        Me.Dept.TabIndex = 11
        Me.Dept.Text = "Admin ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Department:"
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.SteelBlue
        Me.Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(697, 514)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(170, 36)
        Me.Edit.TabIndex = 11
        Me.Edit.Text = "Edit Profile"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(358, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Sec
        '
        Me.Sec.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec.FormattingEnabled = True
        Me.Sec.ItemHeight = 23
        Me.Sec.Location = New System.Drawing.Point(172, 126)
        Me.Sec.Name = "Sec"
        Me.Sec.Size = New System.Drawing.Size(276, 119)
        Me.Sec.TabIndex = 35
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Teacher_Panel.ResumeLayout(False)
        Me.Teacher_Panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Admin As Label
    Friend WithEvents FirstName As Label
    Friend WithEvents LastName As Label
    Friend WithEvents MiddleName As Label
    Friend WithEvents Email As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Edit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Teacher_Panel As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Subj As Label
    Friend WithEvents Dept As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Sec As ListBox
End Class
