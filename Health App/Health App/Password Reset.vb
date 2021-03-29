Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class Password_Reset 'Password Reset page.

    Dim user As String 'Used for storing filepath to the Username text document.
    Dim pass As String 'Used for storing filepath to the Password text document.
    Dim salt As String 'Used for storing filepath to the Salt text document.
    Dim reset As String 'Used for storing filepath to the Reset csv file.

    Private Sub Password_Reset_Load(sender As Object, e As EventArgs) Handles Me.Load 'When page loads...

        'Creating a directory to store all the text files if one doesn't exist.
        If Not Directory.Exists("Data") Then
            Directory.CreateDirectory("Data")
        End If

        'Checks if Weights text file exist and creates one if it does not. Then imports weights from the text file into the weights array.
        If Not File.Exists("Data\Weights.txt") Then
            File.Create("Data\Weights.txt").Dispose()
        End If
        GV.weights = File.ReadAllLines("Data\Weights.txt")

        'Checks if Username text file exist and creates one if it does not. Then imports usernames from the text file into the usernames array.
        user = "Data\Username.txt"
        If Not File.Exists(user) Then
            File.Create(user).Dispose()
        End If
        GV.username = File.ReadAllLines(user)

        'Checks if Password text file exist and creates one if it does not. Then imports passwords from the text file into the passwords array.
        pass = "Data\Password.txt"
        If Not File.Exists(pass) Then
            File.Create(pass).Dispose()
        End If
        GV.password = File.ReadAllLines(pass)

        'Checks if Salts text file exist and creates one if it does not. Then imports salts from the text file into the salt array.
        salt = "Data\Salt.txt"
        If Not File.Exists(salt) Then
            File.Create(salt).Dispose()
        End If
        GV.salt = File.ReadAllLines(salt)

        'Checks if Reset csv file exist and creates one if it does not. Then imports reset codes and times from the csv file into the reset array.
        reset = "Data\Reset.csv"
        If Not File.Exists(reset) Then
            File.Create(reset).Dispose()
        End If
        GV.reset = File.ReadAllLines(reset)
    End Sub

    Private Sub ButtonResetCode_Click(sender As Object, e As EventArgs) Handles ButtonResetCode.Click '"Send Reset Code" button.

        Dim resetCode As String 'Used to store a reset code.
        resetCode = GV.CreateNewSalt(8) 'Generates a reset code.
        Dim resetTime As String 'Used to store reset time.
        resetTime = System.DateTime.Now.ToString 'Stores current system time.

        If GV.username.Contains(TextBoxUsername.Text) = False Then 'If entered username does not a match username stored in the array then show message and abort.
            LabelUsernameError.Text = "Error: Incorrect email address. Please try again."
            LabelResetError.Text = ""
            LabelPasswordError.Text = ""
            LabelRPasswordError.Text = ""
        Else
            MessageBox.Show("Reset Code sent to " & TextBoxUsername.Text & ". It will expire in 1 minute.") 'Let the user know that the code has been sent.
            TextBoxResetCode.Text = resetCode 'Inputs code into text box to speed things up for the user. 
            MessageBox.Show("Your reset code is " & resetCode & ". You have typed it into the reset text box.") 'Display reset code to the user.

            ReDim Preserve GV.reset(GV.username.Length - 1) 'Make the reset Array same length as the number of usernames.
            GV.reset(Array.IndexOf(GV.username, TextBoxUsername.Text)) = (resetCode + "," + resetTime) 'Stores the reset code and its time of generation in the reset() array.
            File.WriteAllLines(reset, GV.reset) 'Store the reset() array in the csv file.
        End If


    End Sub

    Private Sub ButtonResetPassword_Click(sender As Object, e As EventArgs) Handles ButtonResetPassword.Click '"Reset Password" button.

        GV.reset = File.ReadAllLines(reset) 'Store the reset() array in the csv file.

        Dim newSalt As String 'Used for storing a user specific salt.
        Dim oldReset As String 'Used for storing the user's current reset code.
        Dim oldTime As DateTime 'Used for storing the time at which the user's reset code was generated.

        newSalt = GV.CreateNewSalt(31) 'Generating a salt of size 32.

        If GV.username.Contains(TextBoxUsername.Text) = False Then 'If entered username does not a match username stored in the array then show message and abort.
            LabelUsernameError.Text = "Error: Incorrect email address. Please try again."
            LabelResetError.Text = ""
            LabelPasswordError.Text = ""
            LabelRPasswordError.Text = ""
        Else
            oldReset = GV.reset(Array.IndexOf(GV.username, TextBoxUsername.Text)).Split(","c)(0) 'Extracts the reset code for the entered account from the reset() array.
            oldTime = GV.reset(Array.IndexOf(GV.username, TextBoxUsername.Text)).Split(","c)(1) 'Extracts the reset time for the entered account from the reset() array.

            If oldReset <> TextBoxResetCode.Text Then 'If the entered reset code does not match the reset code for the account then show message and abort.
                LabelUsernameError.Text = ""
                LabelResetError.Text = "Error: Reset code is incorrect."
                LabelPasswordError.Text = ""
                LabelRPasswordError.Text = ""

            ElseIf oldTime.AddMinutes(1) < System.DateTime.Now Then 'If more than 1 minute has passed since the reset code was generated then show message and abort.
                LabelUsernameError.Text = ""
                LabelResetError.Text = "Error: Reset code has expired. Please generate a new reset code and try again."
                LabelPasswordError.Text = ""
                LabelRPasswordError.Text = ""

            ElseIf TextBoxPassword.Text.Contains(" ") Or TextBoxRepeatPassword.Text.Contains(" ") Then 'If the password text box contains spaces then show message and abort.
                LabelUsernameError.Text = ""
                LabelResetError.Text = ""
                LabelPasswordError.Text = "Error: Password cannot have spaces."
                LabelRPasswordError.Text = ""

            ElseIf TextBoxPassword.Text = "" Then 'If the password text box is empty then show message and abort.
                LabelUsernameError.Text = ""
                LabelResetError.Text = ""
                LabelPasswordError.Text = "Error: Password cannot be empty"
                LabelRPasswordError.Text = ""

            ElseIf TextBoxRepeatPassword.Text.Trim <> TextBoxPassword.Text Then 'If the passwords in the two text boxes do not match then show message and abort.
                LabelUsernameError.Text = ""
                LabelResetError.Text = ""
                LabelPasswordError.Text = ""
                LabelRPasswordError.Text = "Error: Passwords do not match."

            Else
                'Creates a new salt for the account in the salt array at same index as username. Then, writes the salt array to the Salt text file.
                GV.salt(Array.IndexOf(GV.username, TextBoxUsername.Text)) = newSalt
                File.WriteAllLines(salt, GV.salt)

                'Creates a new password for the account in the password array at same index as username. Then, writes the password array to the Password text file.
                GV.password(Array.IndexOf(GV.username, TextBoxUsername.Text)) = GV.GetSaltedHash(TextBoxPassword.Text, newSalt)
                File.WriteAllLines(pass, GV.password)

                MessageBox.Show("Password reset successful.")

                Dim FirstForm As New Login 'Returns to Login page.
                FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
                FirstForm.DesktopBounds = Me.DesktopBounds
                FirstForm.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub ButtonReturnLogin_Click(sender As Object, e As EventArgs) Handles ButtonReturnLogin.Click '"Return to Login" button.
        Dim FirstForm As New Login
        FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FirstForm.DesktopBounds = Me.DesktopBounds
        FirstForm.Show()
        Me.Close()
    End Sub

    'The two subs below are used to reveal the password text when button is pressed down.
    Private Sub ButtonShowPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseDown
        TextBoxPassword.PasswordChar = ""
    End Sub

    Private Sub ButtonShowPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseUp
        TextBoxPassword.PasswordChar = "*"
    End Sub
End Class