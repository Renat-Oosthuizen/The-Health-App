Imports System.IO 'Imports Input/Output functionality including StreamReader. Can work without it by typing System.IO."function".

Public Class Diary 'Diary page.

    Dim userDiary As String = "Data\UserDiary.txt" 'Used to store the filepath for the diary specific Username text document.
    Dim entryDiary As String = "Data\EntryDiary.txt" 'Used to store the filepath for the text document storing diary entries.
    Dim uDiary() As String 'Diary specific array for storing usernames.
    Dim eDiary() As String  'Diary specific array for storing diary entries, linked to the username array by index.
    Dim diaryIndex() As Integer = {} 'Array stores indexes containing diary entries for the current user.
    Dim counter As Integer = 0 'Keeps track of which diary entry should be displayed in Edit mode. 
    Dim diaryOld As String ' User diary entries are placed here.

    Dim modeEntry As Boolean = True 'Tracks if the diary is currently in edit mode or create entry mode.

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

    Private Sub Diary_Load(sender As Object, e As EventArgs) Handles Me.Load 'When page loads...

        'Hiding buttons and page number.
        ButtonDelete.Hide()
        ButtonDown.Hide()
        ButtonUp.Hide()
        LabelPageNumber.Text = ""

        diaryOld = "" 'Reseting diaryOld.

        'Checks if diary specific username text file and diary text file exist. Creates them if they do not.
        If Not File.Exists(userDiary) Then
            File.Create(userDiary).Dispose()
        End If
        If Not File.Exists(entryDiary) Then
            File.Create(entryDiary).Dispose()
        End If

        'Importing usernames and diary entries from the text documents.
        uDiary = File.ReadAllLines(userDiary)
        eDiary = File.ReadAllLines(entryDiary)

        'Loading previous diary entries. 
        For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in column. Counts down so last entry is displayed first.
            If uDiary(i) = GV.currentUsername Then 'If username matches current user then diary entry is stored for display.
                diaryOld += eDiary(i).Replace("<^>", vbCrLf)
            End If

        Next

        TextBoxOld.Text = diaryOld 'Diary entries are displayed in text box.
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click 'Save button.

        If modeEntry = True Then

            diaryOld = "" 'Reseting diaryOld.
            LabelDiaryError.Text = "" 'Clearing the error label.

            If TextBoxNew.Text.Trim <> "" Then 'Stops user from saving blank entries.
                'Importing usernames and diary entries from the text documents.
                uDiary = File.ReadAllLines(userDiary)
                eDiary = File.ReadAllLines(entryDiary)

                'Saving new diary entries. New entry stored in the last row.
                ReDim Preserve uDiary(uDiary.Length)
                uDiary(uDiary.Length - 1) = GV.currentUsername
                ReDim Preserve eDiary(eDiary.Length)
                eDiary(eDiary.Length - 1) = (TextBoxNew.Text.Replace(vbCrLf, "<^>") & "<^>" & System.DateTime.Now.ToString("dd/MM/yyyy    HH:mm") & "<^> <^>")  'Line breaks are replaced with "<^>" due to limitation with storing arrays in text documents.

                'Loading previous diary entries. 
                For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in the column. Counts down so last entry is displayed first.
                    If uDiary(i) = GV.currentUsername Then 'If username matches current user then diary entry is stored for display.
                        diaryOld += eDiary(i).Replace("<^>", vbCrLf)
                    End If

                Next

                TextBoxOld.Text = diaryOld 'Diary entries are displayed in text box.

                'New diary entries are stored in text files as username and entry linked by index.
                File.WriteAllLines(userDiary, uDiary)
                File.WriteAllLines(entryDiary, eDiary)

            Else LabelDiaryError.Text = "Error: The text box is empty."
            End If
            TextBoxNew.Text = "" 'Clear the text box.
        End If

        If modeEntry = False Then

            diaryOld = "" 'Reseting diaryOld.
            LabelDiaryError.Text = "" 'Clearing the error label.

            If TextBoxNew.Text.Trim = "" Then
                LabelDiaryError.Text = "Error: The text box is empty."

            Else
                eDiary(diaryIndex(counter)) = TextBoxNew.Text.Replace(vbCrLf, "<^>") 'Pressing save in edit mode saves the current contents of the text box to the text file if the entry is not blank.

                'Loading previous diary entries. 
                For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in the column. Counts down so last entry is displayed first.
                    If uDiary(i) = GV.currentUsername Then 'If username matches current user then diary entry is stored for display.
                        diaryOld += eDiary(i).Replace("<^>", vbCrLf)
                    End If

                Next

                TextBoxOld.Text = diaryOld 'Diary entries are displayed in text box.

                File.WriteAllLines(entryDiary, eDiary) 'Edited diary entry is stored in the text file.
            End If
        End If
    End Sub

    Private Sub ButtonMode_Click(sender As Object, e As EventArgs) Handles ButtonMode.Click '"Switch to Edit Mode/New Entry Mode" button.

        diaryOld = "" 'Reseting diaryOld.
        LabelDiaryError.Text = "" 'Clearing the error label.

        If modeEntry = True Then 'If currently in entry mode.

            'Switching to edit mode:

            modeEntry = False
            ButtonMode.Text = "Switch to New Entry Mode"

            'Showing buttons.
            ButtonDelete.Show()
            ButtonDown.Show()
            ButtonUp.Show()
            ButtonSave.Text = "Edit Entry"
            LabelMode.Text = "Currently in Edit Mode. Plese choose an entry to edit or delete."

            TextBoxNew.Text = "" 'Clearing text box.

            diaryIndex = {} 'Reseting diaryIndex. 

            'Acquiring indexes of the user's diary entries.
            For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in column. Counts down so last entry is displayed first.
                If uDiary(i) = GV.currentUsername Then 'If username matches current user then the index is stored in diaryIndex().
                    ReDim Preserve diaryIndex(diaryIndex.Length) 'Expanding diaryIndex() array by 1.
                    diaryIndex(diaryIndex.Length - 1) = i 'Storing the index for the diary entry in the array.
                End If
            Next

            If diaryIndex.Length > 0 Then
                TextBoxNew.Text = eDiary(diaryIndex(counter)).Replace("<^>", vbCrLf) 'Show entry if there is one.
            End If

            LabelPageNumber.Text = (diaryIndex.Length - counter) & "/" & diaryIndex.Length 'Displays your currently selected page of thet total number of pages.

        Else 'If currently in edit mode.

            'Switching to entry mode.

            ButtonMode.Text = "Switch to Edit Mode"
            modeEntry = True

            'Hiding buttons and page number.
            ButtonDelete.Hide()
            ButtonDown.Hide()
            ButtonUp.Hide()
            ButtonSave.Text = "Create Entry"
            LabelPageNumber.Text = ""
            LabelMode.Text = "Currently in New Entry Mode. Please submit a new entry."

            TextBoxNew.Text = "" 'Clearing text box.


            'Importing usernames and diary entries from the text documents.
            uDiary = File.ReadAllLines(userDiary)
            eDiary = File.ReadAllLines(entryDiary)

            'Loading previous diary entries. 
            For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in column. Counts down so last entry is displayed first.
                If uDiary(i) = GV.currentUsername Then 'If username matches current user then diary entry is stored for display.
                    diaryOld += (eDiary(i).Replace("<^>", vbCrLf))
                End If

            Next

            TextBoxOld.Text = diaryOld 'Diary entries are displayed in text box.
        End If
    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click 'Down button.

        LabelDiaryError.Text = "" 'Clearing the error label.

        If (counter - 1) > -1 Then
            counter -= 1
            TextBoxNew.Text = eDiary(diaryIndex(counter)).Replace("<^>", vbCrLf) 'Show entry.
        End If

        LabelPageNumber.Text = (diaryIndex.Length - counter) & "/" & diaryIndex.Length 'Displays your currently selected page of thet total number of pages.

    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click 'Up button.

        LabelDiaryError.Text = "" 'Clearing the error label.

        If (counter + 1) <= (diaryIndex.Length - 1) Then
            counter += 1
            TextBoxNew.Text = eDiary(diaryIndex(counter)).Replace("<^>", vbCrLf) 'Show entry.
        End If

        LabelPageNumber.Text = (diaryIndex.Length - counter) & "/" & diaryIndex.Length 'Displays your currently selected page of thet total number of pages.

    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click 'Delete button.
        Dim uDiaryTemp() As String = uDiary 'Temporary storage for the diary username array.
        Dim eDiaryTemp() As String = eDiary 'Temporary storage for the diary entry array.

        diaryOld = "" 'Reseting diaryOld.
        LabelDiaryError.Text = "" 'Clearing the error label.

        If diaryIndex.Length > 0 Then
            'Deleting the currently selected index in the diary username and entry arrays.
            For i = diaryIndex(counter) To (uDiary.Length - 2) 'Transfer all entries to the right of target one spot to the left. This overwrites the target.
                uDiary(i) = uDiaryTemp(i + 1)
                eDiary(i) = eDiaryTemp(i + 1)
            Next
            ReDim Preserve uDiary(uDiary.GetUpperBound(0) - 1) 'Delete the rightmost entry from the diary username array which is now a duplicate.
            ReDim Preserve eDiary(eDiary.GetUpperBound(0) - 1) 'Delete the rightmost entry from the diary entry array which is now a duplicate.

            'Reseting diaryIndex and counter.
            If counter = diaryIndex.Length - 1 And diaryIndex.Length <> 1 Then
                counter -= 1
            End If
            diaryIndex = {}


            'New diary entries are stored in text files as username and entry linked by index.
            File.WriteAllLines(userDiary, uDiary)
            File.WriteAllLines(entryDiary, eDiary)



            'Reloading the text boxes:

            'Importing usernames and diary entries from the text documents.
            uDiary = File.ReadAllLines(userDiary)
            eDiary = File.ReadAllLines(entryDiary)

            'Loading previous diary entries. 
            For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in column. Counts down so last entry is displayed first.
                If uDiary(i) = GV.currentUsername Then 'If username matches current user then diary entry is stored for display.
                    diaryOld += (vbCrLf & vbCrLf & eDiary(i).Replace("<^>", vbCrLf))
                End If

            Next

            TextBoxOld.Text = diaryOld 'Diary entries are displayed in text box.

            'Acquiring indexes of the user's diary entries.
            For i = (uDiary.Length - 1) To 0 Step -1 'Counts number of entries in column. Counts down so last entry is displayed first.
                If uDiary(i) = GV.currentUsername Then 'If username matches current user then the index is stored in diaryIndex().
                    ReDim Preserve diaryIndex(diaryIndex.Length) 'Expanding diaryIndex() array by 1.
                    diaryIndex(diaryIndex.Length - 1) = i 'Storing the index for the diary entry in the array.
                End If
            Next

            If diaryIndex.Length > 0 Then
                TextBoxNew.Text = eDiary(diaryIndex(counter)).Replace("<^>", vbCrLf) 'Show entry if there is one.
            Else TextBoxNew.Text = "" 'Otherwise make text box blank.
            End If

        Else LabelDiaryError.Text = "Error: No entry selected."
        End If

        LabelPageNumber.Text = (diaryIndex.Length - counter) & "/" & diaryIndex.Length 'Displays your currently selected page of thet total number of pages.

    End Sub
End Class