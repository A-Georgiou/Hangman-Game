Public Class Form1

    'Declare Global Variables'
    Public selectedWord As String
    Dim wordList(10) As String
    Dim outputsWord() As Char
    Dim splitWord() As Char

    Dim inputtedLetter As String
    Dim letterUsed(24) As Char
    Dim letterFound As Boolean
    Dim letterCounter As Integer = 0
    Dim lettersUsedList As String

    Dim attempts As Integer = 10
    Dim won As WonGame = New WonGame
    Dim lost As LostGame = New LostGame

    'Initial Load of Form generates game for user'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateWordArray()
        GenerateWord()
        OutputWord()
    End Sub

    'enters the words into the array of possible hangman words'
    Sub PopulateWordArray()

        wordList = {"computer", "mouse", "facebook", "twitter", "avengers", "amazon", "monitor", "windows", "headset", "keyboard", "android", "apple"}

    End Sub

    'Randomly selects the word to be played in the new game'
    Sub GenerateWord()

        Randomize()
        selectedWord = wordList(Int(Rnd() * 10))
        outputsWord = selectedWord

    End Sub

    'Checks input is valid (not empty and isnt already used) then calls the method to handle the letter input'
    Sub InputLetter()
        If (selectLetter.Text <> "" And letterUsed.Contains(selectLetter.Text) <> True) Then
            IsLetterInWord(selectLetter.Text)
            handleUsedLetter()
        End If
    End Sub


    'Uses string manipulation to build the string outputted to the user'
    Sub OutputWord()

        For counter = 0 To selectedWord.Length - 1

            outputsWord(counter) = "_"
            outputString.Text += outputsWord(counter) + " "

        Next counter

        outputString.Text.Remove(outputString.Text.Length - 1)

    End Sub

    'Checks if the user inputted letter is found in the selected word'
    Sub IsLetterInWord(inputtedLetter As String)

        letterFound = False

        For counter = 0 To selectedWord.Length - 1
            If (selectedWord.Chars(counter) = inputtedLetter.ToLower) Then
                CorrectLetter(counter)
                letterFound = True
            End If
        Next counter

        If letterFound = False Then
            FailedLetter()
        End If

    End Sub

    'if the user inputted letter is correct it changes the word outputted to the user to show there correct letter'
    Sub CorrectLetter(inputPos As Integer)

        outputString.Text = ""

        For counter = 0 To outputsWord.Length - 1

            If (inputPos = counter) Then

                outputsWord(counter) = selectedWord.ToUpper.Chars(inputPos)

            End If

            outputString.Text += outputsWord(counter) + " "

        Next counter

        If CheckWin() = True Then

            WonGame()

        End If

    End Sub

    'if the user has failed letter attempt it animates the image and reduces the number of user attempts'
    Sub FailedLetter()

        attempts = attempts - 1
        attemptText.Text = "Attempts: " + attempts.ToString

        For counter = 0 To 25
            Threading.Thread.Sleep(5)
            sharkPicture.Left = sharkPicture.Left - 1
        Next

        CheckLoss()

    End Sub

    'Checks if user has won'
    Function CheckWin()

        For counter = 0 To outputsWord.Length - 1

            If (outputsWord(counter) = "_") Then
                Return False
            End If

        Next counter

        Return True

    End Function

    'Checks if user has ran out of attempts (lost)'
    Sub CheckLoss()

        If (attempts = 0) Then
            manPicture.Hide()
            LostGame()
        End If

    End Sub

    'If user wins opens winning form and disables main form'
    Sub WonGame()
        won.Show()
        Me.Enabled = False
    End Sub

    'If user loses opens lost form and disables main form'
    Sub LostGame()
        lost.Show()
        Me.Enabled = False
    End Sub

    'Handles submit value button click event'
    Private Sub submitVal_Click(sender As Object, e As EventArgs) Handles submitVal.Click
        InputLetter()
    End Sub

    'Handles the used letter so the user cannot enter the same letter twice'
    Sub handleUsedLetter()
        letterUsed(letterCounter) = selectLetter.Text
        selectLetter.Items.RemoveAt(selectLetter.FindString(selectLetter.Text))
        lettersUsedList = ""

        For counter = 0 To letterCounter
            lettersUsedList += letterUsed(counter) + " "
        Next counter

        usedLetters.Text = lettersUsedList

        letterCounter = letterCounter + 1

    End Sub

End Class
