<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.ButtonExitApplication = New System.Windows.Forms.Button()
        Me.LabelUsernameError = New System.Windows.Forms.Label()
        Me.LabelPasswordError = New System.Windows.Forms.Label()
        Me.ButtonShowPassword = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(230, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(244, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Sign In"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(382, 369)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Reset Password"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(230, 369)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Create New Account"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 164)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 232)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(244, 20)
        Me.TextBox2.TabIndex = 6
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.Color.Blue
        Me.LabelUsername.Location = New System.Drawing.Point(226, 130)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(105, 19)
        Me.LabelUsername.TabIndex = 7
        Me.LabelUsername.Text = "Email Address:"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Blue
        Me.LabelPassword.Location = New System.Drawing.Point(226, 210)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(71, 19)
        Me.LabelPassword.TabIndex = 8
        Me.LabelPassword.Text = "Password:"
        '
        'ButtonExitApplication
        '
        Me.ButtonExitApplication.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonExitApplication.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonExitApplication.FlatAppearance.BorderSize = 2
        Me.ButtonExitApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExitApplication.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExitApplication.ForeColor = System.Drawing.Color.White
        Me.ButtonExitApplication.Location = New System.Drawing.Point(640, 12)
        Me.ButtonExitApplication.Name = "ButtonExitApplication"
        Me.ButtonExitApplication.Size = New System.Drawing.Size(92, 44)
        Me.ButtonExitApplication.TabIndex = 11
        Me.ButtonExitApplication.Text = "Exit Application"
        Me.ButtonExitApplication.UseVisualStyleBackColor = False
        '
        'LabelUsernameError
        '
        Me.LabelUsernameError.AutoSize = True
        Me.LabelUsernameError.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsernameError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelUsernameError.ForeColor = System.Drawing.Color.Red
        Me.LabelUsernameError.Location = New System.Drawing.Point(226, 187)
        Me.LabelUsernameError.Name = "LabelUsernameError"
        Me.LabelUsernameError.Size = New System.Drawing.Size(0, 19)
        Me.LabelUsernameError.TabIndex = 12
        '
        'LabelPasswordError
        '
        Me.LabelPasswordError.AutoSize = True
        Me.LabelPasswordError.BackColor = System.Drawing.Color.Transparent
        Me.LabelPasswordError.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelPasswordError.ForeColor = System.Drawing.Color.Red
        Me.LabelPasswordError.Location = New System.Drawing.Point(226, 255)
        Me.LabelPasswordError.Name = "LabelPasswordError"
        Me.LabelPasswordError.Size = New System.Drawing.Size(0, 19)
        Me.LabelPasswordError.TabIndex = 13
        '
        'ButtonShowPassword
        '
        Me.ButtonShowPassword.BackColor = System.Drawing.Color.LightGray
        Me.ButtonShowPassword.BackgroundImage = CType(resources.GetObject("ButtonShowPassword.BackgroundImage"), System.Drawing.Image)
        Me.ButtonShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.ButtonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowPassword.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowPassword.ForeColor = System.Drawing.Color.White
        Me.ButtonShowPassword.Location = New System.Drawing.Point(451, 232)
        Me.ButtonShowPassword.Name = "ButtonShowPassword"
        Me.ButtonShowPassword.Size = New System.Drawing.Size(23, 20)
        Me.ButtonShowPassword.TabIndex = 14
        Me.ButtonShowPassword.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(229, 12)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(245, 113)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(245, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 113)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonShowPassword)
        Me.Controls.Add(Me.LabelPasswordError)
        Me.Controls.Add(Me.LabelUsernameError)
        Me.Controls.Add(Me.ButtonExitApplication)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 489)
        Me.MinimumSize = New System.Drawing.Size(760, 489)
        Me.Name = "Login"
        Me.Text = "The Health App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonExitApplication As Button
    Friend WithEvents LabelUsernameError As Label
    Friend WithEvents LabelPasswordError As Label
    Friend WithEvents ButtonShowPassword As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
