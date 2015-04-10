Module MainModule
    ' will host all const variables and subs and functions that we will need for other forms


    Public g_decTotal As Decimal ' total cost
    Public g_decShipping As Decimal 'Shipping cost
    Public g_decTax As Decimal 'Tax

    Public g_decBooksTotal As Decimal 'Total books cost
    Public g_intBookCount As Integer ' count the number of books

    Public Const g_decTaxRate As Decimal = 0.06D 'Tax Rate 
    Public Const g_decShipRate As Decimal = 2D 'Ship Rate 

    'scribed books
    Public Const g_decPB_1 As Decimal = 11.95D  'I Did It Your Way
    Public Const g_decPB_2 As Decimal = 14.5D  'The History of Scotland
    Public Const g_decPB_3 As Decimal = 29.95D 'Learn Calculus in One day
    Public Const g_decPB_4 As Decimal = 18.5D 'Feel the Stress [lol]
    'recited books
    Public Const g_decAB_1 As Decimal = 29.95D 'The Science of Body Language
    Public Const g_decAB_2 As Decimal = 14.5D  'The History of Scotland
    Public Const g_decAB_3 As Decimal = 11.95D  'Learn Calculus in One Day without the graphs!
    Public Const g_decAB_4 As Decimal = 18.5D 'Relaxation Techniques by Billy Mays



    Public Const g_strPB_1 As String = "I Did It Your Way (Print)"
    Public Const g_strAB_1 As String = "The Science of Body Lanuage (Audio)"
    Public Const g_strPB_2 As String = "The History of Scotland (Print)"
    Public Const g_strAB_2 As String = "The History of Scotland (Audio)"
    Public Const g_strPB_3 As String = "Learn Calculus In One Day (Print)"
    Public Const g_strAB_3 As String = "Learn Calculus In One Day, NO GRAPHS! (Audio)"
    Public Const g_strPB_4 As String = "Feel The Stress"
    Public Const g_strAB_4 As String = "Relaxation Techniques by Billy Mays(Audio)"

    'upon being called this sub will be used in the event we click our btnAdd on either forms.
    '... we will use this sub procedure to identify what exactly in our list was selected
    '... by string information. Since the only items  in lst boxe's the collection were the string variables 
    '... indicated in the ShoppingCart_Load event. I know that I can indicate in my procedure that if
    ' for example I had selected "I Did It Your Way (Print)" in lstPrintboox when I click the button
    'the string input into the arguement will be "I Did It Your Way (Print)" and the case statement will
    'evaluate hey does it look like this or this? if so add to the total, then tell the bookcounting integer it to
    'count one more book.
    Public Sub AddBook(ByVal SelectedItem As String)
        Select Case SelectedItem
            Case Is = g_strPB_1 'case that it is the string "I Did It Your Way (Print)" which is best assigned to a variable
                g_decBooksTotal += g_decPB_1 'add the price of that corresponding book to our subtotal or in my naming convention bookstotal
            Case Is = g_strPB_2
                g_decBooksTotal += g_decPB_2
            Case Is = g_strPB_3
                g_decBooksTotal += g_decPB_3
            Case Is = g_strPB_4
                g_decBooksTotal += g_decPB_4
            Case Is = g_strAB_1
                g_decBooksTotal += g_decAB_1
            Case Is = g_strAB_2
                g_decBooksTotal += g_decPB_2
            Case Is = g_strAB_3
                g_decBooksTotal += g_decAB_3
            Case Is = g_strAB_4
                g_decBooksTotal += g_decAB_4
        End Select

        g_intBookCount += 1
        DoMath()

    End Sub
    'same logic but for subtracting a book.
    Public Sub RemoveBook(ByVal SelectedItem As String)
        Select Case SelectedItem
            Case Is = g_strPB_1
                g_decBooksTotal -= g_decPB_1
            Case Is = g_strPB_2
                g_decBooksTotal -= g_decPB_2
            Case Is = g_strPB_3
                g_decBooksTotal -= g_decPB_3
            Case Is = g_strPB_4
                g_decBooksTotal -= g_decPB_4
            Case Is = g_strAB_1
                g_decBooksTotal -= g_decAB_1
            Case Is = g_strAB_2
                g_decBooksTotal -= g_decPB_2
            Case Is = g_strAB_3
                g_decBooksTotal -= g_decAB_3
            Case Is = g_strAB_4
                g_decBooksTotal -= g_decAB_4
        End Select
        g_intBookCount -= 1
        DoMath()
    End Sub


    'calculate tax, shipping, & total before another procedure is called later to update the label.text
    Public Sub DoMath()
        g_decTax = g_decBooksTotal * g_decTaxRate
        g_decShipping = g_intBookCount * g_decShipRate
        g_decTotal = g_decBooksTotal + g_decShipping + g_decTax
    End Sub
    'will take whatever values involved at that moment it is called and post to the main form. we will call this
    '...every add or remove event.
    Public Sub UpdateDisplays()
        frmShoppingCart.lblSubtotal.Text = g_decBooksTotal.ToString("c")
        frmShoppingCart.lblTax.Text = g_decTax.ToString("c")
        frmShoppingCart.lblShipping.Text = g_decShipping.ToString("c")
        frmShoppingCart.lblTotal.Text = g_decTotal.ToString("c")
    End Sub

End Module
