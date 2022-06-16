<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Add_Button = New System.Windows.Forms.Button()
        Me.Stat_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sec_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Course_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FName_TextBox = New System.Windows.Forms.TextBox()
        Me.MiddleName = New System.Windows.Forms.Label()
        Me.LName_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Delete_Button = New System.Windows.Forms.Button()
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
        Me.Add_Button.Location = New System.Drawing.Point(265, 309)
        Me.Add_Button.Name = "Add_Button"
        Me.Add_Button.Size = New System.Drawing.Size(113, 36)
        Me.Add_Button.TabIndex = 58
        Me.Add_Button.Text = "Edit"
        Me.Add_Button.UseVisualStyleBackColor = False
        '
        'Stat_ComboBox
        '
        Me.Stat_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Stat_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stat_ComboBox.FormattingEnabled = True
        Me.Stat_ComboBox.Location = New System.Drawing.Point(86, 254)
        Me.Stat_ComboBox.Name = "Stat_ComboBox"
        Me.Stat_ComboBox.Size = New System.Drawing.Size(292, 31)
        Me.Stat_ComboBox.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Status:"
        '
        'Sec_ComboBox
        '
        Me.Sec_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sec_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec_ComboBox.FormattingEnabled = True
        Me.Sec_ComboBox.Location = New System.Drawing.Point(87, 208)
        Me.Sec_ComboBox.Name = "Sec_ComboBox"
        Me.Sec_ComboBox.Size = New System.Drawing.Size(292, 31)
        Me.Sec_ComboBox.TabIndex = 55
        '
        'Course_ComboBox
        '
        Me.Course_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Course_ComboBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Course_ComboBox.FormattingEnabled = True
        Me.Course_ComboBox.Location = New System.Drawing.Point(94, 162)
        Me.Course_ComboBox.Name = "Course_ComboBox"
        Me.Course_ComboBox.Size = New System.Drawing.Size(285, 31)
        Me.Course_ComboBox.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Middle Name:"
        '
        'MName_TextBox
        '
        Me.MName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName_TextBox.Location = New System.Drawing.Point(147, 116)
        Me.MName_TextBox.Name = "MName_TextBox"
        Me.MName_TextBox.ReadOnly = True
        Me.MName_TextBox.Size = New System.Drawing.Size(231, 29)
        Me.MName_TextBox.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 23)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "First Name:"
        '
        'FName_TextBox
        '
        Me.FName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName_TextBox.Location = New System.Drawing.Point(127, 70)
        Me.FName_TextBox.Name = "FName_TextBox"
        Me.FName_TextBox.ReadOnly = True
        Me.FName_TextBox.Size = New System.Drawing.Size(252, 29)
        Me.FName_TextBox.TabIndex = 52
        '
        'MiddleName
        '
        Me.MiddleName.AutoSize = True
        Me.MiddleName.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleName.Location = New System.Drawing.Point(15, 211)
        Me.MiddleName.Name = "MiddleName"
        Me.MiddleName.Size = New System.Drawing.Size(73, 23)
        Me.MiddleName.TabIndex = 49
        Me.MiddleName.Text = "Section:"
        '
        'LName_TextBox
        '
        Me.LName_TextBox.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName_TextBox.Location = New System.Drawing.Point(127, 24)
        Me.LName_TextBox.Name = "LName_TextBox"
        Me.LName_TextBox.ReadOnly = True
        Me.LName_TextBox.Size = New System.Drawing.Size(251, 29)
        Me.LName_TextBox.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Last Name:"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(15, 165)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(71, 23)
        Me.Email.TabIndex = 50
        Me.Email.Text = "Course:"
        '
        'Delete_Button
        '
        Me.Delete_Button.BackColor = System.Drawing.Color.Crimson
        Me.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete_Button.FlatAppearance.BorderSize = 0
        Me.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_Button.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Button.ForeColor = System.Drawing.Color.White
        Me.Delete_Button.Location = New System.Drawing.Point(19, 309)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(104, 36)
        Me.Delete_Button.TabIndex = 65
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 375)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Add_Button)
        Me.Controls.Add(Me.Stat_ComboBox)
        Me.Controls.Add(Me.Label4)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add_Button As Button
    Friend WithEvents Stat_ComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Sec_ComboBox As ComboBox
    Friend WithEvents Course_ComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MName_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FName_TextBox As TextBox
    Friend WithEvents MiddleName As Label
    Friend WithEvents LName_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Email As Label
    Friend WithEvents Delete_Button As Button
End Class
