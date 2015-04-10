Public Class frmRomanNumeralConverter
    Private Sub frmRomanNumeralConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focus on load
        txtValueInput.Focus()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Convert to Numeral
        Dim intInputNumber As Integer
        'If input is able to be parsed as an integer, then
        If Integer.TryParse(txtValueInput.Text, intInputNumber) Then
            'select an output based on input value
            Select Case intInputNumber

                Case Is < 0
                    'less than 0 give message
                    MessageBox.Show("Enter a value one through ten!")

                Case 1 'select case based on integer value from tryparse method
                    'output corresponding symbol
                    lblNumeralOutput.Text = "I"

                Case 2
                    'output corresponding symbol
                    lblNumeralOutput.Text = "II"

                Case 3
                    'output corresponding symbol
                    lblNumeralOutput.Text = "III"

                Case 4
                    'output corresponding symbol
                    lblNumeralOutput.Text = "IV"

                Case 5
                    'output corresponding symbol
                    lblNumeralOutput.Text = "V"

                Case 6
                    'output corresponding symbol
                    lblNumeralOutput.Text = "VI"

                Case 7
                    'output corresponding symbol
                    lblNumeralOutput.Text = "VII"

                Case 8
                    'output corresponding symbol
                    lblNumeralOutput.Text = "VIII"

                Case 9
                    'output corresponding symbol
                    lblNumeralOutput.Text = "IX"

                Case 10
                    'output corresponding symbol
                    lblNumeralOutput.Text = "X"

                Case Is > 10
                    'more than 0 give message
                    MessageBox.Show("Enter a value one through ten!")

            End Select

        Else
            'If not parsed into integer return message to user
            MessageBox.Show("Enter a number.")

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear input and output fields and return focus on first field
        txtValueInput.Clear()
        lblNumeralOutput.Text = String.Empty
        txtValueInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub
End Class
