<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistics))
        Me.TextBoxAverage = New System.Windows.Forms.TextBox()
        Me.TextBoxHighest = New System.Windows.Forms.TextBox()
        Me.TextBoxLowest = New System.Windows.Forms.TextBox()
        Me.ButtonMetric = New System.Windows.Forms.Button()
        Me.ButtonImperial = New System.Windows.Forms.Button()
        Me.TextBoxUnit1 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit2 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalorieCounterNav = New System.Windows.Forms.Button()
        Me.PageLabel = New System.Windows.Forms.Label()
        Me.DiaryNav = New System.Windows.Forms.Button()
        Me.LogoutNav = New System.Windows.Forms.Button()
        Me.StatisticsNav = New System.Windows.Forms.Button()
        Me.BMICalculatorNav = New System.Windows.Forms.Button()
        Me.LabelAverage = New System.Windows.Forms.Label()
        Me.LabelHighest = New System.Windows.Forms.Label()
        Me.LabelLowest = New System.Windows.Forms.Label()
        Me.TextBoxAverage1 = New System.Windows.Forms.TextBox()
        Me.TextBoxHighest1 = New System.Windows.Forms.TextBox()
        Me.TextBoxLowest1 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit4 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit5 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnit6 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxAverage
        '
        Me.TextBoxAverage.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxAverage.Location = New System.Drawing.Point(231, 201)
        Me.TextBoxAverage.Name = "TextBoxAverage"
        Me.TextBoxAverage.ReadOnly = True
        Me.TextBoxAverage.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxAverage.TabIndex = 23
        '
        'TextBoxHighest
        '
        Me.TextBoxHighest.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxHighest.Location = New System.Drawing.Point(231, 272)
        Me.TextBoxHighest.Name = "TextBoxHighest"
        Me.TextBoxHighest.ReadOnly = True
        Me.TextBoxHighest.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxHighest.TabIndex = 24
        '
        'TextBoxLowest
        '
        Me.TextBoxLowest.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxLowest.Location = New System.Drawing.Point(231, 336)
        Me.TextBoxLowest.Name = "TextBoxLowest"
        Me.TextBoxLowest.ReadOnly = True
        Me.TextBoxLowest.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxLowest.TabIndex = 25
        '
        'ButtonMetric
        '
        Me.ButtonMetric.BackColor = System.Drawing.Color.Green
        Me.ButtonMetric.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonMetric.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonMetric.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonMetric.ForeColor = System.Drawing.Color.White
        Me.ButtonMetric.Location = New System.Drawing.Point(231, 98)
        Me.ButtonMetric.Name = "ButtonMetric"
        Me.ButtonMetric.Size = New System.Drawing.Size(124, 44)
        Me.ButtonMetric.TabIndex = 28
        Me.ButtonMetric.Text = "Metric"
        Me.ButtonMetric.UseVisualStyleBackColor = False
        '
        'ButtonImperial
        '
        Me.ButtonImperial.BackColor = System.Drawing.Color.Red
        Me.ButtonImperial.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonImperial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImperial.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonImperial.ForeColor = System.Drawing.Color.White
        Me.ButtonImperial.Location = New System.Drawing.Point(374, 98)
        Me.ButtonImperial.Name = "ButtonImperial"
        Me.ButtonImperial.Size = New System.Drawing.Size(124, 44)
        Me.ButtonImperial.TabIndex = 27
        Me.ButtonImperial.Text = "Imperial"
        Me.ButtonImperial.UseVisualStyleBackColor = False
        '
        'TextBoxUnit1
        '
        Me.TextBoxUnit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit1.Location = New System.Drawing.Point(338, 201)
        Me.TextBoxUnit1.Name = "TextBoxUnit1"
        Me.TextBoxUnit1.ReadOnly = True
        Me.TextBoxUnit1.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit1.TabIndex = 29
        Me.TextBoxUnit1.Text = "kg"
        '
        'TextBoxUnit2
        '
        Me.TextBoxUnit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit2.Location = New System.Drawing.Point(338, 272)
        Me.TextBoxUnit2.Name = "TextBoxUnit2"
        Me.TextBoxUnit2.ReadOnly = True
        Me.TextBoxUnit2.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit2.TabIndex = 30
        Me.TextBoxUnit2.Text = "kg"
        '
        'TextBoxUnit3
        '
        Me.TextBoxUnit3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit3.Location = New System.Drawing.Point(338, 336)
        Me.TextBoxUnit3.Name = "TextBoxUnit3"
        Me.TextBoxUnit3.ReadOnly = True
        Me.TextBoxUnit3.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit3.TabIndex = 31
        Me.TextBoxUnit3.Text = "kg"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.CalorieCounterNav)
        Me.Panel1.Controls.Add(Me.PageLabel)
        Me.Panel1.Controls.Add(Me.DiaryNav)
        Me.Panel1.Controls.Add(Me.LogoutNav)
        Me.Panel1.Controls.Add(Me.StatisticsNav)
        Me.Panel1.Controls.Add(Me.BMICalculatorNav)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 46)
        Me.Panel1.TabIndex = 32
        '
        'CalorieCounterNav
        '
        Me.CalorieCounterNav.BackColor = System.Drawing.Color.SteelBlue
        Me.CalorieCounterNav.FlatAppearance.BorderSize = 0
        Me.CalorieCounterNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalorieCounterNav.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalorieCounterNav.ForeColor = System.Drawing.Color.White
        Me.CalorieCounterNav.Location = New System.Drawing.Point(205, 4)
        Me.CalorieCounterNav.Name = "CalorieCounterNav"
        Me.CalorieCounterNav.Size = New System.Drawing.Size(137, 35)
        Me.CalorieCounterNav.TabIndex = 17
        Me.CalorieCounterNav.Text = "Calorie Counter"
        Me.CalorieCounterNav.UseVisualStyleBackColor = False
        '
        'PageLabel
        '
        Me.PageLabel.AutoSize = True
        Me.PageLabel.BackColor = System.Drawing.Color.Transparent
        Me.PageLabel.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold)
        Me.PageLabel.ForeColor = System.Drawing.Color.Aqua
        Me.PageLabel.Location = New System.Drawing.Point(12, 0)
        Me.PageLabel.Name = "PageLabel"
        Me.PageLabel.Size = New System.Drawing.Size(128, 35)
        Me.PageLabel.TabIndex = 22
        Me.PageLabel.Text = "Statistics"
        '
        'DiaryNav
        '
        Me.DiaryNav.BackColor = System.Drawing.Color.SteelBlue
        Me.DiaryNav.FlatAppearance.BorderSize = 0
        Me.DiaryNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiaryNav.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaryNav.ForeColor = System.Drawing.Color.White
        Me.DiaryNav.Location = New System.Drawing.Point(491, 4)
        Me.DiaryNav.Name = "DiaryNav"
        Me.DiaryNav.Size = New System.Drawing.Size(75, 35)
        Me.DiaryNav.TabIndex = 19
        Me.DiaryNav.Text = "Diary"
        Me.DiaryNav.UseVisualStyleBackColor = False
        '
        'LogoutNav
        '
        Me.LogoutNav.BackColor = System.Drawing.Color.SteelBlue
        Me.LogoutNav.FlatAppearance.BorderSize = 0
        Me.LogoutNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutNav.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutNav.ForeColor = System.Drawing.Color.White
        Me.LogoutNav.Location = New System.Drawing.Point(664, 4)
        Me.LogoutNav.Name = "LogoutNav"
        Me.LogoutNav.Size = New System.Drawing.Size(75, 35)
        Me.LogoutNav.TabIndex = 21
        Me.LogoutNav.Text = "Logout"
        Me.LogoutNav.UseVisualStyleBackColor = False
        '
        'StatisticsNav
        '
        Me.StatisticsNav.BackColor = System.Drawing.Color.SteelBlue
        Me.StatisticsNav.FlatAppearance.BorderSize = 0
        Me.StatisticsNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatisticsNav.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatisticsNav.ForeColor = System.Drawing.Color.White
        Me.StatisticsNav.Location = New System.Drawing.Point(572, 4)
        Me.StatisticsNav.Name = "StatisticsNav"
        Me.StatisticsNav.Size = New System.Drawing.Size(86, 35)
        Me.StatisticsNav.TabIndex = 20
        Me.StatisticsNav.Text = "Statistics"
        Me.StatisticsNav.UseVisualStyleBackColor = False
        '
        'BMICalculatorNav
        '
        Me.BMICalculatorNav.BackColor = System.Drawing.Color.SteelBlue
        Me.BMICalculatorNav.FlatAppearance.BorderSize = 0
        Me.BMICalculatorNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMICalculatorNav.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMICalculatorNav.ForeColor = System.Drawing.Color.White
        Me.BMICalculatorNav.Location = New System.Drawing.Point(348, 4)
        Me.BMICalculatorNav.Name = "BMICalculatorNav"
        Me.BMICalculatorNav.Size = New System.Drawing.Size(137, 35)
        Me.BMICalculatorNav.TabIndex = 18
        Me.BMICalculatorNav.Text = "BMI Calculator"
        Me.BMICalculatorNav.UseVisualStyleBackColor = False
        '
        'LabelAverage
        '
        Me.LabelAverage.AutoSize = True
        Me.LabelAverage.BackColor = System.Drawing.Color.Transparent
        Me.LabelAverage.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelAverage.ForeColor = System.Drawing.Color.Blue
        Me.LabelAverage.Location = New System.Drawing.Point(227, 170)
        Me.LabelAverage.Name = "LabelAverage"
        Me.LabelAverage.Size = New System.Drawing.Size(258, 19)
        Me.LabelAverage.TabIndex = 41
        Me.LabelAverage.Text = "The average weight among all users is:"
        '
        'LabelHighest
        '
        Me.LabelHighest.AutoSize = True
        Me.LabelHighest.BackColor = System.Drawing.Color.Transparent
        Me.LabelHighest.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelHighest.ForeColor = System.Drawing.Color.Blue
        Me.LabelHighest.Location = New System.Drawing.Point(227, 241)
        Me.LabelHighest.Name = "LabelHighest"
        Me.LabelHighest.Size = New System.Drawing.Size(257, 19)
        Me.LabelHighest.TabIndex = 42
        Me.LabelHighest.Text = "The highest weight among all users is:"
        '
        'LabelLowest
        '
        Me.LabelLowest.AutoSize = True
        Me.LabelLowest.BackColor = System.Drawing.Color.Transparent
        Me.LabelLowest.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelLowest.ForeColor = System.Drawing.Color.Blue
        Me.LabelLowest.Location = New System.Drawing.Point(227, 310)
        Me.LabelLowest.Name = "LabelLowest"
        Me.LabelLowest.Size = New System.Drawing.Size(250, 19)
        Me.LabelLowest.TabIndex = 43
        Me.LabelLowest.Text = "The lowest weight among all users is:"
        '
        'TextBoxAverage1
        '
        Me.TextBoxAverage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxAverage1.Location = New System.Drawing.Point(374, 201)
        Me.TextBoxAverage1.Name = "TextBoxAverage1"
        Me.TextBoxAverage1.ReadOnly = True
        Me.TextBoxAverage1.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxAverage1.TabIndex = 44
        '
        'TextBoxHighest1
        '
        Me.TextBoxHighest1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxHighest1.Location = New System.Drawing.Point(374, 272)
        Me.TextBoxHighest1.Name = "TextBoxHighest1"
        Me.TextBoxHighest1.ReadOnly = True
        Me.TextBoxHighest1.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxHighest1.TabIndex = 45
        '
        'TextBoxLowest1
        '
        Me.TextBoxLowest1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxLowest1.Location = New System.Drawing.Point(374, 336)
        Me.TextBoxLowest1.Name = "TextBoxLowest1"
        Me.TextBoxLowest1.ReadOnly = True
        Me.TextBoxLowest1.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxLowest1.TabIndex = 46
        '
        'TextBoxUnit4
        '
        Me.TextBoxUnit4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit4.Location = New System.Drawing.Point(468, 201)
        Me.TextBoxUnit4.Name = "TextBoxUnit4"
        Me.TextBoxUnit4.ReadOnly = True
        Me.TextBoxUnit4.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit4.TabIndex = 47
        Me.TextBoxUnit4.Text = "lb"
        '
        'TextBoxUnit5
        '
        Me.TextBoxUnit5.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit5.Location = New System.Drawing.Point(468, 272)
        Me.TextBoxUnit5.Name = "TextBoxUnit5"
        Me.TextBoxUnit5.ReadOnly = True
        Me.TextBoxUnit5.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit5.TabIndex = 48
        Me.TextBoxUnit5.Text = "lb"
        '
        'TextBoxUnit6
        '
        Me.TextBoxUnit6.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnit6.Location = New System.Drawing.Point(468, 336)
        Me.TextBoxUnit6.Name = "TextBoxUnit6"
        Me.TextBoxUnit6.ReadOnly = True
        Me.TextBoxUnit6.Size = New System.Drawing.Size(30, 20)
        Me.TextBoxUnit6.TabIndex = 49
        Me.TextBoxUnit6.Text = "lb"
        '
        'Statistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.TextBoxUnit6)
        Me.Controls.Add(Me.TextBoxUnit5)
        Me.Controls.Add(Me.TextBoxUnit4)
        Me.Controls.Add(Me.TextBoxLowest1)
        Me.Controls.Add(Me.TextBoxHighest1)
        Me.Controls.Add(Me.TextBoxAverage1)
        Me.Controls.Add(Me.LabelLowest)
        Me.Controls.Add(Me.LabelHighest)
        Me.Controls.Add(Me.LabelAverage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxUnit3)
        Me.Controls.Add(Me.TextBoxUnit2)
        Me.Controls.Add(Me.TextBoxUnit1)
        Me.Controls.Add(Me.ButtonMetric)
        Me.Controls.Add(Me.ButtonImperial)
        Me.Controls.Add(Me.TextBoxLowest)
        Me.Controls.Add(Me.TextBoxHighest)
        Me.Controls.Add(Me.TextBoxAverage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "Statistics"
        Me.Text = "The Health App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxAverage As TextBox
    Friend WithEvents TextBoxHighest As TextBox
    Friend WithEvents TextBoxLowest As TextBox
    Friend WithEvents ButtonMetric As Button
    Friend WithEvents ButtonImperial As Button
    Friend WithEvents TextBoxUnit1 As TextBox
    Friend WithEvents TextBoxUnit2 As TextBox
    Friend WithEvents TextBoxUnit3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CalorieCounterNav As Button
    Friend WithEvents PageLabel As Label
    Friend WithEvents DiaryNav As Button
    Friend WithEvents LogoutNav As Button
    Friend WithEvents StatisticsNav As Button
    Friend WithEvents BMICalculatorNav As Button
    Friend WithEvents LabelAverage As Label
    Friend WithEvents LabelHighest As Label
    Friend WithEvents LabelLowest As Label
    Friend WithEvents TextBoxAverage1 As TextBox
    Friend WithEvents TextBoxHighest1 As TextBox
    Friend WithEvents TextBoxLowest1 As TextBox
    Friend WithEvents TextBoxUnit4 As TextBox
    Friend WithEvents TextBoxUnit5 As TextBox
    Friend WithEvents TextBoxUnit6 As TextBox
End Class
