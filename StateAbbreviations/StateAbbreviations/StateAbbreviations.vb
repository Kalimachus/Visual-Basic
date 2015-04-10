Public Class StateAbbreviations
    'Click event procedure, event name picVirginia_Click, Handler (or execution) is picVirginia.Click
    Private Sub picVirginia_Click(sender As Object, e As EventArgs) Handles picVirginia.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "Virgina -- VA"

    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub picNorthCarolina_Click(sender As Object, e As EventArgs) Handles picNorthCarolina.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "North Carolina -- NC"

    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub picSouthCarolina_Click(sender As Object, e As EventArgs) Handles picSouthCarolina.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "South Carolina -- SC"

    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub picGeorgia_Click(sender As Object, e As EventArgs) Handles picGeorgia.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "Georgia -- GA"
    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub picAlabama_Click(sender As Object, e As EventArgs) Handles picAlabama.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "Alabama -- AL"
    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub picFlorida_Click(sender As Object, e As EventArgs) Handles picFlorida.Click
        'procedure will reassign the Text property of the item/control lblDisplay to say string below
        lblDisplay.Text = "Florida -- FL"
    End Sub

    'Click event procedure, event name  and Handler (or execution) on the end
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'closes / terminates the current form
    End Sub
End Class
