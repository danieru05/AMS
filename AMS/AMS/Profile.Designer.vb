<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Me.Edit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Admin ID:"
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.BackColor = System.Drawing.Color.Transparent
        Me.Admin.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(136, 29)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(83, 26)
        Me.Admin.TabIndex = 5
        Me.Admin.Text = "Admin ID"
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.Location = New System.Drawing.Point(146, 129)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(95, 26)
        Me.FirstName.TabIndex = 6
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.Location = New System.Drawing.Point(146, 79)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(97, 26)
        Me.LastName.TabIndex = 7
        Me.LastName.Text = "Last Name"
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(160, 179)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(114, 26)
        Me.MiddleName.TabIndex = 8
        Me.MiddleName.Text = "Middle Name"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(94, 229)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(53, 26)
        Me.Email.TabIndex = 9
        Me.Email.Text = "Email"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
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
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.SteelBlue
        Me.Edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Edit.FlatAppearance.BorderSize = 0
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.Font = New System.Drawing.Font("Typo Formal Demo", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit.ForeColor = System.Drawing.Color.White
        Me.Edit.Location = New System.Drawing.Point(697, 514)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(170, 36)
        Me.Edit.TabIndex = 11
        Me.Edit.Text = "Edit Profile"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
