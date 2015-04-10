Public Class frmRandomNumberGame

    Private Sub frmRandomNumberGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'focus play button on load
        btnPlay.Focus()
    End Sub


    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'declare variables
        Dim intTotalTries As Integer           'counter for attempts
        Dim intCorrectGuesses As Integer         'counter for correct guesses
        Dim intUserInput As Integer           'count for users number input
        Dim intRandNum As Integer            'assigned variable for random number
        Dim boolNumericCheck = False           'checks if input is numeric

        'do this until user presses cancel
        Do
            Dim randNum As New Random
            intRandNum = randNum.Next(1, 100)  'new random  number every iteration

            'do this everytime until posttest condition evaluates to true
            Do
                '1. ask player for number input
                Dim strAskBox = InputBox("Enter a number 1-100." & " Leave blank and press cancel if you want to quit.", "Pick a number!")
                '2. Parse it into an uinteger variable
                If Integer.TryParse(strAskBox, intUserInput) Then
                    'A.on the condition that the compiler is able to parse it...
                    Select Case intUserInput
                        Case Is > 100
                            MessageBox.Show("Enter a number 1 - 100.")
                        Case Is < 1
                            MessageBox.Show("Enter a number 1 - 100.")
                        Case Is > intRandNum
                            'give hint to go higher
                            MessageBox.Show("Too High! Try again.")
                        Case Is < intRandNum
                            'give hint to go lower
                            MessageBox.Show("Too Low! Try Again.")
                        Case Is = intRandNum
                            'reward points
                            MessageBox.Show("Spot On Mate! Congrats!")
                            intCorrectGuesses = intCorrectGuesses + 1

                    End Select

                    'indicate an attempt
                    intTotalTries += 1


                ElseIf boolNumericCheck = IsNumeric(strAskBox) And Not strAskBox = vbNullString Then
                    'if the input is string but not numeric but the input is not empty
                    MessageBox.Show("Enter a number 1 - 100")

                Else
                    'if field is empty and pressed canceled
                    Exit Sub

                End If
                'do the guess process till correct number
            Loop Until intRandNum = intUserInput
            'update scores
            lblOutputCorrect.Text = CInt(intCorrectGuesses)
            lblTotalGuesses.Text = CInt(intTotalTries)

        Loop
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'empty display fields and restore focus
        lblOutputCorrect.Text = String.Empty
        lblTotalGuesses.Text = String.Empty
        btnPlay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub
End Class
