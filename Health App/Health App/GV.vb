Imports System.Security.Cryptography 'Library needed for password hashing.
Imports System.Text 'Library needed for password hashing.

Public Class GV ' This is public and is accessible in any form. GV stands for Global Variables.
    Public Shared username() As String ' Array stores signed up users.
    Public Shared password() As String ' Array stores user passwords. Synchronised to username() array by index.
    Public Shared currentUsername As String ' Variable remembers the currently logged user.
    Public Shared weights() As String ' Array stores user weights. Synchronised to username() array by index.
    Public Shared salt() As String ' Array storing password salts. Synchronised to username() and password() arrays by index.
    Public Shared reset() As String ' Array storing reset codes and times at which they were made. Synchronised to the username() array by index.


    'Function creates a salted password hash.
    Public Shared Function GetSaltedHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt 'Variable used to stored the password and salt combination.

        Using hash As HashAlgorithm = New SHA256Managed() 'Using the SHA256 algorithm for password hashing.
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp) 'Converts the password and salt combination into bytes.
            Dim hBytes = hash.ComputeHash(saltyPW) 'Creates hash bytes from the password and salt combination.
            Return Convert.ToBase64String(hBytes) 'Converts the bytes into a base 64 text string. 
        End Using

    End Function

    'Function creates a new salt.
    Public Shared Function CreateNewSalt(size As Integer) As String
        Using rng As New RNGCryptoServiceProvider 'Creates a random new salt using a random number generator.
            Dim data(If(size < 7, 7, size)) As Byte 'Used to make sure that the size of a salt byte is not too small.
            rng.GetBytes(data) 'Fills the array with salt bytes.
            Return Convert.ToBase64String(data) 'Converts salt into base 64 text string.
        End Using
    End Function

    'Function checks if an email address is valid.
    Public Shared Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s) 'If assigning email address to variable fails due to an invalid format, returns false.
        Catch
            Return False
        End Try
        Return True 'Otherwise returns true.
    End Function

End Class
