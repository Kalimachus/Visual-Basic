Public Class frmJoesAuto

    Const decOil As Decimal = 26D   'prices of services in check boxes
    Const decLube As Decimal = 18D
    Const decInspection As Decimal = 15D
    Const decMuffler As Decimal = 100D
    Const decTireRotation As Decimal = 20D
    Const decRadFlush As Decimal = 30D
    Const decTranFlush As Decimal = 80D
    Const decLaborCostHourly As Decimal = 20D
    Const decTheMAN As Decimal = 0.06D
    Private Sub frmJoesAuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'focus first box on load
        chkOilChange.Focus()
    End Sub
    'clear procedures
    Sub ClearOilLube()
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub
    Sub ClearFlushes()
        chkRadFlush.Checked = False
        chkTranFlush.Checked = False
    End Sub
    Sub ClearMisc()
        chkTireRotation.Checked = False
        chkReplaceMuffler.Checked = False
        chkInspection.Checked = False
    End Sub

    Sub ClearOther()
        txtLabor.Clear()
        txtParts.Clear()
    End Sub

    Sub ClearFees()
        lblParts.Text = String.Empty
        lblServicesLabor.Text = String.Empty
        lblTaxParts.Text = String.Empty
        lblTotalFees.Text = String.Empty
    End Sub
    'Number crunch functions
    Function OilLubeCharges() 'Returns the total charges for an oil change and/or a lube job, if any.
        Dim decOilLube As Decimal
        If chkOilChange.Checked = True Then
            decOilLube += decOil
        End If

        If chkLubeJob.Checked = True Then
            decOilLube += decLube
        End If
        Return decOilLube
    End Function
    Function FlushCharges() 'Returns the total charges for a radiator flush and/or a transmission flush, if any.
        Dim decFlush As Decimal
        If chkRadFlush.Checked = True Then
            decFlush += decRadFlush
        End If
        If chkTranFlush.Checked = True Then
            decFlush += decTranFlush
        End If
        Return decFlush

    End Function
    Function MiscCharges() 'Returns the total charges for an inspection, muffler replacement, and/or a tire rotation, if any.
        Dim decMisc As Decimal
        If chkInspection.Checked = True Then
            decMisc += decInspection
        End If
        If chkReplaceMuffler.Checked = True Then
            decMisc += decMuffler
        End If
        If chkTireRotation.Checked = True Then
            decMisc += decTireRotation
        End If
        Return decMisc
    End Function
    Function Parts()
        Dim decParts As Decimal
        Try
            If txtParts.Text.Length = 0 Then
                decParts = 0
            ElseIf CDec(txtParts.Text) >= 0 Then

                decParts = CDec(txtParts.Text)

            ElseIf CDec(txtParts.Text) < 0 Then

                MessageBox.Show("Enter a positive value in Parts!")

            End If

        Catch
            MessageBox.Show("Please enter a numeric value in Parts")
        End Try
        Return decParts
    End Function
    Function Labor() 'Returns the total charges for other services (parts and labor),if any.
        Dim decLabor As Decimal
        Try
            If txtLabor.Text.Length = 0 Then
                decLabor = 0
            ElseIf CDec(txtLabor.Text) >= 0 Then
                decLabor = CDec(txtLabor.Text) * decLaborCostHourly
            ElseIf CDec(txtLabor.Text) < 0 Then
                MessageBox.Show("Enter a positive value in Labor!")
            End If

        Catch
            MessageBox.Show("Please enter a numeric value in Labor")
        End Try

        'assign to text boxes

        Return decLabor
    End Function


    Function TaxCharges() 'only charged on parts. If the customer purchased services only, no sales tax is charged.
        Dim decTaxCharges As Decimal
        Dim decParts As Decimal

        Try
            If txtParts.Text.Length = 0 Then
                decTaxCharges = 0
            End If
            If CDec(txtParts.Text) >= 0 Then
                decParts = CDec(txtParts.Text)
                decTaxCharges = decParts * decTheMAN
            End If
        Catch
        End Try

        Return decTaxCharges
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decPartsCost As Decimal = Parts()
        Dim decPartsTax As Decimal = TaxCharges()
        Dim decServicesNLabor As Decimal = MiscCharges() + Labor() + OilLubeCharges() + FlushCharges()
        Dim decTotalFees As Decimal = decPartsCost + decServicesNLabor + decPartsTax



        lblParts.Text = decPartsCost.ToString("c")
        lblServicesLabor.Text = decServicesNLabor.ToString("c")
        lblTaxParts.Text = decPartsTax.ToString("c")
        lblTotalFees.Text = decTotalFees.ToString("c")

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'the Clear button:
        ClearOilLube() 'ClearOilLube Clears the check boxes for oil change and lube job.
        ClearFlushes() 'ClearFlushes Clears the check boxes for radiator flush and transmission flush.
        ClearMisc() 'ClearMisc() Clears the check boxes for inspection, muffler replacement, and tire rotation.
        ClearOther() 'ClearOther() Clears the text boxes for parts and labor.
        ClearFees() 'ClearFees() Clears the labels that display the labels in the section marked Summary.
        chkOilChange.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub
End Class
