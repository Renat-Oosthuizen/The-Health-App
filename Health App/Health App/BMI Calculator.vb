Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class BMI_Calculator

    Dim unitImperial As Boolean = False 'Tracks the selected unit system.

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
        GV.currentUsername = "" 'Forgets currently logged user.
        Dim FirstForm As New Login
        FirstForm.StartPosition = Windows.Forms.FormStartPosition.Manual
        FirstForm.DesktopBounds = Me.DesktopBounds
        FirstForm.Show()
        Me.Close()
    End Sub

    Private Sub ButtonImperial_Click(sender As Object, e As EventArgs) Handles ButtonImperial.Click
        unitImperial = True 'Unit system changed to Imperial.

        'Changes selection button colours.
        ButtonImperial.BackColor = Color.Green
        ButtonMetric.BackColor = Color.Red

        'Changes unit labels.
        TextBoxUnitHeight.Text = "ft"
        TextBoxUnitWeight.Text = "st"

        'Makes additional input boxes visible.
        TextBoxHeight1.Visible = True
        TextBoxWeight1.Visible = True
        TextBoxUnitHeight1.Visible = True
        TextBoxUnitWeight1.Visible = True

        'Clears input boxes.
        TextBoxHeight.Text = ""
        TextBoxWeight.Text = ""
        TextBoxHeight1.Text = ""
        TextBoxWeight1.Text = ""

        'Clears error labels.
        LabelBMIError.Text = ""
        LabelHeightError.Text = ""
        LabelWeightError.Text = ""
    End Sub

    Private Sub ButtonMetric_Click(sender As Object, e As EventArgs) Handles ButtonMetric.Click
        unitImperial = False 'Unit system changed to Metric.

        'Changes selection button colours.
        ButtonMetric.BackColor = Color.Green
        ButtonImperial.BackColor = Color.Red

        'Changes unit labels.
        TextBoxUnitHeight.Text = "cm"
        TextBoxUnitWeight.Text = "kg"

        'Makes additional input boxes invisible.
        TextBoxHeight1.Visible = False
        TextBoxWeight1.Visible = False
        TextBoxUnitHeight1.Visible = False
        TextBoxUnitWeight1.Visible = False

        'Clears input boxes.
        TextBoxHeight.Text = ""
        TextBoxWeight.Text = ""
        TextBoxHeight1.Text = ""
        TextBoxWeight1.Text = ""

        'Clears error labels.
        LabelBMIError.Text = ""
        LabelHeightError.Text = ""
        LabelWeightError.Text = ""
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click

        Dim calcBMI As Double 'Stores the user's BMI.
        Dim weightArr As Double 'Remembers weight to use in array storage.
        Dim answer As MsgBoxResult 'Used when prompting user to store their weight.

        'Used to store text box input for the Imperial system.
        Dim height0 As Integer
        Dim height1 As Integer
        Dim weight0 As Integer
        Dim weight1 As Integer

        Dim heightInches As Integer 'Used to store height in inches.
        Dim weightPounds As Integer 'Used to store weight to pounds.

        If unitImperial = False Then
            If Not IsNumeric(TextBoxWeight.Text) Or Not IsNumeric(TextBoxHeight.Text) Then 'Forces user to input a number.
                LabelBMIError.Text = "Error: Height and weight must only contain numbers."
                LabelHeightError.Text = ""
                LabelWeightError.Text = ""

            ElseIf TextBoxWeight.Text = 0 Or TextBoxHeight.Text = 0 Then 'Forces user to input a non 0.
                LabelBMIError.Text = "Error: Height and weight must be greater than 0."
                LabelHeightError.Text = ""
                LabelWeightError.Text = ""

            Else
                calcBMI = (TextBoxWeight.Text / ((TextBoxHeight.Text / 100) * (TextBoxHeight.Text / 100))) 'Calculates BMI.
                weightArr = TextBoxWeight.Text 'Weight for array storage is already in kg.

                'Clears error labels.
                LabelBMIError.Text = ""
                LabelHeightError.Text = ""
                LabelWeightError.Text = ""

                'Displays BMI.
                If calcBMI < 18.5 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are underweight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                ElseIf calcBMI >= 18.5 And calcBMI < 25 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You have a healthy weight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                ElseIf calcBMI >= 25 And calcBMI < 30.1 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are overweight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                Else
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are obese. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concern.")
                End If

                'Asks user if they want to enter their weight to the global statistics and acts accordingly.
                answer = MsgBox("Do you wish to add your weight to the global statistics?", MessageBoxButtons.YesNo)
                If answer = MsgBoxResult.Yes Then

                    If GV.username.Length <> GV.weights.Length Then 'If index bounds of weights() is less than index bounds of username() then corrects it.
                        ReDim Preserve GV.weights(GV.username.Length - 1)
                    End If

                    For i = 0 To (GV.username.Length - 1) 'Stores user weight (kg) into the weights array.
                        If GV.username(i) = GV.currentUsername Then
                            GV.weights(i) = weightArr
                        End If
                    Next

                    File.WriteAllLines("Data\Weights.txt", GV.weights) 'Writes weights array to the text file.
                End If


            End If

        End If

        If unitImperial = True Then

            If Not IsNumeric(NullToZero(TextBoxHeight.Text)) Or Not IsNumeric(NullToZero(TextBoxHeight1.Text)) Or Not IsNumeric(NullToZero(TextBoxWeight.Text)) Or Not IsNumeric(NullToZero(TextBoxWeight1.Text)) Then 'Aborts if text boxes are not empty or not numbers.
                LabelBMIError.Text = "Error: Height and weight must only contain numbers."
                LabelHeightError.Text = ""
                LabelWeightError.Text = ""
                Exit Sub
            End If

            'Stores entered numbers or 0s if text box was empty. Required to allows submission of any combination of imperial measuring units.
            height0 = CInt(NullToZero(TextBoxHeight.Text))
            height1 = CInt(NullToZero(TextBoxHeight1.Text))
            weight0 = CInt(NullToZero(TextBoxWeight.Text))
            weight1 = CInt(NullToZero(TextBoxWeight1.Text))

            If height0 = 0 And height1 = 0 Then 'Aborts if neither height text box is above 0.
                LabelBMIError.Text = ""
                LabelHeightError.Text = "Error: Please enter a valid height."
                LabelWeightError.Text = ""

            ElseIf weight0 = 0 And weight1 = 0 Then 'Aborts if neither weight text box is above 0.
                LabelBMIError.Text = ""
                LabelHeightError.Text = ""
                LabelWeightError.Text = "Error: Please enter a valid weight."

            Else

                heightInches = (height1 + (height0 * 12)) 'Converts all entered height to inches.
                weightPounds = (weight1 + (weight0 * 14)) 'Converts all entered weight to pounds.

                calcBMI = (weightPounds / (heightInches * heightInches)) * 703 'Calculates BMI.
                weightArr = (weightPounds * 0.453592) 'Converts stone to kg for array storage.

                'Clears error labels.
                LabelBMIError.Text = ""
                LabelHeightError.Text = ""
                LabelWeightError.Text = ""

                'Displays BMI.
                If calcBMI < 18.5 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are underweight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                ElseIf calcBMI >= 18.5 And calcBMI < 25 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You have a healthy weight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                ElseIf calcBMI >= 25 And calcBMI < 30.1 Then
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are overweight. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concerns.")
                Else
                    TextBoxBMI.Text = "Your BMI is: " & (Math.Round(calcBMI, 1) & "." & vbCrLf & "You are obese. Please note that BMI is not a measure of 'health'. You should consult a medical practitioner if you have any concern.")
                End If

                'Asks user if they want to enter their weight to the global statistics and acts accordingly.
                answer = MsgBox("Do you wish to add your weight to the global statistics?", MessageBoxButtons.YesNo)
                        If answer = MsgBoxResult.Yes Then

                            If GV.username.Length <> GV.weights.Length Then 'If index bounds of weights() is less than index bounds of username() then corrects it.
                                ReDim Preserve GV.weights(GV.username.Length - 1)
                            End If

                            For i = 0 To (GV.username.Length - 1) 'Stores user weight (kg) into the weights array.
                                If GV.username(i) = GV.currentUsername Then
                                    GV.weights(i) = weightArr
                                End If
                            Next

                            File.WriteAllLines("Data\Weights.txt", GV.weights) 'Writes weights array to the text file.
                        End If

                    End If
                End If




    End Sub

    Private Sub BMI_Calculator_Load(sender As Object, e As EventArgs) Handles Me.Load 'Makes Imperial text boxes and unit labels invisible on loading the page.
        TextBoxHeight1.Visible = False
        TextBoxWeight1.Visible = False
        TextBoxUnitHeight1.Visible = False
        TextBoxUnitWeight1.Visible = False
    End Sub

    Function NullToZero(text) 'Converts empty input to 0.
        If text = "" Then
            text = 0
            Return text
        Else
            Return text
        End If
    End Function

End Class