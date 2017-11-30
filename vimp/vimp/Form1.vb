Public Class Form1

    ''' <summary>
    ''' Used to locate the file for editing the image
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim dialogue As OpenFileDialog = New OpenFileDialog
        dialogue.Title = "Select Image to Edit"
        If dialogue.ShowDialog() = DialogResult.OK Then
            pbImage.Image = Image.FromFile(dialogue.FileName)
            txtDirectory.Text = dialogue.FileName
        End If
    End Sub
End Class
