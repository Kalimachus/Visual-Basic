Public Class frmTheaterRevenue
    Private Sub frmTheaterRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load focus will be here
        txtAdultTicketPrice.Focus()

    End Sub

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        'Declaring variables to calculate with
        Dim decGrossAdultTicketSales As Decimal     'gross sales in adults
        Dim decGrossChildTicketSales As Decimal     'gross sales in childs
        Dim decTotalGrossRevenue As Decimal         'combined gross with adult and child
        Dim decNetAdultTicketSales As Decimal       'net after gross in adult tickets
        Dim decNetChildTicketSales As Decimal       'net after gross in child tickets
        Dim decTotalNetRevenue As Decimal           'total net revenue after gross
        Const decTHE_MAN As Decimal = 0.2D         'the 20% of receipts that the box office retains

        Try
            'calculate gross adult ticket sales
            decGrossAdultTicketSales = CDec(txtAdultTicketPrice.Text) * CDec(txtAdultTickets.Text)
            'display in respective field
            lblGrossAdultTicketDisplay.Text = decGrossAdultTicketSales.ToString("c")

            'calculate gross child ticket sales
            decGrossChildTicketSales = CDec(txtChildTicketPrice.Text) * CDec(txtChildTickets.Text)
            'display in respective field
            lblGrossChildTicketSalesDisplay.Text = decGrossChildTicketSales.ToString("c")

            'calculate total gross revenue
            decTotalGrossRevenue = decGrossAdultTicketSales + decGrossChildTicketSales
            'display in respective field
            lblTotalGrossRevenueDisplay.Text = decTotalGrossRevenue.ToString("c")

            'calculate net adult ticket sales after decTHE_MAN
            decNetAdultTicketSales = decGrossAdultTicketSales * decTHE_MAN
            'display in respective field
            lblNetAdultTicketSalesDisplay.Text = decNetAdultTicketSales.ToString("c")

            'calculate net child ticket sales after decThe_MAN
            decNetChildTicketSales = decGrossChildTicketSales * decTHE_MAN
            'display in respective field
            lblNetChildTicketDisplay.Text = decNetChildTicketSales.ToString("c")

            'calculate net gross after decThe_Man
            decTotalNetRevenue = decTotalGrossRevenue * decTHE_MAN
            'display in respective field
            lblNetRevenueSalesDisplay.Text = decTotalNetRevenue.ToString("c")

        Catch ex As Exception

            MessageBox.Show("ENTER NUMERIC NUMBERS ONLY!!!")


        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this procedure will clear fields
        txtAdultTicketPrice.Clear()
        txtAdultTickets.Clear()
        txtChildTicketPrice.Clear()
        txtChildTickets.Clear()
        lblGrossAdultTicketDisplay.Text = String.Empty
        lblGrossChildTicketSalesDisplay.Text = String.Empty
        lblNetAdultTicketSalesDisplay.Text = String.Empty
        lblNetChildTicketDisplay.Text = String.Empty
        lblTotalGrossRevenueDisplay.Text = String.Empty
        lblNetRevenueSalesDisplay.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes Current Form
        Me.Close()
    End Sub
End Class
