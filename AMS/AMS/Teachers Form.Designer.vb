<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teachers_Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teachers_Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.Time_Label = New System.Windows.Forms.Label()
        Me.Day_Label = New System.Windows.Forms.Label()
        Me.Display_Panel = New System.Windows.Forms.Panel()
        Me.Teachers_Form = New System.Windows.Forms.Panel()
        Me.Profile_Button = New System.Windows.Forms.Button()
        Me.Overview_Tab = New System.Windows.Forms.Button()
        Me.Students_Tab = New System.Windows.Forms.Button()
        Me.Sections_Tab = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.LogOut_Button = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Teachers_Form.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Date_Label)
        Me.Panel2.Controls.Add(Me.Time_Label)
        Me.Panel2.Controls.Add(Me.Day_Label)
        Me.Panel2.Location = New System.Drawing.Point(222, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 41)
        Me.Panel2.TabIndex = 10
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.BackColor = System.Drawing.Color.Transparent
        Me.Date_Label.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Label.ForeColor = System.Drawing.Color.White
        Me.Date_Label.Location = New System.Drawing.Point(323, 11)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(52, 23)
        Me.Date_Label.TabIndex = 6
        Me.Date_Label.Text = "Date"
        '
        'Time_Label
        '
        Me.Time_Label.AutoSize = True
        Me.Time_Label.BackColor = System.Drawing.Color.Transparent
        Me.Time_Label.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time_Label.ForeColor = System.Drawing.Color.White
        Me.Time_Label.Location = New System.Drawing.Point(792, 11)
        Me.Time_Label.Name = "Time_Label"
        Me.Time_Label.Size = New System.Drawing.Size(50, 23)
        Me.Time_Label.TabIndex = 5
        Me.Time_Label.Text = "Time"
        '
        'Day_Label
        '
        Me.Day_Label.AutoSize = True
        Me.Day_Label.BackColor = System.Drawing.Color.Transparent
        Me.Day_Label.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Day_Label.ForeColor = System.Drawing.Color.White
        Me.Day_Label.Location = New System.Drawing.Point(3, 11)
        Me.Day_Label.Name = "Day_Label"
        Me.Day_Label.Size = New System.Drawing.Size(45, 23)
        Me.Day_Label.TabIndex = 4
        Me.Day_Label.Text = "Day"
        '
        'Display_Panel
        '
        Me.Display_Panel.Location = New System.Drawing.Point(222, 45)
        Me.Display_Panel.Name = "Display_Panel"
        Me.Display_Panel.Size = New System.Drawing.Size(895, 601)
        Me.Display_Panel.TabIndex = 9
        '
        'Teachers_Form
        '
        Me.Teachers_Form.BackColor = System.Drawing.Color.Turquoise
        Me.Teachers_Form.BackgroundImage = CType(resources.GetObject("Teachers_Form.BackgroundImage"), System.Drawing.Image)
        Me.Teachers_Form.Controls.Add(Me.Label1)
        Me.Teachers_Form.Controls.Add(Me.Profile_Button)
        Me.Teachers_Form.Controls.Add(Me.Overview_Tab)
        Me.Teachers_Form.Controls.Add(Me.Students_Tab)
        Me.Teachers_Form.Controls.Add(Me.Sections_Tab)
        Me.Teachers_Form.Controls.Add(Me.Title)
        Me.Teachers_Form.Controls.Add(Me.LogOut_Button)
        Me.Teachers_Form.Location = New System.Drawing.Point(-11, -11)
        Me.Teachers_Form.Name = "Teachers_Form"
        Me.Teachers_Form.Size = New System.Drawing.Size(227, 670)
        Me.Teachers_Form.TabIndex = 8
        '
        'Profile_Button
        '
        Me.Profile_Button.BackColor = System.Drawing.Color.Transparent
        Me.Profile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Profile_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Profile_Button.FlatAppearance.BorderSize = 0
        Me.Profile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Profile_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Button.ForeColor = System.Drawing.Color.White
        Me.Profile_Button.Image = CType(resources.GetObject("Profile_Button.Image"), System.Drawing.Image)
        Me.Profile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Profile_Button.Location = New System.Drawing.Point(10, 578)
        Me.Profile_Button.Name = "Profile_Button"
        Me.Profile_Button.Padding = New System.Windows.Forms.Padding(5)
        Me.Profile_Button.Size = New System.Drawing.Size(217, 40)
        Me.Profile_Button.TabIndex = 12
        Me.Profile_Button.Text = " Profile"
        Me.Profile_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Profile_Button.UseVisualStyleBackColor = False
        '
        'Overview_Tab
        '
        Me.Overview_Tab.BackColor = System.Drawing.Color.Transparent
        Me.Overview_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Overview_Tab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Overview_Tab.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Overview_Tab.FlatAppearance.BorderSize = 0
        Me.Overview_Tab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Overview_Tab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Overview_Tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Overview_Tab.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overview_Tab.ForeColor = System.Drawing.Color.White
        Me.Overview_Tab.Image = CType(resources.GetObject("Overview_Tab.Image"), System.Drawing.Image)
        Me.Overview_Tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Overview_Tab.Location = New System.Drawing.Point(10, 187)
        Me.Overview_Tab.Name = "Overview_Tab"
        Me.Overview_Tab.Size = New System.Drawing.Size(217, 46)
        Me.Overview_Tab.TabIndex = 11
        Me.Overview_Tab.Text = " Overview"
        Me.Overview_Tab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Overview_Tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Overview_Tab.UseVisualStyleBackColor = False
        '
        'Students_Tab
        '
        Me.Students_Tab.BackColor = System.Drawing.Color.Transparent
        Me.Students_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Students_Tab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Students_Tab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Students_Tab.FlatAppearance.BorderSize = 0
        Me.Students_Tab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Students_Tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Students_Tab.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Students_Tab.ForeColor = System.Drawing.Color.White
        Me.Students_Tab.Image = CType(resources.GetObject("Students_Tab.Image"), System.Drawing.Image)
        Me.Students_Tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Students_Tab.Location = New System.Drawing.Point(10, 291)
        Me.Students_Tab.Name = "Students_Tab"
        Me.Students_Tab.Size = New System.Drawing.Size(217, 46)
        Me.Students_Tab.TabIndex = 10
        Me.Students_Tab.Text = " Students"
        Me.Students_Tab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Students_Tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Students_Tab.UseVisualStyleBackColor = False
        '
        'Sections_Tab
        '
        Me.Sections_Tab.BackColor = System.Drawing.Color.Transparent
        Me.Sections_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Sections_Tab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sections_Tab.FlatAppearance.BorderSize = 0
        Me.Sections_Tab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.Sections_Tab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sections_Tab.Font = New System.Drawing.Font("Berlin Sans FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sections_Tab.ForeColor = System.Drawing.Color.White
        Me.Sections_Tab.Image = CType(resources.GetObject("Sections_Tab.Image"), System.Drawing.Image)
        Me.Sections_Tab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Sections_Tab.Location = New System.Drawing.Point(10, 239)
        Me.Sections_Tab.Name = "Sections_Tab"
        Me.Sections_Tab.Size = New System.Drawing.Size(217, 46)
        Me.Sections_Tab.TabIndex = 8
        Me.Sections_Tab.Text = " Sections"
        Me.Sections_Tab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Sections_Tab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Sections_Tab.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Crique Grotesk Medium", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(36, 50)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(158, 69)
        Me.Title.TabIndex = 6
        Me.Title.Text = "AMS"
        '
        'LogOut_Button
        '
        Me.LogOut_Button.BackColor = System.Drawing.Color.Transparent
        Me.LogOut_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LogOut_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogOut_Button.FlatAppearance.BorderSize = 0
        Me.LogOut_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.LogOut_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOut_Button.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_Button.ForeColor = System.Drawing.Color.White
        Me.LogOut_Button.Image = CType(resources.GetObject("LogOut_Button.Image"), System.Drawing.Image)
        Me.LogOut_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOut_Button.Location = New System.Drawing.Point(10, 608)
        Me.LogOut_Button.Name = "LogOut_Button"
        Me.LogOut_Button.Padding = New System.Windows.Forms.Padding(5)
        Me.LogOut_Button.Size = New System.Drawing.Size(217, 50)
        Me.LogOut_Button.TabIndex = 5
        Me.LogOut_Button.Text = " Log Out"
        Me.LogOut_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LogOut_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogOut_Button.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Teachers_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 645)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Display_Panel)
        Me.Controls.Add(Me.Teachers_Form)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Teachers_Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teachers"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Teachers_Form.ResumeLayout(False)
        Me.Teachers_Form.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Date_Label As Label
    Friend WithEvents Time_Label As Label
    Friend WithEvents Day_Label As Label
    Friend WithEvents Display_Panel As Panel
    Friend WithEvents Teachers_Form As Panel
    Friend WithEvents Profile_Button As Button
    Friend WithEvents Overview_Tab As Button
    Friend WithEvents Students_Tab As Button
    Friend WithEvents Sections_Tab As Button
    Friend WithEvents Title As Label
    Friend WithEvents LogOut_Button As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Label1 As Label
End Class
