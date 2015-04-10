Public Class frmBankCharges
    Private Sub frmBankCharges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'focus first field when form loads
        txtInputValue.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declare variables for calculation
        Dim uintInputValue As UInteger      'converted number from text input
        Dim decSubtotal As Decimal          'Before base fee
        Dim decTotal As Decimal             'Calculated after base fee
        Const decTHE_MAN As Decimal = 10.0  'Base fee always trying to keep us down...

        'Test condition that input value is natural non-negative
        If UInteger.TryParse(txtInputValue.Text, uintInputValue) Then

            'Select cost per check in relation to input value..
            Select Case uintInputValue
                'In the case that number of checks written, apply...

                Case 0
                    'convert integer into decimal value
                    decSubtotal = uintInputValue

                Case Is < 20
                    'discounted rate for applicable number ofchecks
                    decSubtotal = uintInputValue * 0.1

                Case 20 To 39
                    'discounted rate for applicable number ofchecks
                    decSubtotal = uintInputValue * 0.08

                Case 40 To 59
                    'discounted rate for applicable number ofchecks
                    decSubtotal = uintInputValue * 0.06

                Case Is > 59
                    'discounted rate for applicable number ofchecks
                    decSubtotal = uintInputValue * 0.04

            End Select

            'add additional base fee after the MAN
            decTotal = decSubtotal + decTHE_MAN
            'display output on a label's text
            lblOutputValue.Text = decTotal.ToString("c")

            ''for humor: .5 of a check???
            'ElseIf Decimal.TryParse(txtInputValue.Text, uintInputValue) Then
            'MessageBox.Show("Seems part of a check was ripped." & ControlChars.CrLf & "This institution only accepts whole checks. Try again.", "Ripping Us Off, Eh?", MessageBoxButtons.OK, MessageBoxIcon.Question)


        Else
            'If the parse fails, show message
            MessageBox.Show("Enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear input and output fields and focus first field
        txtInputValue.Clear()
        lblOutputValue.Text = String.Empty
        txtInputValue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Current Form
        Me.Close()
    End Sub
End Class
