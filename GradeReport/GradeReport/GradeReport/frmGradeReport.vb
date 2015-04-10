Public Class frmGradeReport


    Private Sub frmGradeReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'focus button on load
        btnEnterData.Focus()
    End Sub
    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click

            'declare variables
        Dim uintCountStudents As UInteger = 1
        Dim uintGradeOutput As UInteger = 0             'summation of Test Scores
        Dim intGradeAverage As Integer = 0              'Averaged value after uintGrade for string output
        Dim intTestInputIteration As Integer = 1        'test iterations variable for prompt and bool loop offset by one for prompt purposes
        Dim GradeRange As String = String.Empty                        'String determined by case of dblGradeAverage
        lstOutput.Items.Clear()

        'Add this student's info to collection until bool expression is false
        Do While uintCountStudents < 4
            'Input box for that student's name 
            Dim strStudent As String = InputBox("Enter Student #" & uintCountStudents & "'s Name:", "Input Required")

            'Input prompts for test scores 3 times
            Do While intTestInputIteration < 4
                'Prompt for Input
                Dim strGradeInput As String = InputBox("Enter " & strStudent & "'s " & "test number " & intTestInputIteration & " score!", "Input Required")
                'Ensure input is numeric and ensure no more than 100
                'because pressing cancel will get us stuck in loops
                Try
                    If UInteger.TryParse(strGradeInput, uintGradeOutput) And CInt(strGradeInput) <= 100 Then

                        intGradeAverage += uintGradeOutput

                        'loop until all 3 test scores are entered for that student
                        intTestInputIteration += 1
                        'after uintGradeOutput was added for student's iteration, we divide and select their case
                    End If
                    'in event of cancel do this
                Catch
                    MessageBox.Show("Calculation cancelled")
                    strGradeInput = String.Empty
                    Exit Sub ' breakout of procedure
                End Try
                'iteration of computations for that iteration complete
            Loop

            'average scores
            intGradeAverage \= 3

            'select grade based on average score
            Select Case intGradeAverage
                Case Is < 60
                    GradeRange = "Grade F"
                Case 60 To 69
                    GradeRange = "Grade D"
                Case 70 To 79
                    GradeRange = "Grade C"
                Case 80 To 89
                    GradeRange = "Grade B"
                Case Is >= 90
                    GradeRange = "Grade A"
            End Select

            'concantenate this student/iteration's variables as an item into the collection
            lstOutput.Items.Add(strStudent & "'s " & "Average:" & intGradeAverage & " " & GradeRange)
            'keep going until all three students have been added
            uintCountStudents += 1

            'reset grade relate variable  next iteration
            intGradeAverage = 0
            'Reset Calculation Variables for next student
            intTestInputIteration = 1
            uintGradeOutput = 0

        Loop
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub

End Class
