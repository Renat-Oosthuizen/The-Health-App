Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class New_Account 'New Account page.

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'Create Account button.

        Dim uniqueCheck As Boolean 'Used to check if entered username is not already taken.
        uniqueCheck = True

        Dim newSalt = GV.CreateNewSalt(31) 'Generating a salt of size 32.

        Dim user As String 'Used for storing filepath to the Username text document.
        Dim pass As String 'Used for storing filepath to the Password text document.
        Dim salt As String 'Used for storing filepath to the Salt text document.

        'Creating a directory to store all the text files if one doesn't exist.
        If Not Directory.Exists("Data") Then
            Directory.CreateDirectory("Data")
        End If

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

        'Checks if the entered username is already in the username array.
        For i = 0 To (GV.username.Length - 1)
            If TextBox1.Text = (GV.username(i)) Then
                uniqueCheck = False
            End If
        Next i

        If GV.IsValidEmailFormat(TextBox1.Text) = False Then 'If email address is not valid then shows message and aborts.
            LabelUsernameError.Text = "Error: Email address is not valid."
            LabelPasswordError.Text = ""
            LabelRPasswordError.Text = ""

        ElseIf TextBox2.Text.Contains(" ") Or TextBox3.Text.Contains(" ") Then 'If the password text box contains spaces then show message and abort.
            LabelUsernameError.Text = ""
            LabelPasswordError.Text = "Error: Password cannot contain spaces."
            LabelRPasswordError.Text = ""

        ElseIf TextBox2.Text = "" Then 'If the password text box is empty then show message and abort.
            LabelUsernameError.Text = ""
            LabelPasswordError.Text = "Error: Password cannot be empty."
            LabelRPasswordError.Text = ""

        ElseIf TextBox2.Text <> TextBox3.Text Then 'If the passwords in the two text boxes do not match then show message and abort.
            LabelUsernameError.Text = ""
            LabelPasswordError.Text = ""
            LabelRPasswordError.Text = "Error: Passwords do not match."

        Else 'For usernames: increase array length while preserving previous data, add the new username and then write the username array to the Username text file.
            ReDim Preserve GV.username(GV.username.Length)
            GV.username(GV.username.Length - 1) = TextBox1.Text
            File.WriteAllLines(user, GV.username)

            'For salts: increase array length while preserving previous data, add the new salt and then write the salt array to the Salt text file.
            ReDim Preserve GV.salt(GV.salt.Length)
            GV.salt(GV.salt.Length - 1) = newSalt
            File.WriteAllLines(salt, GV.salt)

            'For passwords: increase array length while preserving previous data, add the new salted password hash to the password array. Then write the password array to the Password text file.
            ReDim Preserve GV.password(GV.password.Length)
            GV.password(GV.password.Length - 1) = GV.GetSaltedHash(TextBox2.Text, newSalt)
            File.WriteAllLines(pass, GV.password)

            MessageBox.Show("Account creation successful.")

            Dim FirstForm As New Login 'Returns to Login page.
            FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
            FirstForm.DesktopBounds = Me.DesktopBounds
            FirstForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonReturnLogin_Click(sender As Object, e As EventArgs) Handles ButtonReturnLogin.Click 'Return to Login button. Returns to Login page.
        Dim FirstForm As New Login
        FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FirstForm.DesktopBounds = Me.DesktopBounds
        FirstForm.Show()
        Me.Close()
    End Sub

    'The two subs below are used to reveal the password text when button is pressed down.
    Private Sub ButtonShowPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseDown
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub ButtonShowPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseUp
        TextBox2.PasswordChar = "*"
    End Sub
End Class