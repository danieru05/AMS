<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Edit_Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Teacher))
        Me.SignIn = New System.Windows.Forms.Button()
        Me.Subj_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Dept_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SignIn
        '
        Me.SignIn.BackColor = System.Drawing.Color.SteelBlue
        Me.SignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SignIn.FlatAppearance.BorderSize = 0
        Me.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignIn.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignIn.ForeColor = System.Drawing.Color.White
        Me.SignIn.Location = New System.Drawing.Point(266, 315)
        Me.SignIn.Name = "SignIn"
        Me.SignIn.Size = New System.Drawing.Size(113, 36)
        Me.SignIn.TabIndex = 43
        Me.SignIn.Text = "Update"
        Me.SignIn.UseVisualStyleBackColor = False
        '
        'Subj_ComboBox
        '
        Me.Subj_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subj_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subj_ComboBox.FormattingEnabled = True
        Me.Subj_ComboBox.Location = New System.Drawing.Point(95, 254)
        Me.Subj_ComboBox.Name = "Subj_ComboBox"
        Me.Subj_ComboBox.Size = New System.Drawing.Size(283, 31)
        Me.Subj_ComboBox.TabIndex = 42
        '
        'Dept_ComboBox
        '
        Me.Dept_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dept_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_ComboBox.FormattingEnabled = True
        Me.Dept_ComboBox.Location = New System.Drawing.Point(146, 208)
        Me.Dept_ComboBox.Name = "Dept_ComboBox"
        Me.Dept_ComboBox.Size = New System.Drawing.Size(232, 31)
        Me.Dept_ComboBox.TabIndex = 41
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_TextBox.Location = New System.Drawing.Point(83, 162)
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.ReadOnly = True
        Me.Email_TextBox.Size = New System.Drawing.Size(296, 29)
        Me.Email_TextBox.TabIndex = 40
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(146, 116)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.ReadOnly = True
        Me.MName_TextBox.Size = New System.Drawing.Size(231, 29)
        Me.MName_TextBox.TabIndex = 39
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(126, 70)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.ReadOnly = True
        Me.FName_TextBox.Size = New System.Drawing.Size(252, 29)
        Me.FName_TextBox.TabIndex = 38
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(126, 24)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.ReadOnly = True
        Me.LName_TextBox.Size = New System.Drawing.Size(251, 29)
        Me.LName_TextBox.TabIndex = 37
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(14, 211)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(118, 23)
        Me.Email.TabIndex = 36
        Me.Email.Text = "Department:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Last Name:"
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(14, 257)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(75, 23)
        Me.MiddleName.TabIndex = 35
        Me.MiddleName.Text = "Subject:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Email:"
        '
        'Delete_Button
        '
        Me.Delete_Button.BackColor = System.Drawing.Color.Crimson
        Me.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Button.FlatAppearance.BorderSize = 0
        Me.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.ForeColor = System.Drawing.Color.White
        Me.Delete_Button.Location = New System.Drawing.Point(18, 315)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(104, 36)
        Me.Delete_Button.TabIndex = 64
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = False
        '
        'Edit_Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 370)
        Me.Controls.Add(Me.Delete_Button)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Edit_Teacher"
        Me.Text = "Edit Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignIn As Button
    Friend WithEvents Subj_ComboBox As ComboBox
    Friend WithEvents Dept_ComboBox As ComboBox
    Friend WithEvents Email_TextBox As TextBox
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MiddleName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Delete_Button As Button
End Class
