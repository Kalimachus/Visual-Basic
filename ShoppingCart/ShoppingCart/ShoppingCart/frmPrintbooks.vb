Public Class frmPrintBooks

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'move selected items from Print Books form list box and move it to Shopping cart list box
        Try ' try because if nothing is selected you will get negative one value returning a runtime error.


            If lstPrintBook.Items.Count > 0 Then
                frmShoppingCart.lstProductsSelected.Items.Add(lstPrintBook.SelectedItem)
                'lstprintbook.selecteditem is a string value being evaluated in the Addbook procedure
                AddBook(lstPrintBook.SelectedItem)
            End If

            'get the Subtotal, Tax, Shipping, and Total from the Calculations module and Show them in the appropriate labels on Main form

            UpdateDisplays() 'is the sameas
            'frmShoppingCart.lblSubtotal.Text = g_decBooksTotal.ToString("c")
            'frmShoppingCart.lblTax.Text = g_decTax.ToString("c")
            'frmShoppingCart.lblShipping.Text = g_decShipping.ToString("c")
            'frmShoppingCart.lblTotal.Text = g_decTotal.ToString("c")

        Catch
            MessageBox.Show("Select a book!")
        End Try


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class