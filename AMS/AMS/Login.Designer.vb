<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pass_Label = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.SignIn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AMS = New System.Windows.Forms.Label()
        Me.User_Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(525, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Pass_Label
        '
        Me.Pass_Label.AutoSize = True
        Me.Pass_Label.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Label.ForeColor = System.Drawing.Color.DimGray
        Me.Pass_Label.Location = New System.Drawing.Point(461, 218)
        Me.Pass_Label.Name = "Pass_Label"
        Me.Pass_Label.Size = New System.Drawing.Size(88, 23)
        Me.Pass_Label.TabIndex = 3
        Me.Pass_Label.Text = "Password"
        '
        'User
        '
        Me.User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.User.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.Color.DimGray
        Me.User.Location = New System.Drawing.Point(461, 167)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(249, 29)
        Me.User.TabIndex = 4
        '
        'Pass
        '
        Me.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pass.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.ForeColor = System.Drawing.Color.DimGray
        Me.Pass.Location = New System.Drawing.Point(461, 247)
        Me.Pass.Name = "Pass"
        Me.Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass.Size = New System.Drawing.Size(249, 29)
        Me.Pass.TabIndex = 5
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.SteelBlue
        Me.SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignIn.FlatAppearance.BorderSize = 0
        Me.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignIn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIn.ForeColor = System.Drawing.Color.White
        Me.SignIn.Location = New System.Drawing.Point(533, 307)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(113, 36)
        Me.SignIn.TabIndex = 6
        Me.SignIn.Text = "Login"
        Me.SignIn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.AMS)
        Me.Panel1.Location = New System.Drawing.Point(-33, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 439)
        Me.Panel1.TabIndex = 0
        '
        'AMS
        '
        Me.AMS.AutoSize = True
        Me.AMS.BackColor = System.Drawing.Color.Transparent
        Me.AMS.Font = New System.Drawing.Font("Crique Grotesk Medium", 80.24999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMS.ForeColor = System.Drawing.Color.White
        Me.AMS.Location = New System.Drawing.Point(71, 263)
        Me.AMS.Name = "AMS"
        Me.AMS.Size = New System.Drawing.Size(282, 124)
        Me.AMS.TabIndex = 1
        Me.AMS.Text = "AMS"
        '
        'User_Label
        '
        Me.User_Label.AutoSize = True
        Me.User_Label.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Label.ForeColor = System.Drawing.Color.DimGray
        Me.User_Label.Location = New System.Drawing.Point(461, 138)
        Me.User_Label.Name = "User_Label"
        Me.User_Label.Size = New System.Drawing.Size(98, 23)
        Me.User_Label.TabIndex = 2
        Me.User_Label.Text = "Username:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(735, 412)
        Me.Controls.Add(Me.SignIn)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Pass_Label)
        Me.Controls.Add(Me.User_Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - AMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents AMS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Pass_Label As Label
    Friend WithEvents User As TextBox
    Friend WithEvents Pass As TextBox
    Friend WithEvents SignIn As Button
    Friend WithEvents User_Label As Label
End Class
