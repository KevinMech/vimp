Imports ImageProcessor

Public Class Form1
    Dim imagefactory As ImageFactory = New ImageFactory()
    Dim edits As Dictionary(Of ImageEdits, Integer) = New Dictionary(Of ImageEdits, Integer)
    Dim tempImage As String

    Enum ImageEdits
        Brightness
        Contrast
    End Enum

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
            tempImage = Environment.GetEnvironmentVariable("TEMP") + "/vimpedit_" + dialogue.SafeFileName
            My.Computer.FileSystem.CopyFile(dialogue.FileName, tempImage, True)
            enableCheckboxes()
        End If
    End Sub

    ''' <summary>
    ''' Checks if brightness checkbox is checked, and enables/disables the trackbar accordingly
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub cbBrightness_CheckedChanged(sender As Object, e As EventArgs) Handles cbBrightness.CheckedChanged
        If cbBrightness.Checked Then
            edits.Add(ImageEdits.Brightness, trkBrightness.Value)
            trkBrightness.Enabled = True
        Else
            edits.Remove(ImageEdits.Brightness)
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
            edits.Add(ImageEdits.Contrast, trkContrast.Value)
            trkContrast.Enabled = True
        Else
            edits.Remove(ImageEdits.Contrast)
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

    ''' <summary>
    ''' Adjusts the brightness of the image using a trackbar
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub trkBrightness_Scroll(sender As Object, e As EventArgs) Handles trkBrightness.Scroll
        edits(ImageEdits.Brightness) = trkBrightness.Value
        updateImage()
    End Sub

    ''' <summary>
    ''' Adjusts the contrast of the image using a trackbar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub trkContrast_Scroll(sender As Object, e As EventArgs) Handles trkContrast.Scroll
        edits(ImageEdits.Contrast) = trkContrast.Value
        updateImage()
    End Sub

    ''' <summary>
    ''' Updates the temporary image shown in imagebox before final save
    ''' </summary>
    Private Sub updateImage()
        imagefactory.Load(txtDirectory.Text)
        'For each edit made by user, apply the effect to the temporary image 
        For Each edit In edits
            If edit.Key = ImageEdits.Brightness Then
                imagefactory.Brightness(edit.Value)
            ElseIf edit.Key = ImageEdits.Contrast Then
                imagefactory.Contrast(edit.Value)
            End If
        Next
        imagefactory.Save(tempImage)
        pbImage.ImageLocation = tempImage
    End Sub
End Class
