Public Class Calorie_Counter 'Calorie Counter page.

    Private Sub CalorieCounterNav_Click(sender As Object, e As EventArgs) Handles CalorieCounterNav.Click 'Nav Bar button.
        Dim SecondForm As New Calorie_Counter
        SecondForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        SecondForm.DesktopBounds = Me.DesktopBounds
        SecondForm.Show()
        Me.Close()
    End Sub

    Private Sub BMICalculatorNav_Click(sender As Object, e As EventArgs) Handles BMICalculatorNav.Click 'Nav Bar button.
        Dim ThirdForm As New BMI_Calculator
        ThirdForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        ThirdForm.DesktopBounds = Me.DesktopBounds
        ThirdForm.Show()
        Me.Close()
    End Sub

    Private Sub DiaryNav_Click(sender As Object, e As EventArgs) Handles DiaryNav.Click 'Nav Bar button.
        Dim FourthForm As New Diary
        FourthForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FourthForm.DesktopBounds = Me.DesktopBounds
        FourthForm.Show()
        Me.Close()
    End Sub

    Private Sub StatisticsNav_Click(sender As Object, e As EventArgs) Handles StatisticsNav.Click 'Nav Bar button.
        Dim FifthForm As New Statistics
        FifthForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FifthForm.DesktopBounds = Me.DesktopBounds
        FifthForm.Show()
        Me.Close()
    End Sub

    Private Sub LogoutNav_Click(sender As Object, e As EventArgs) Handles LogoutNav.Click 'Nav Bar button.
        GV.currentUsername = "" 'Forgets the currently logged user.
        Dim FirstForm As New Login
        FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FirstForm.DesktopBounds = Me.DesktopBounds
        FirstForm.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'Calculate button.

        'Used to store calories for food items and total calories.
        Dim apples As Integer
        Dim marsBars As Integer
        Dim burgers As Integer
        Dim pizzas As Integer
        Dim total As Integer

        If Not IsNumeric(TextBox1.Text) Or Not IsNumeric(TextBox2.Text) Or Not IsNumeric(TextBox3.Text) Or Not IsNumeric(TextBox4.Text) Then 'Checks that text boxes contain numbers.
            LabelCalorieError.Text = "Error: Numbers only please. Text boxes cannot be blank."

        Else

            'Calculates calories.
            apples = (CInt(TextBox1.Text) * 95)
            marsBars = (CInt(TextBox2.Text) * 228)
            burgers = (CInt(TextBox3.Text) * 354)
            pizzas = (CInt(TextBox4.Text) * 285)
            total = (apples + marsBars + burgers + pizzas)

            'Displays calories.
            TextBoxAnswer.Text = (TextBox1.Text & " apples at 95 calories each is " & apples & " calories." & vbCrLf & TextBox2.Text & " chocolates at 228 calories each is " & marsBars & " calories." & vbCrLf & TextBox3.Text & " burgers at 354 calories each is " & burgers & " calories." & vbCrLf & TextBox4.Text & " pizza slices at 285 calories each is " & pizzas & " calories." & vbCrLf & "This is " & total & " calories in total." & "The general recommended daily calorie intake is 2,000 calories for women and 2,500 calories for men.") ' Using & instead of + as, + will attempt to convert a string with a number into a Double type.
            LabelCalorieError.Text = ""
        End If
    End Sub

End Class