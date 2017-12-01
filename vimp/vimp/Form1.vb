Imports ImageProcessor

Public Class Form1
    Dim tempImage As String

    ''' <summary>
    ''' Used to locate the file for editing the image.
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim dialogue As OpenFileDialog = New OpenFileDialog
        dialogue.Title = "Select Image to Edit"
        If dialogue.ShowDialog() = DialogResult.OK Then
            pbImage.Image = Image.FromFile(dialogue.FileName)
            txtDirectory.Text = dialogue.FileName
            'Clean up temporary image if one already exists
            If tempImage IsNot vbNullString Then
                My.Computer.FileSystem.DeleteFile(tempImage)
            End If
            'Create a copy of the image to make edits on
            tempImage = Environment.GetEnvironmentVariable("TEMP") + "/vimpedit_" + dialogue.SafeFileName
            My.Computer.FileSystem.CopyFile(dialogue.FileName, tempImage, True)
        End If
    End Sub

    Private Sub trkBrightness_Scroll(sender As Object, e As EventArgs) Handles trkBrightness.Scroll
        Dim imagefactory As ImageFactory = New ImageFactory()
        imagefactory.Load(tempImage)
        imagefactory.Brightness(trkBrightness.Value)
        imagefactory.Save(tempImage)
        pbImage.ImageLocation = tempImage
    End Sub
End Class
