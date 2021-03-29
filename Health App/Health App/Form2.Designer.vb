<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Account))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelRepeatPassword = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.ButtonReturnLogin = New System.Windows.Forms.Button()
        Me.LabelUsernameError = New System.Windows.Forms.Label()
        Me.LabelPasswordError = New System.Windows.Forms.Label()
        Me.LabelRPasswordError = New System.Windows.Forms.Label()
        Me.ButtonShowPassword = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 183)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(262, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(221, 251)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(262, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(221, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Create Account"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPassword.ForeColor = System.Drawing.Color.Blue
        Me.LabelPassword.Location = New System.Drawing.Point(217, 161)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(71, 19)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password:"
        '
        'LabelRepeatPassword
        '
        Me.LabelRepeatPassword.AutoSize = True
        Me.LabelRepeatPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelRepeatPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelRepeatPassword.ForeColor = System.Drawing.Color.Blue
        Me.LabelRepeatPassword.Location = New System.Drawing.Point(217, 229)
        Me.LabelRepeatPassword.Name = "LabelRepeatPassword"
        Me.LabelRepeatPassword.Size = New System.Drawing.Size(119, 19)
        Me.LabelRepeatPassword.TabIndex = 5
        Me.LabelRepeatPassword.Text = "Repeat Password:"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelUsername.ForeColor = System.Drawing.Color.Blue
        Me.LabelUsername.Location = New System.Drawing.Point(217, 94)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(105, 19)
        Me.LabelUsername.TabIndex = 6
        Me.LabelUsername.Text = "Email Address:"
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
        Me.ButtonReturnLogin.TabIndex = 7
        Me.ButtonReturnLogin.Text = "Return to Login"
        Me.ButtonReturnLogin.UseVisualStyleBackColor = False
        '
        'LabelUsernameError
        '
        Me.LabelUsernameError.AutoSize = True
        Me.LabelUsernameError.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsernameError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelUsernameError.ForeColor = System.Drawing.Color.Red
        Me.LabelUsernameError.Location = New System.Drawing.Point(217, 139)
        Me.LabelUsernameError.Name = "LabelUsernameError"
        Me.LabelUsernameError.Size = New System.Drawing.Size(0, 19)
        Me.LabelUsernameError.TabIndex = 13
        '
        'LabelPasswordError
        '
        Me.LabelPasswordError.AutoSize = True
        Me.LabelPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.LabelPasswordError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LabelPasswordError.Location = New System.Drawing.Point(217, 206)
        Me.LabelPasswordError.Name = "LabelPasswordError"
        Me.LabelPasswordError.Size = New System.Drawing.Size(0, 19)
        Me.LabelPasswordError.TabIndex = 14
        '
        'LabelRPasswordError
        '
        Me.LabelRPasswordError.AutoSize = True
        Me.LabelRPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.LabelRPasswordError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelRPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LabelRPasswordError.Location = New System.Drawing.Point(217, 274)
        Me.LabelRPasswordError.Name = "LabelRPasswordError"
        Me.LabelRPasswordError.Size = New System.Drawing.Size(0, 19)
        Me.LabelRPasswordError.TabIndex = 15
        '
        'ButtonShowPassword
        '
        Me.ButtonShowPassword.BackColor = System.Drawing.Color.LightGray
        Me.ButtonShowPassword.BackgroundImage = CType(resources.GetObject("ButtonShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowPassword.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowPassword.ForeColor = System.Drawing.Color.White
        Me.ButtonShowPassword.Location = New System.Drawing.Point(460, 183)
        Me.ButtonShowPassword.Name = "ButtonShowPassword"
        Me.ButtonShowPassword.Size = New System.Drawing.Size(23, 20)
        Me.ButtonShowPassword.TabIndex = 16
        Me.ButtonShowPassword.UseVisualStyleBackColor = False
        '
        'New_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.ButtonShowPassword)
        Me.Controls.Add(Me.LabelRPasswordError)
        Me.Controls.Add(Me.LabelPasswordError)
        Me.Controls.Add(Me.LabelUsernameError)
        Me.Controls.Add(Me.ButtonReturnLogin)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelRepeatPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "New_Account"
        Me.Text = "The Health App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelRepeatPassword As Label
    Friend WithEvents LabelUsername As Label
    Friend WithEvents ButtonReturnLogin As Button
    Friend WithEvents LabelUsernameError As Label
    Friend WithEvents LabelPasswordError As Label
    Friend WithEvents LabelRPasswordError As Label
    Friend WithEvents ButtonShowPassword As Button
End Class
