Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class Login 'Login page.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Login button.

        Dim user As String 'Used for storing filepath to the Username text document.
        Dim pass As String 'Used for storing filepath to the Password text document.
        Dim salt As String 'Used for storing filepath to the Salt text document.

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

        If GV.username.Contains(TextBox1.Text) = False Then 'If entered username does not a match username stored in the array then show message and abort.
            LabelUsernameError.Text = "Error: Account not found. Please try again."
            LabelPasswordError.Text = ""

        ElseIf GV.password(Array.IndexOf(GV.username, TextBox1.Text)) = GV.GetSaltedHash(TextBox2.Text, GV.salt(Array.IndexOf(GV.username, TextBox1.Text))) Then 'Opens the Calorie Counter page if entered username and salted password hash match a username and the salted password hash linked to it in the username and password arrays.
            GV.currentUsername = TextBox1.Text
            Dim SecondForm As New Calorie_Counter
            SecondForm.StartPosition = Windows.Forms.FormStartPosition.Manual
            SecondForm.DesktopBounds = Me.DesktopBounds
            SecondForm.Show()
            Me.Close()


        Else LabelUsernameError.Text = "" 'If entered password does not match the password linked to the entered username then show message and abort.
            LabelPasswordError.Text = "Error: Incorrect password. Please try again."

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'New Account button. Opens the New Account page. 
        Dim SixthForm As New New_Account
        SixthForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        SixthForm.DesktopBounds = Me.DesktopBounds
        SixthForm.Show()
        Me.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click ' "Password Reset" button. Opens the Reset_Password form.
        Dim SeventhForm As New Password_Reset
        SeventhForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        SeventhForm.DesktopBounds = Me.DesktopBounds
        SeventhForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonExitApplication_Click(sender As Object, e As EventArgs) Handles ButtonExitApplication.Click ' "Exit Button" Exits the application. 
        Application.Exit()
    End Sub

    'The two subs below are used to reveal the password text when button is pressed down.
    Private Sub ButtonShowPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseDown
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub ButtonShowPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles ButtonShowPassword.MouseUp
        TextBox2.PasswordChar = "*"
    End Sub

End Class
