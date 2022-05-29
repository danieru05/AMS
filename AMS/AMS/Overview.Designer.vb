<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Overview))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Full_Name = New System.Windows.Forms.Label()
        Me.Welcome = New System.Windows.Forms.Label()
        Me.Illustrator1 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Full_Name
        '
        Me.Full_Name.AutoSize = True
        Me.Full_Name.Enabled = False
        Me.Full_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Full_Name.Font = New System.Drawing.Font("Crique Grotesk Medium", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Full_Name.ForeColor = System.Drawing.Color.DimGray
        Me.Full_Name.Location = New System.Drawing.Point(12, 51)
        Me.Full_Name.Name = "Full_Name"
        Me.Full_Name.Size = New System.Drawing.Size(314, 69)
        Me.Full_Name.TabIndex = 3
        Me.Full_Name.Text = "Full Name"
        '
        'Welcome
        '
        Me.Welcome.AutoSize = True
        Me.Welcome.Font = New System.Drawing.Font("Typo Formal Demo", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome.ForeColor = System.Drawing.Color.DimGray
        Me.Welcome.Location = New System.Drawing.Point(12, 9)
        Me.Welcome.Name = "Welcome"
        Me.Welcome.Size = New System.Drawing.Size(150, 42)
        Me.Welcome.TabIndex = 4
        Me.Welcome.Text = "Welcome,"
        '
        'Illustrator1
        '
        Me.Illustrator1.BackgroundImage = CType(resources.GetObject("Illustrator1.BackgroundImage"), System.Drawing.Image)
        Me.Illustrator1.Location = New System.Drawing.Point(53, 404)
        Me.Illustrator1.Name = "Illustrator1"
        Me.Illustrator1.Size = New System.Drawing.Size(537, 331)
        Me.Illustrator1.TabIndex = 5
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(53, 164)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(776, 198)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(639, 557)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 116)
        Me.TextBox1.TabIndex = 7
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(880, 645)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Illustrator1)
        Me.Controls.Add(Me.Welcome)
        Me.Controls.Add(Me.Full_Name)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Overview"
        Me.Text = "Overview"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Full_Name As Label
    Friend WithEvents Welcome As Label
    Friend WithEvents Illustrator1 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TextBox1 As TextBox
End Class
