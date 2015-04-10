Public Class frmRandomSentences
    Dim uintRand As New Random
    'counter for loop to add string

    Dim intCount As Integer

    Dim intRandomWordnumber As UInteger
    Dim strArticles() As String = {"the", "a", "by", "a", "some", "one", "that"}
    Dim strNouns() As String = {"Baby", "Hammer", "Spandex", "Airplane", "Chimpanzee", "Rock", "Waterfall"}
    Dim strprepositions() As String = {"In", "Around", "Through", "Near", "Over", "Into", "Onto"}
    Dim strVerbs() As String = {"Hit", "Burned", "Dowsed", "Shocked", "Crush", "Cuddled", "Rolled"}
    Dim strAdjectives() As String = {"Red", "Ugly", "Stinky", "Pretty", "Blue", "Lazy", "Big"}
    Dim strOneSentence As String
    Dim strEnglishConvert As String
    'load focus
    Private Sub frmRandomSentences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNext.Focus()
    End Sub

    'assemble a string using random indices of each word
    Sub smasheverythingtogether()

        strOneSentence = strArticles(uintRand.Next(0, 6)) & " " & strAdjectives(uintRand.Next(0, 6)) & " " & strNouns(uintRand.Next(0, 6)) & " " & strVerbs(uintRand.Next(0, 6)) & " " & strprepositions(uintRand.Next(0, 6)) & " " & strArticles(uintRand.Next(0, 6)) & " " & strAdjectives(uintRand.Next(0, 6)) & " " & strNouns(uintRand.Next(0, 6))
        'extra things for looks
        strEnglishConvert = strOneSentence.ToUpper().Substring(0, 1) + strOneSentence.ToLower().Substring(1) + "."

    End Sub


    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        smasheverythingtogether()

        lstOutputBox.Items.Add(strEnglishConvert.ToString())


    End Sub
    'clear lstbox and refocus
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOutputBox.Items.Clear()
        btnNext.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

