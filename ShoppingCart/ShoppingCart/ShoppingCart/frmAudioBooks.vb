Public Class frmAudioBooks
    Public intCountAudioBooks As Integer = 0

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try

            intCountAudioBooks += 1

            If lstAudioBook.Items.Count > 0 Then
                'update list box display
                frmShoppingCart.lstProductsSelected.Items.Add(lstAudioBook.SelectedItem)

                'updates the data
                AddBook(lstAudioBook.SelectedItem)

            End If

            frmShoppingCart.lblSubtotal.Text = g_decBooksTotal.ToString("c")
            frmShoppingCart.lblTax.Text = g_decTax.ToString("c")
            frmShoppingCart.lblShipping.Text = g_decShipping.ToString("c")
            frmShoppingCart.lblTotal.Text = g_decTotal.ToString("c")




        Catch

            MessageBox.Show("Select an Audio book!")

        End Try
    End Sub


    Private Sub btnClose_click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class