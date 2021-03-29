<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMI_Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMI_Calculator))
        Me.ButtonImperial = New System.Windows.Forms.Button()
        Me.ButtonMetric = New System.Windows.Forms.Button()
        Me.TextBoxHeight = New System.Windows.Forms.TextBox()
        Me.TextBoxWeight = New System.Windows.Forms.TextBox()
        Me.TextBoxBMI = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.TextBoxUnitHeight = New System.Windows.Forms.TextBox()
        Me.TextBoxUnitWeight = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalorieCounterNav = New System.Windows.Forms.Button()
        Me.PageLabel = New System.Windows.Forms.Label()
        Me.DiaryNav = New System.Windows.Forms.Button()
        Me.LogoutNav = New System.Windows.Forms.Button()
        Me.StatisticsNav = New System.Windows.Forms.Button()
        Me.BMICalculatorNav = New System.Windows.Forms.Button()
        Me.LabelHeight = New System.Windows.Forms.Label()
        Me.LabelWeight = New System.Windows.Forms.Label()
        Me.TextBoxHeight1 = New System.Windows.Forms.TextBox()
        Me.TextBoxWeight1 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnitHeight1 = New System.Windows.Forms.TextBox()
        Me.TextBoxUnitWeight1 = New System.Windows.Forms.TextBox()
        Me.LabelHeightError = New System.Windows.Forms.Label()
        Me.LabelWeightError = New System.Windows.Forms.Label()
        Me.LabelBMIError = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonImperial
        '
        Me.ButtonImperial.BackColor = System.Drawing.Color.Red
        Me.ButtonImperial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonImperial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonImperial.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImperial.ForeColor = System.Drawing.Color.White
        Me.ButtonImperial.Location = New System.Drawing.Point(360, 79)
        Me.ButtonImperial.Name = "ButtonImperial"
        Me.ButtonImperial.Size = New System.Drawing.Size(124, 44)
        Me.ButtonImperial.TabIndex = 23
        Me.ButtonImperial.Text = "Imperial"
        Me.ButtonImperial.UseVisualStyleBackColor = False
        '
        'ButtonMetric
        '
        Me.ButtonMetric.BackColor = System.Drawing.Color.Green
        Me.ButtonMetric.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonMetric.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonMetric.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMetric.ForeColor = System.Drawing.Color.White
        Me.ButtonMetric.Location = New System.Drawing.Point(220, 79)
        Me.ButtonMetric.Name = "ButtonMetric"
        Me.ButtonMetric.Size = New System.Drawing.Size(124, 44)
        Me.ButtonMetric.TabIndex = 24
        Me.ButtonMetric.Text = "Metric"
        Me.ButtonMetric.UseVisualStyleBackColor = False
        '
        'TextBoxHeight
        '
        Me.TextBoxHeight.Location = New System.Drawing.Point(220, 178)
        Me.TextBoxHeight.Name = "TextBoxHeight"
        Me.TextBoxHeight.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxHeight.TabIndex = 25
        '
        'TextBoxWeight
        '
        Me.TextBoxWeight.Location = New System.Drawing.Point(220, 247)
        Me.TextBoxWeight.Name = "TextBoxWeight"
        Me.TextBoxWeight.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxWeight.TabIndex = 26
        '
        'TextBoxBMI
        '
        Me.TextBoxBMI.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxBMI.Location = New System.Drawing.Point(220, 360)
        Me.TextBoxBMI.Multiline = True
        Me.TextBoxBMI.Name = "TextBoxBMI"
        Me.TextBoxBMI.ReadOnly = True
        Me.TextBoxBMI.Size = New System.Drawing.Size(265, 65)
        Me.TextBoxBMI.TabIndex = 27
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonCalculate.FlatAppearance.BorderSize = 2
        Me.ButtonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCalculate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCalculate.ForeColor = System.Drawing.Color.White
        Me.ButtonCalculate.Location = New System.Drawing.Point(295, 311)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(111, 34)
        Me.ButtonCalculate.TabIndex = 28
        Me.ButtonCalculate.Text = "Calculate"
        Me.ButtonCalculate.UseVisualStyleBackColor = False
        '
        'TextBoxUnitHeight
        '
        Me.TextBoxUnitHeight.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnitHeight.Location = New System.Drawing.Point(309, 178)
        Me.TextBoxUnitHeight.Name = "TextBoxUnitHeight"
        Me.TextBoxUnitHeight.ReadOnly = True
        Me.TextBoxUnitHeight.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxUnitHeight.TabIndex = 29
        Me.TextBoxUnitHeight.Text = "cm"
        '
        'TextBoxUnitWeight
        '
        Me.TextBoxUnitWeight.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnitWeight.Location = New System.Drawing.Point(309, 247)
        Me.TextBoxUnitWeight.Name = "TextBoxUnitWeight"
        Me.TextBoxUnitWeight.ReadOnly = True
        Me.TextBoxUnitWeight.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxUnitWeight.TabIndex = 30
        Me.TextBoxUnitWeight.Text = "kg"
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
        Me.Panel1.TabIndex = 31
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
        Me.PageLabel.Size = New System.Drawing.Size(189, 35)
        Me.PageLabel.TabIndex = 22
        Me.PageLabel.Text = "BMI Calculator"
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
        'LabelHeight
        '
        Me.LabelHeight.AutoSize = True
        Me.LabelHeight.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeight.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelHeight.ForeColor = System.Drawing.Color.Blue
        Me.LabelHeight.Location = New System.Drawing.Point(216, 156)
        Me.LabelHeight.Name = "LabelHeight"
        Me.LabelHeight.Size = New System.Drawing.Size(205, 19)
        Me.LabelHeight.TabIndex = 34
        Me.LabelHeight.Text = "Please enter your height here:"
        '
        'LabelWeight
        '
        Me.LabelWeight.AutoSize = True
        Me.LabelWeight.BackColor = System.Drawing.Color.Transparent
        Me.LabelWeight.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelWeight.ForeColor = System.Drawing.Color.Blue
        Me.LabelWeight.Location = New System.Drawing.Point(216, 225)
        Me.LabelWeight.Name = "LabelWeight"
        Me.LabelWeight.Size = New System.Drawing.Size(206, 19)
        Me.LabelWeight.TabIndex = 35
        Me.LabelWeight.Text = "Please enter your weight here:"
        '
        'TextBoxHeight1
        '
        Me.TextBoxHeight1.Location = New System.Drawing.Point(361, 178)
        Me.TextBoxHeight1.Name = "TextBoxHeight1"
        Me.TextBoxHeight1.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxHeight1.TabIndex = 36
        '
        'TextBoxWeight1
        '
        Me.TextBoxWeight1.Location = New System.Drawing.Point(361, 247)
        Me.TextBoxWeight1.Name = "TextBoxWeight1"
        Me.TextBoxWeight1.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxWeight1.TabIndex = 37
        '
        'TextBoxUnitHeight1
        '
        Me.TextBoxUnitHeight1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnitHeight1.Location = New System.Drawing.Point(449, 178)
        Me.TextBoxUnitHeight1.Name = "TextBoxUnitHeight1"
        Me.TextBoxUnitHeight1.ReadOnly = True
        Me.TextBoxUnitHeight1.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxUnitHeight1.TabIndex = 38
        Me.TextBoxUnitHeight1.Text = "ins"
        '
        'TextBoxUnitWeight1
        '
        Me.TextBoxUnitWeight1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxUnitWeight1.Location = New System.Drawing.Point(449, 247)
        Me.TextBoxUnitWeight1.Name = "TextBoxUnitWeight1"
        Me.TextBoxUnitWeight1.ReadOnly = True
        Me.TextBoxUnitWeight1.Size = New System.Drawing.Size(35, 20)
        Me.TextBoxUnitWeight1.TabIndex = 39
        Me.TextBoxUnitWeight1.Text = "lbs"
        '
        'LabelHeightError
        '
        Me.LabelHeightError.AutoSize = True
        Me.LabelHeightError.BackColor = System.Drawing.Color.Transparent
        Me.LabelHeightError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelHeightError.ForeColor = System.Drawing.Color.Red
        Me.LabelHeightError.Location = New System.Drawing.Point(216, 201)
        Me.LabelHeightError.Name = "LabelHeightError"
        Me.LabelHeightError.Size = New System.Drawing.Size(0, 19)
        Me.LabelHeightError.TabIndex = 44
        '
        'LabelWeightError
        '
        Me.LabelWeightError.AutoSize = True
        Me.LabelWeightError.BackColor = System.Drawing.Color.Transparent
        Me.LabelWeightError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelWeightError.ForeColor = System.Drawing.Color.Red
        Me.LabelWeightError.Location = New System.Drawing.Point(216, 270)
        Me.LabelWeightError.Name = "LabelWeightError"
        Me.LabelWeightError.Size = New System.Drawing.Size(0, 19)
        Me.LabelWeightError.TabIndex = 45
        '
        'LabelBMIError
        '
        Me.LabelBMIError.AutoSize = True
        Me.LabelBMIError.BackColor = System.Drawing.Color.Transparent
        Me.LabelBMIError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelBMIError.ForeColor = System.Drawing.Color.Red
        Me.LabelBMIError.Location = New System.Drawing.Point(216, 137)
        Me.LabelBMIError.Name = "LabelBMIError"
        Me.LabelBMIError.Size = New System.Drawing.Size(0, 19)
        Me.LabelBMIError.TabIndex = 46
        '
        'BMI_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.LabelBMIError)
        Me.Controls.Add(Me.LabelWeightError)
        Me.Controls.Add(Me.LabelHeightError)
        Me.Controls.Add(Me.ButtonImperial)
        Me.Controls.Add(Me.TextBoxUnitWeight1)
        Me.Controls.Add(Me.TextBoxUnitHeight1)
        Me.Controls.Add(Me.TextBoxWeight1)
        Me.Controls.Add(Me.TextBoxHeight1)
        Me.Controls.Add(Me.LabelWeight)
        Me.Controls.Add(Me.LabelHeight)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBoxUnitWeight)
        Me.Controls.Add(Me.TextBoxUnitHeight)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.TextBoxBMI)
        Me.Controls.Add(Me.TextBoxWeight)
        Me.Controls.Add(Me.TextBoxHeight)
        Me.Controls.Add(Me.ButtonMetric)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "BMI_Calculator"
        Me.Text = "The Health App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonImperial As Button
    Friend WithEvents ButtonMetric As Button
    Friend WithEvents TextBoxHeight As TextBox
    Friend WithEvents TextBoxWeight As TextBox
    Friend WithEvents TextBoxBMI As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents TextBoxUnitHeight As TextBox
    Friend WithEvents TextBoxUnitWeight As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CalorieCounterNav As Button
    Friend WithEvents PageLabel As Label
    Friend WithEvents DiaryNav As Button
    Friend WithEvents LogoutNav As Button
    Friend WithEvents StatisticsNav As Button
    Friend WithEvents BMICalculatorNav As Button
    Friend WithEvents LabelHeight As Label
    Friend WithEvents LabelWeight As Label
    Friend WithEvents TextBoxHeight1 As TextBox
    Friend WithEvents TextBoxWeight1 As TextBox
    Friend WithEvents TextBoxUnitHeight1 As TextBox
    Friend WithEvents TextBoxUnitWeight1 As TextBox
    Friend WithEvents LabelHeightError As Label
    Friend WithEvents LabelWeightError As Label
    Friend WithEvents LabelBMIError As Label
End Class
