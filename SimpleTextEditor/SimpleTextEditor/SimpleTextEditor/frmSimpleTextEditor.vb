Imports System.IO
Public Class frmSimpleTextEditor

    ' Class-level variables
    Private strFilename As String = String.Empty ' Document filename
    Dim blnIsChanged As Boolean = False ' File change flag

    Sub ClearDocument()
        ' Clear the contents of the text box.
        txtDocument.Clear()

        ' Clear the document name.
        strFilename = String.Empty

        ' Set isChanged to False.
        blnIsChanged = False

        ' The OpenDocument procedure opens a file and loads it
        ' into the TextBox for editing.
    End Sub
 Sub OpenDocument()
        Dim inputFile As StreamReader ' Object variable

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Retrieve the selected filename.
            strFilename = ofdOpenFile.FileName

            Try
                ' Open the file.
                inputFile = File.OpenText(strFilename)
                ' Read the file's contents into the TextBox.
                txtDocument.Text = inputFile.ReadToEnd

                ' Close the file.
                inputFile.Close()

                ' Update the isChanged variable.
                blnIsChanged = False
            Catch
                ' Error message for file open error.
                MessageBox.Show("Error opening the file.")
            End Try
        End If
    End Sub

    ' The SaveDocument procedure saves the current document.

    Sub SaveDocument()
        Dim outputFile As StreamWriter ' Object variable

        Try
            ' Create the file.
            outputFile = File.CreateText(strFilename)

            ' Write the TextBox to the file.
            outputFile.Write(txtDocument.Text)

            ' Close the file.
            outputFile.Close()

            ' Update the isChanged variable.
            blnIsChanged = False
        Catch
            ' Error message for file creation error.
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    Private Sub txtDocument_TextChanged() Handles txtDocument.TextChanged
        ' Indicate the text has changed.
        blnIsChanged = True
    End Sub

    Private Sub mnuFileNew_Click() Handles mnuFileNew.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing the document.
            If MessageBox.Show("The current document is not saved. " &
            "Are you sure?", "Confirm",
            MessageBoxButtons.YesNo) =
            Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
            ' Document has not changed, so clear it.
            ClearDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click() Handles mnuFileOpen.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " &
             "Are you sure?", "Confirm",
             MessageBoxButtons.YesNo) =
             Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            ' Document has not changed, so replace it.
            ClearDocument()
            OpenDocument()
        End If
    End Sub

    Private Sub mnuFileSave_Click() Handles mnuFileSave.Click
        ' Does the current document have a filename?
        If strFilename = String.Empty Then
            ' The document has not been saved, so
            ' use Save As dialog box.
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            ' Save the document with the current filename.
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click() Handles mnuFileSaveAs.Click
        ' Save the current document under a new filename.
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub
    Private Sub mnuExit_Click() Handles mnuExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click() Handles mnuHelpAbout.Click
        ' Display an about box.
        MessageBox.Show("Cow goes moo.")
    End Sub
End Class
