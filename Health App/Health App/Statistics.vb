Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class Statistics 'Statistics page.

    Dim sumWeight As Double 'Stores total weight of all users.
    Dim lowestWeight As Double 'Used to calculate and store the lowest weight among all users. 
    Dim highestWeight As Double 'Used to calculate and store the heighest weight among all users.
    Dim filledEntries As Integer 'Used to tracks the number of weight entries that are not blank.

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

    Private Sub ButtonImperial_Click(sender As Object, e As EventArgs) Handles ButtonImperial.Click 'Imperial button. Displays weight statistics in imperial units.

        'Changes selection button colours.
        ButtonImperial.BackColor = Color.Green
        ButtonMetric.BackColor = Color.Red

        'Changes unit labels.
        TextBoxUnit1.Text = "st"
        TextBoxUnit2.Text = "st"
        TextBoxUnit3.Text = "st"

        'Makes additional input boxes visible.
        TextBoxAverage1.Visible = True
        TextBoxHighest1.Visible = True
        TextBoxLowest1.Visible = True
        TextBoxUnit4.Visible = True
        TextBoxUnit5.Visible = True
        TextBoxUnit6.Visible = True

        sumWeight = 0 'Stores total weight of all users.
        lowestWeight = 0 'Used to calculate and store the lowest weight among all users. 
        highestWeight = 0 'Used to calculate and store the heighest weight among all users.

        For i = 0 To (GV.weights.Length - 1)

            If GV.weights(i) <> "" Then 'Checks if weight entry is not blank.

                If lowestWeight = 0 Then 'If lowest weight is zero then set it to the first valid weight in the array.
                    lowestWeight = CDbl(GV.weights(i))
                End If

                sumWeight += CDbl(GV.weights(i)) 'Calculating the total weight of all users.

                If CDbl(GV.weights(i)) > highestWeight Then 'Calculating highest weight.
                    highestWeight = CDbl(GV.weights(i))
                End If

                If CDbl(GV.weights(i)) < lowestWeight Then 'Calculating lowest weight.
                    lowestWeight = CDbl(GV.weights(i))
                End If

            End If

        Next i

        If filledEntries > 0 Then 'Used to avoid dividing by 0 when there are no valid entries in the weights array, hence outputing NaN.
            sumWeight = (sumWeight / (filledEntries)) 'Calculating the average weight among all users.
        End If

        'Converting kilograms to pounds if using Imperial units.
        sumWeight *= 2.20462
        lowestWeight *= 2.20462
        highestWeight *= 2.20462

        'Displaying the weight statistics to the user.
        TextBoxAverage.Text = Math.Floor(sumWeight / 14)
        TextBoxLowest.Text = Math.Floor(lowestWeight / 14)
        TextBoxHighest.Text = Math.Floor(highestWeight / 14)
        TextBoxAverage1.Text = Math.Floor(sumWeight Mod 14)
        TextBoxLowest1.Text = Math.Floor(lowestWeight Mod 14)
        TextBoxHighest1.Text = Math.Floor(highestWeight Mod 14)
    End Sub

    Private Sub ButtonMetric_Click(sender As Object, e As EventArgs) Handles ButtonMetric.Click 'Metric button. Displays weight statistics in metric units.


        'Changes selection button colours.
        ButtonMetric.BackColor = Color.Green
        ButtonImperial.BackColor = Color.Red

        'Changes unit labels.
        TextBoxUnit1.Text = "kg"
        TextBoxUnit2.Text = "kg"
        TextBoxUnit3.Text = "kg"

        'Makes additional input boxes invisible.
        TextBoxAverage1.Visible = False
        TextBoxHighest1.Visible = False
        TextBoxLowest1.Visible = False
        TextBoxUnit4.Visible = False
        TextBoxUnit5.Visible = False
        TextBoxUnit6.Visible = False

        sumWeight = 0 'Stores total weight of all users.
        lowestWeight = 0 'Used to calculate and store the lowest weight among all users. 
        highestWeight = 0 'Used to calculate and store the heighest weight among all users.

        For i = 0 To (GV.weights.Length - 1)

            If GV.weights(i) <> "" Then 'Checks if weight entry is not blank.

                If lowestWeight = 0 Then 'If lowest weight is zero then set it to the first valid weight in the array.
                    lowestWeight = CDbl(GV.weights(i))
                End If

                sumWeight += CDbl(GV.weights(i)) 'Calculating the total weight of all users.

                If CDbl(GV.weights(i)) > highestWeight Then 'Calculating highest weight.
                    highestWeight = CDbl(GV.weights(i))
                End If

                If CDbl(GV.weights(i)) < lowestWeight Then 'Calculating lowest weight.
                    lowestWeight = CDbl(GV.weights(i))
                End If

            End If

        Next i

        If filledEntries > 0 Then 'Used to avoid dividing by 0 when there are no valid entries in the weights array, hence outputing NaN.
            sumWeight = (sumWeight / (filledEntries)) 'Calculating the average weight among all users.
        End If

        'Displaying the weight statistics to the user.
        TextBoxAverage.Text = (Math.Round(sumWeight, 2))
        TextBoxLowest.Text = (Math.Round(lowestWeight, 2))
        TextBoxHighest.Text = (Math.Round(highestWeight, 2))
    End Sub

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles Me.Load 'On load displays weight statistics to the user in metric units.

        'Makes additional input boxes invisible.
        TextBoxAverage1.Visible = False
        TextBoxHighest1.Visible = False
        TextBoxLowest1.Visible = False
        TextBoxUnit4.Visible = False
        TextBoxUnit5.Visible = False
        TextBoxUnit6.Visible = False

        sumWeight = 0 'Stores total weight of all users.
        lowestWeight = 0 'Used to calculate and store the lowest weight among all users. 
        highestWeight = 0 'Used to calculate and store the heighest weight among all users.

        For i = 0 To (GV.weights.Length - 1)

            If GV.weights(i) <> "" Then 'Checks if weight entry is not blank.

                filledEntries += 1

                If lowestWeight = 0 Then 'If lowest weight is zero then set it to the first valid weight in the array.
                    lowestWeight = CDbl(GV.weights(i))
                End If

                sumWeight += CDbl(GV.weights(i)) 'Calculating the total weight of all users.

                If CDbl(GV.weights(i)) > highestWeight Then 'Calculating highest weight.
                    highestWeight = CDbl(GV.weights(i))
                End If

                If CDbl(GV.weights(i)) < lowestWeight Then 'Calculating lowest weight.
                    lowestWeight = CDbl(GV.weights(i))
                End If

            End If

        Next i

        If filledEntries > 0 Then 'Used to avoid dividing by 0 when there are no valid entries in the weights array, hence outputing NaN.
            sumWeight = (sumWeight / (filledEntries)) 'Calculating the average weight among all users.
        End If

        'Displaying the metric weight statistics to the user.
        TextBoxAverage.Text = (Math.Round(sumWeight, 2))
        TextBoxLowest.Text = (Math.Round(lowestWeight, 2))
        TextBoxHighest.Text = (Math.Round(highestWeight, 2))
    End Sub


End Class