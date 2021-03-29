<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Diary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Diary))
        Me.TextBoxOld = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxNew = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CalorieCounterNav = New System.Windows.Forms.Button()
        Me.PageLabel = New System.Windows.Forms.Label()
        Me.DiaryNav = New System.Windows.Forms.Button()
        Me.LogoutNav = New System.Windows.Forms.Button()
        Me.StatisticsNav = New System.Windows.Forms.Button()
        Me.BMICalculatorNav = New System.Windows.Forms.Button()
        Me.ButtonMode = New System.Windows.Forms.Button()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.LabelPageNumber = New System.Windows.Forms.Label()
        Me.LabelDiaryError = New System.Windows.Forms.Label()
        Me.LabelMode = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxOld
        '
        Me.TextBoxOld.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBoxOld.Location = New System.Drawing.Point(212, 286)
        Me.TextBoxOld.Multiline = True
        Me.TextBoxOld.Name = "TextBoxOld"
        Me.TextBoxOld.ReadOnly = True
        Me.TextBoxOld.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxOld.Size = New System.Drawing.Size(250, 143)
        Me.TextBoxOld.TabIndex = 23
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonSave.FlatAppearance.BorderSize = 2
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(212, 215)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(112, 32)
        Me.ButtonSave.TabIndex = 24
        Me.ButtonSave.Text = "Create Entry"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'TextBoxNew
        '
        Me.TextBoxNew.Location = New System.Drawing.Point(212, 66)
        Me.TextBoxNew.Multiline = True
        Me.TextBoxNew.Name = "TextBoxNew"
        Me.TextBoxNew.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxNew.Size = New System.Drawing.Size(250, 143)
        Me.TextBoxNew.TabIndex = 25
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
        Me.PageLabel.Size = New System.Drawing.Size(77, 35)
        Me.PageLabel.TabIndex = 22
        Me.PageLabel.Text = "Diary"
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
        'ButtonMode
        '
        Me.ButtonMode.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonMode.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonMode.FlatAppearance.BorderSize = 2
        Me.ButtonMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMode.ForeColor = System.Drawing.Color.White
        Me.ButtonMode.Location = New System.Drawing.Point(468, 66)
        Me.ButtonMode.Name = "ButtonMode"
        Me.ButtonMode.Size = New System.Drawing.Size(196, 32)
        Me.ButtonMode.TabIndex = 35
        Me.ButtonMode.Text = "Switch to Edit Mode"
        Me.ButtonMode.UseVisualStyleBackColor = False
        '
        'ButtonDown
        '
        Me.ButtonDown.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonDown.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonDown.FlatAppearance.BorderSize = 2
        Me.ButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDown.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDown.ForeColor = System.Drawing.Color.White
        Me.ButtonDown.Location = New System.Drawing.Point(123, 177)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(83, 32)
        Me.ButtonDown.TabIndex = 36
        Me.ButtonDown.Text = "Down"
        Me.ButtonDown.UseVisualStyleBackColor = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonDelete.FlatAppearance.BorderSize = 2
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(348, 215)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(112, 32)
        Me.ButtonDelete.TabIndex = 37
        Me.ButtonDelete.Text = "Delete Entry"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonUp
        '
        Me.ButtonUp.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonUp.FlatAppearance.BorderSize = 2
        Me.ButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUp.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUp.ForeColor = System.Drawing.Color.White
        Me.ButtonUp.Location = New System.Drawing.Point(123, 99)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(83, 32)
        Me.ButtonUp.TabIndex = 38
        Me.ButtonUp.Text = "Up"
        Me.ButtonUp.UseVisualStyleBackColor = False
        '
        'LabelPageNumber
        '
        Me.LabelPageNumber.AutoSize = True
        Me.LabelPageNumber.BackColor = System.Drawing.Color.SteelBlue
        Me.LabelPageNumber.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPageNumber.ForeColor = System.Drawing.Color.White
        Me.LabelPageNumber.Location = New System.Drawing.Point(158, 146)
        Me.LabelPageNumber.Name = "LabelPageNumber"
        Me.LabelPageNumber.Size = New System.Drawing.Size(48, 19)
        Me.LabelPageNumber.TabIndex = 39
        Me.LabelPageNumber.Text = "10/10"
        '
        'LabelDiaryError
        '
        Me.LabelDiaryError.AutoSize = True
        Me.LabelDiaryError.BackColor = System.Drawing.Color.Transparent
        Me.LabelDiaryError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelDiaryError.ForeColor = System.Drawing.Color.Red
        Me.LabelDiaryError.Location = New System.Drawing.Point(208, 250)
        Me.LabelDiaryError.Name = "LabelDiaryError"
        Me.LabelDiaryError.Size = New System.Drawing.Size(0, 19)
        Me.LabelDiaryError.TabIndex = 40
        '
        'LabelMode
        '
        Me.LabelMode.BackColor = System.Drawing.Color.Transparent
        Me.LabelMode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelMode.ForeColor = System.Drawing.Color.Blue
        Me.LabelMode.Location = New System.Drawing.Point(468, 118)
        Me.LabelMode.Name = "LabelMode"
        Me.LabelMode.Size = New System.Drawing.Size(233, 53)
        Me.LabelMode.TabIndex = 41
        Me.LabelMode.Text = "Currently in New Entry Mode. Plese submit a new entry."
        '
        'Diary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.LabelMode)
        Me.Controls.Add(Me.LabelDiaryError)
        Me.Controls.Add(Me.LabelPageNumber)
        Me.Controls.Add(Me.ButtonUp)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonDown)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonMode)
        Me.Controls.Add(Me.TextBoxNew)
        Me.Controls.Add(Me.TextBoxOld)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "Diary"
        Me.Text = "The Health App"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxOld As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxNew As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CalorieCounterNav As Button
    Friend WithEvents PageLabel As Label
    Friend WithEvents DiaryNav As Button
    Friend WithEvents LogoutNav As Button
    Friend WithEvents StatisticsNav As Button
    Friend WithEvents BMICalculatorNav As Button
    Friend WithEvents ButtonMode As Button
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUp As Button
    Friend WithEvents LabelPageNumber As Label
    Friend WithEvents LabelDiaryError As Label
    Friend WithEvents LabelMode As Label
End Class
