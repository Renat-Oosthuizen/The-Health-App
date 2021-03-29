<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calorie_Counter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calorie_Counter))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalorieCounterNav = New System.Windows.Forms.Button()
        Me.PageLabel = New System.Windows.Forms.Label()
        Me.DiaryNav = New System.Windows.Forms.Button()
        Me.LogoutNav = New System.Windows.Forms.Button()
        Me.StatisticsNav = New System.Windows.Forms.Button()
        Me.BMICalculatorNav = New System.Windows.Forms.Button()
        Me.TextBoxApples = New System.Windows.Forms.TextBox()
        Me.TextBoxBurgers = New System.Windows.Forms.TextBox()
        Me.TextBoxMarsBars = New System.Windows.Forms.TextBox()
        Me.TextBoxAnswer = New System.Windows.Forms.TextBox()
        Me.TextBoxPizzas = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelInstructions = New System.Windows.Forms.Label()
        Me.LabelCalorieError = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button6.FlatAppearance.BorderSize = 2
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(305, 240)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 33)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Submit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(305, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 22)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(305, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 22)
        Me.TextBox3.TabIndex = 14
        Me.TextBox3.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(305, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(37, 22)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "0"
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
        Me.PageLabel.Size = New System.Drawing.Size(194, 35)
        Me.PageLabel.TabIndex = 22
        Me.PageLabel.Text = "Calorie Counter"
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
        'TextBoxApples
        '
        Me.TextBoxApples.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxApples.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxApples.Location = New System.Drawing.Point(183, 87)
        Me.TextBoxApples.Multiline = True
        Me.TextBoxApples.Name = "TextBoxApples"
        Me.TextBoxApples.ReadOnly = True
        Me.TextBoxApples.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxApples.TabIndex = 36
        Me.TextBoxApples.Text = "Apples (182g):"
        '
        'TextBoxBurgers
        '
        Me.TextBoxBurgers.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBurgers.Location = New System.Drawing.Point(183, 142)
        Me.TextBoxBurgers.Multiline = True
        Me.TextBoxBurgers.Name = "TextBoxBurgers"
        Me.TextBoxBurgers.ReadOnly = True
        Me.TextBoxBurgers.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxBurgers.TabIndex = 37
        Me.TextBoxBurgers.Text = "Burgers (120g):"
        '
        'TextBoxMarsBars
        '
        Me.TextBoxMarsBars.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxMarsBars.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMarsBars.Location = New System.Drawing.Point(183, 115)
        Me.TextBoxMarsBars.Multiline = True
        Me.TextBoxMarsBars.Name = "TextBoxMarsBars"
        Me.TextBoxMarsBars.ReadOnly = True
        Me.TextBoxMarsBars.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxMarsBars.TabIndex = 38
        Me.TextBoxMarsBars.Text = "Mars Bars (51g):"
        '
        'TextBoxAnswer
        '
        Me.TextBoxAnswer.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxAnswer.Location = New System.Drawing.Point(191, 279)
        Me.TextBoxAnswer.Multiline = True
        Me.TextBoxAnswer.Name = "TextBoxAnswer"
        Me.TextBoxAnswer.ReadOnly = True
        Me.TextBoxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAnswer.Size = New System.Drawing.Size(339, 129)
        Me.TextBoxAnswer.TabIndex = 39
        '
        'TextBoxPizzas
        '
        Me.TextBoxPizzas.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxPizzas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPizzas.Location = New System.Drawing.Point(183, 170)
        Me.TextBoxPizzas.Multiline = True
        Me.TextBoxPizzas.Name = "TextBoxPizzas"
        Me.TextBoxPizzas.ReadOnly = True
        Me.TextBoxPizzas.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxPizzas.TabIndex = 40
        Me.TextBoxPizzas.Text = "Pizza Slices (107g):"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(305, 170)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(37, 22)
        Me.TextBox4.TabIndex = 41
        Me.TextBox4.Text = "0"
        '
        'LabelInstructions
        '
        Me.LabelInstructions.BackColor = System.Drawing.Color.Transparent
        Me.LabelInstructions.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelInstructions.ForeColor = System.Drawing.Color.Blue
        Me.LabelInstructions.Location = New System.Drawing.Point(348, 87)
        Me.LabelInstructions.Name = "LabelInstructions"
        Me.LabelInstructions.Size = New System.Drawing.Size(343, 105)
        Me.LabelInstructions.TabIndex = 42
        Me.LabelInstructions.Text = "Please pick how many of each food item you ate today and we will calculate their " &
    "total calorie content:"
        '
        'LabelCalorieError
        '
        Me.LabelCalorieError.AutoSize = True
        Me.LabelCalorieError.BackColor = System.Drawing.Color.Transparent
        Me.LabelCalorieError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelCalorieError.ForeColor = System.Drawing.Color.Red
        Me.LabelCalorieError.Location = New System.Drawing.Point(179, 195)
        Me.LabelCalorieError.Name = "LabelCalorieError"
        Me.LabelCalorieError.Size = New System.Drawing.Size(0, 19)
        Me.LabelCalorieError.TabIndex = 43
        '
        'Calorie_Counter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.LabelCalorieError)
        Me.Controls.Add(Me.LabelInstructions)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBoxPizzas)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxAnswer)
        Me.Controls.Add(Me.TextBoxMarsBars)
        Me.Controls.Add(Me.TextBoxBurgers)
        Me.Controls.Add(Me.TextBoxApples)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "Calorie_Counter"
        Me.Text = "The Health App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CalorieCounterNav As Button
    Friend WithEvents PageLabel As Label
    Friend WithEvents DiaryNav As Button
    Friend WithEvents LogoutNav As Button
    Friend WithEvents StatisticsNav As Button
    Friend WithEvents BMICalculatorNav As Button
    Friend WithEvents TextBoxApples As TextBox
    Friend WithEvents TextBoxBurgers As TextBox
    Friend WithEvents TextBoxMarsBars As TextBox
    Friend WithEvents TextBoxAnswer As TextBox
    Friend WithEvents TextBoxPizzas As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LabelInstructions As Label
    Friend WithEvents LabelCalorieError As Label
End Class
