Public Class frmShoppingCart

    Private Sub frmShoppingCart_Load() Handles MyBase.Load
        'loads the lists of the book listboxes with string variables that is important for bool evaluations in the main module.
        frmAudioBooks.lstAudioBook.Items.Add(g_strAB_1)
        frmAudioBooks.lstAudioBook.Items.Add(g_strAB_2)
        frmAudioBooks.lstAudioBook.Items.Add(g_strAB_3)
        frmAudioBooks.lstAudioBook.Items.Add(g_strAB_4)
        'this takes out any possible string confusion when remove and add sub procedures 
        frmPrintBooks.lstPrintBook.Items.Add(g_strPB_1)
        frmPrintBooks.lstPrintBook.Items.Add(g_strPB_2)
        frmPrintBooks.lstPrintBook.Items.Add(g_strPB_3)
        frmPrintBooks.lstPrintBook.Items.Add(g_strPB_4)


    End Sub


    'clear all fields
    Private Sub mnuShoppingCart_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        lblShipping.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        lstProductsSelected.Items.Clear()
    End Sub


    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        'ch7 said to use it...
        Dim frmPrintBooksOne As New frmPrintBooks
        frmPrintBooks.ShowDialog()
    End Sub


    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        Dim frmAudioBooksOne As New frmAudioBooks
        'ch7 said to use it...
        frmAudioBooks.ShowDialog()
    End Sub
    'about click event
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Written in VB by a N00B")
    End Sub
    'exit procedure
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'if nothing selected remind user to select somethin
        If lstProductsSelected.SelectedItem = Nothing Then
            MessageBox.Show("Select An Item to remove it")
            'if something is selected then call remove procedure to remove influence on calculations
        ElseIf lstProductsSelected.Items.Count > 0 Then
            RemoveBook(lstProductsSelected.SelectedItem)
            ' and remove it from our lstbox
            lstProductsSelected.Items.Remove(lstProductsSelected.SelectedItem)
        End If


        UpdateDisplays() ' this is the same as this below:
        'lblSubtotal.Text = g_decBooksTotal.ToString("c")
        'lblTax.Text = g_decTax.ToString("c")
        'lblShipping.Text = g_decShipping.ToString("c")
        'lblTotal.Text = g_decTotal.ToString("c")
    End Sub

End Class