<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Password_Reset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password_Reset))
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelRepeatPassword = New System.Windows.Forms.Label()
        Me.TextBoxRepeatPassword = New System.Windows.Forms.TextBox()
        Me.ButtonResetPassword = New System.Windows.Forms.Button()
        Me.ButtonReturnLogin = New System.Windows.Forms.Button()
        Me.LabelResetCode = New System.Windows.Forms.Label()
        Me.TextBoxResetCode = New System.Windows.Forms.TextBox()
        Me.ButtonResetCode = New System.Windows.Forms.Button()
        Me.LabelUsernameError = New System.Windows.Forms.Label()
        Me.LabelResetError = New System.Windows.Forms.Label()
        Me.LabelPasswordError = New System.Windows.Forms.Label()
        Me.LabelRPasswordError = New System.Windows.Forms.Label()
        Me.ButtonShowPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.Blue
        Me.LabelUsername.Location = New System.Drawing.Point(243, 19)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(105, 19)
        Me.LabelUsername.TabIndex = 14
        Me.LabelUsername.Text = "Email Address:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(247, 41)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxUsername.TabIndex = 13
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Blue
        Me.LabelPassword.Location = New System.Drawing.Point(244, 225)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(104, 19)
        Me.LabelPassword.TabIndex = 16
        Me.LabelPassword.Text = "New Password:"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(248, 247)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxPassword.TabIndex = 15
        '
        'LabelRepeatPassword
        '
        Me.LabelRepeatPassword.AutoSize = True
        Me.LabelRepeatPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelRepeatPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRepeatPassword.ForeColor = System.Drawing.Color.Blue
        Me.LabelRepeatPassword.Location = New System.Drawing.Point(244, 289)
        Me.LabelRepeatPassword.Name = "LabelRepeatPassword"
        Me.LabelRepeatPassword.Size = New System.Drawing.Size(126, 19)
        Me.LabelRepeatPassword.TabIndex = 18
        Me.LabelRepeatPassword.Text = "Confirm Password:"
        '
        'TextBoxRepeatPassword
        '
        Me.TextBoxRepeatPassword.Location = New System.Drawing.Point(248, 311)
        Me.TextBoxRepeatPassword.Name = "TextBoxRepeatPassword"
        Me.TextBoxRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRepeatPassword.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxRepeatPassword.TabIndex = 17
        '
        'ButtonResetPassword
        '
        Me.ButtonResetPassword.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonResetPassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonResetPassword.FlatAppearance.BorderSize = 2
        Me.ButtonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResetPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResetPassword.ForeColor = System.Drawing.Color.White
        Me.ButtonResetPassword.Location = New System.Drawing.Point(248, 369)
        Me.ButtonResetPassword.Name = "ButtonResetPassword"
        Me.ButtonResetPassword.Size = New System.Drawing.Size(244, 32)
        Me.ButtonResetPassword.TabIndex = 19
        Me.ButtonResetPassword.Text = "Reset Password"
        Me.ButtonResetPassword.UseVisualStyleBackColor = False
        '
        'ButtonReturnLogin
        '
        Me.ButtonReturnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonReturnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonReturnLogin.FlatAppearance.BorderSize = 2
        Me.ButtonReturnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReturnLogin.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonReturnLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonReturnLogin.Location = New System.Drawing.Point(626, 393)
        Me.ButtonReturnLogin.Name = "ButtonReturnLogin"
        Me.ButtonReturnLogin.Size = New System.Drawing.Size(106, 45)
        Me.ButtonReturnLogin.TabIndex = 20
        Me.ButtonReturnLogin.Text = "Return to Login"
        Me.ButtonReturnLogin.UseVisualStyleBackColor = False
        '
        'LabelResetCode
        '
        Me.LabelResetCode.AutoSize = True
        Me.LabelResetCode.BackColor = System.Drawing.Color.Transparent
        Me.LabelResetCode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResetCode.ForeColor = System.Drawing.Color.Blue
        Me.LabelResetCode.Location = New System.Drawing.Point(244, 154)
        Me.LabelResetCode.Name = "LabelResetCode"
        Me.LabelResetCode.Size = New System.Drawing.Size(85, 19)
        Me.LabelResetCode.TabIndex = 22
        Me.LabelResetCode.Text = "Reset Code:"
        '
        'TextBoxResetCode
        '
        Me.TextBoxResetCode.Location = New System.Drawing.Point(248, 176)
        Me.TextBoxResetCode.Name = "TextBoxResetCode"
        Me.TextBoxResetCode.Size = New System.Drawing.Size(244, 20)
        Me.TextBoxResetCode.TabIndex = 21
        '
        'ButtonResetCode
        '
        Me.ButtonResetCode.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonResetCode.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonResetCode.FlatAppearance.BorderSize = 2
        Me.ButtonResetCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResetCode.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResetCode.ForeColor = System.Drawing.Color.White
        Me.ButtonResetCode.Location = New System.Drawing.Point(298, 99)
        Me.ButtonResetCode.Name = "ButtonResetCode"
        Me.ButtonResetCode.Size = New System.Drawing.Size(138, 32)
        Me.ButtonResetCode.TabIndex = 23
        Me.ButtonResetCode.Text = "Send Reset Code"
        Me.ButtonResetCode.UseVisualStyleBackColor = False
        '
        'LabelUsernameError
        '
        Me.LabelUsernameError.AutoSize = True
        Me.LabelUsernameError.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsernameError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelUsernameError.ForeColor = System.Drawing.Color.Red
        Me.LabelUsernameError.Location = New System.Drawing.Point(243, 64)
        Me.LabelUsernameError.Name = "LabelUsernameError"
        Me.LabelUsernameError.Size = New System.Drawing.Size(0, 19)
        Me.LabelUsernameError.TabIndex = 24
        '
        'LabelResetError
        '
        Me.LabelResetError.AutoSize = True
        Me.LabelResetError.BackColor = System.Drawing.Color.Transparent
        Me.LabelResetError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelResetError.ForeColor = System.Drawing.Color.Red
        Me.LabelResetError.Location = New System.Drawing.Point(244, 199)
        Me.LabelResetError.Name = "LabelResetError"
        Me.LabelResetError.Size = New System.Drawing.Size(0, 19)
        Me.LabelResetError.TabIndex = 25
        '
        'LabelPasswordError
        '
        Me.LabelPasswordError.AutoSize = True
        Me.LabelPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.LabelPasswordError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LabelPasswordError.Location = New System.Drawing.Point(244, 270)
        Me.LabelPasswordError.Name = "LabelPasswordError"
        Me.LabelPasswordError.Size = New System.Drawing.Size(0, 19)
        Me.LabelPasswordError.TabIndex = 26
        '
        'LabelRPasswordError
        '
        Me.LabelRPasswordError.AutoSize = True
        Me.LabelRPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.LabelRPasswordError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelRPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LabelRPasswordError.Location = New System.Drawing.Point(244, 334)
        Me.LabelRPasswordError.Name = "LabelRPasswordError"
        Me.LabelRPasswordError.Size = New System.Drawing.Size(0, 19)
        Me.LabelRPasswordError.TabIndex = 27
        '
        'ButtonShowPassword
        '
        Me.ButtonShowPassword.BackColor = System.Drawing.Color.LightGray
        Me.ButtonShowPassword.BackgroundImage = CType(resources.GetObject("ButtonShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowPassword.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowPassword.ForeColor = System.Drawing.Color.White
        Me.ButtonShowPassword.Location = New System.Drawing.Point(469, 247)
        Me.ButtonShowPassword.Name = "ButtonShowPassword"
        Me.ButtonShowPassword.Size = New System.Drawing.Size(23, 20)
        Me.ButtonShowPassword.TabIndex = 28
        Me.ButtonShowPassword.UseVisualStyleBackColor = False
        '
        'Password_Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.ButtonShowPassword)
        Me.Controls.Add(Me.LabelRPasswordError)
        Me.Controls.Add(Me.LabelPasswordError)
        Me.Controls.Add(Me.LabelResetError)
        Me.Controls.Add(Me.LabelUsernameError)
        Me.Controls.Add(Me.ButtonResetCode)
        Me.Controls.Add(Me.LabelResetCode)
        Me.Controls.Add(Me.TextBoxResetCode)
        Me.Controls.Add(Me.ButtonReturnLogin)
        Me.Controls.Add(Me.ButtonResetPassword)
        Me.Controls.Add(Me.LabelRepeatPassword)
        Me.Controls.Add(Me.TextBoxRepeatPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "Password_Reset"
        Me.Text = "The Health App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelRepeatPassword As Label
    Friend WithEvents TextBoxRepeatPassword As TextBox
    Friend WithEvents ButtonResetPassword As Button
    Friend WithEvents ButtonReturnLogin As Button
    Friend WithEvents LabelResetCode As Label
    Friend WithEvents TextBoxResetCode As TextBox
    Friend WithEvents ButtonResetCode As Button
    Friend WithEvents LabelUsernameError As Label
    Friend WithEvents LabelResetError As Label
    Friend WithEvents LabelPasswordError As Label
    Friend WithEvents LabelRPasswordError As Label
    Friend WithEvents ButtonShowPassword As Button
End Class
