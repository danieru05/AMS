<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher_UpdateProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher_UpdateProfile))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.LName = New System.Windows.Forms.TextBox()
        Me.FName = New System.Windows.Forms.TextBox()
        Me.MName = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 23)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Email:"
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.SteelBlue
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.FlatAppearance.BorderSize = 0
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(368, 349)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(104, 36)
        Me.save.TabIndex = 52
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 23)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Username:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 23)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 23)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Admin ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Middle Name:"
        '
        'Admin
        '
        Me.Admin.AutoSize = True
        Me.Admin.BackColor = System.Drawing.Color.Transparent
        Me.Admin.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Admin.Location = New System.Drawing.Point(128, 27)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(99, 23)
        Me.Admin.TabIndex = 44
        Me.Admin.Text = "Teacher ID"
        '
        'User
        '
        Me.User.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(124, 69)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(348, 29)
        Me.User.TabIndex = 50
        '
        'Pass
        '
        Me.Pass.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(124, 112)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(348, 29)
        Me.Pass.TabIndex = 57
        '
        'LName
        '
        Me.LName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(132, 158)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(340, 29)
        Me.LName.TabIndex = 58
        '
        'FName
        '
        Me.FName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.Location = New System.Drawing.Point(132, 206)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(340, 29)
        Me.FName.TabIndex = 59
        '
        'MName
        '
        Me.MName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName.Location = New System.Drawing.Point(154, 250)
        Me.MName.Name = "MName"
        Me.MName.Size = New System.Drawing.Size(318, 29)
        Me.MName.TabIndex = 60
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(89, 296)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(383, 29)
        Me.Email.TabIndex = 61
        '
        'Teacher_UpdateProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 407)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.MName)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Admin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Teacher_UpdateProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Admin As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Pass As TextBox
    Friend WithEvents LName As TextBox
    Friend WithEvents FName As TextBox
    Friend WithEvents MName As TextBox
    Friend WithEvents Email As TextBox
End Class
