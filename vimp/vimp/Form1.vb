Imports ImageProcessor

Public Class Form1
    Dim imagefactory As ImageFactory = New ImageFactory()
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
            'Create a temporary copy of the image to make edits on
            enableCheckboxes()
            tempImage = Environment.GetEnvironmentVariable("TEMP") + "/vimpedit_" + dialogue.SafeFileName
            My.Computer.FileSystem.CopyFile(dialogue.FileName, tempImage, True)
        End If
    End Sub

    ''' <summary>
    ''' Adjusts the brightness of the image using a trackbar
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub trkBrightness_Scroll(sender As Object, e As EventArgs) Handles trkBrightness.Scroll
        ImageFactory.Load(txtDirectory.Text)
        ImageFactory.Brightness(trkBrightness.Value)
        editedImage = Environment.GetEnvironmentVariable("TEMP") + "/vimpedit_image"
        ImageFactory.Save(tempImage)
        pbImage.ImageLocation = tempImage
    End Sub

    Private Sub trkContrast_Scroll(sender As Object, e As EventArgs) Handles trkContrast.Scroll
        imagefactory.Load(txtDirectory.Text)
        imagefactory.Contrast(trkContrast.Value)
        editedImage = Environment.GetEnvironmentVariable("TEMP") + "/vimpedit_image"
        imagefactory.Save(tempImage)
        pbImage.ImageLocation = tempImage
    End Sub

    ''' <summary>
    ''' Checks if brightness checkbox is checked, and enables/disables the trackbar accordingly
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub cbBrightness_CheckedChanged(sender As Object, e As EventArgs) Handles cbBrightness.CheckedChanged
        If cbBrightness.Checked Then
            trkBrightness.Enabled = True
        Else
            trkBrightness.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Checks if contrast checkbox is checked, and enables/disables the trackbar accordingly
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub cbContrast_CheckedChanged(sender As Object, e As EventArgs) Handles cbContrast.CheckedChanged
        If cbContrast.Checked Then
            trkContrast.Enabled = True
        Else
            trkContrast.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Enable all checkboxes in the form
    ''' </summary>
    Private Sub enableCheckboxes()
        cbBrightness.Enabled = True
        cbContrast.Enabled = True
    End Sub

End Class
