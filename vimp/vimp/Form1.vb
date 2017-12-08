Imports ImageProcessor

Public Class MainMenu
    Dim imagefactory As ImageFactory = New ImageFactory()
    Dim edits As Dictionary(Of ImageEffect, Integer) = New Dictionary(Of ImageEffect, Integer)
    Dim tempImage As String

    Enum ImageEffect
        Brightness
        Contrast
        Saturation
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
            edits.Add(ImageEffect.Brightness, trkBrightness.Value)
            trkBrightness.Enabled = True
            updateImage()
        Else
            edits.Remove(ImageEffect.Brightness)
            trkBrightness.Enabled = False
            updateImage()
        End If
    End Sub

    ''' <summary>
    ''' Checks if contrast checkbox is checked, and enables/disables the trackbar accordingly
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub cbContrast_CheckedChanged(sender As Object, e As EventArgs) Handles cbContrast.CheckedChanged
        If cbContrast.Checked Then
            edits.Add(ImageEffect.Contrast, trkContrast.Value)
            trkContrast.Enabled = True
            updateImage()
        Else
            edits.Remove(ImageEffect.Contrast)
            trkContrast.Enabled = False
            updateImage()
        End If
    End Sub

    ''' <summary>
    ''' Checks if saturation checkbox is checked, and enables/disables the trackbar accordingly
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub cbSaturation_CheckedChanged(sender As Object, e As EventArgs) Handles cbSaturation.CheckedChanged
        If cbSaturation.Checked Then
            edits.Add(ImageEffect.Saturation, trkSaturation.Value)
            trkSaturation.Enabled = True
            updateImage()
        Else
            edits.Remove(ImageEffect.Saturation)
            trkSaturation.Enabled = False
            updateImage()
        End If
    End Sub

    ''' <summary>
    ''' Enable all checkboxes in the form
    ''' </summary>
    Private Sub enableCheckboxes()
        cbBrightness.Enabled = True
        cbContrast.Enabled = True
        cbSaturation.Enabled = True
        grpSave.Enabled = True
    End Sub

    ''' <summary>
    ''' Adjusts the brightness of the image using a trackbar
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub trkBrightness_Scroll(sender As Object, e As EventArgs) Handles trkBrightness.Scroll
        edits(ImageEffect.Brightness) = trkBrightness.Value
        lblBrightness.Text = trkBrightness.Value.ToString() + "%"
        updateImage()
    End Sub

    ''' <summary>
    ''' Adjusts the contrast of the image using a trackbar
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub trkContrast_Scroll(sender As Object, e As EventArgs) Handles trkContrast.Scroll
        edits(ImageEffect.Contrast) = trkContrast.Value
        lblContrast.Text = trkContrast.Value.ToString() + "%"
        updateImage()
    End Sub

    ''' <summary>
    ''' Adjusts the saturation of the image using a trackbar
    ''' </summary>
    ''' <param name="sender">sender</param>
    ''' <param name="e">event</param>
    Private Sub trkSaturation_Scroll(sender As Object, e As EventArgs) Handles trkSaturation.Scroll
        edits(ImageEffect.Saturation) = trkSaturation.Value
        lblSaturation.Text = trkSaturation.Value.ToString() + "%"
        updateImage()
    End Sub

    ''' <summary>
    ''' Updates the temporary image shown in imagebox before final save
    ''' </summary>
    Private Sub updateImage()
        imagefactory.Load(txtDirectory.Text)
        'For each edit made by user, apply the effect to the temporary image 
        For Each edit In edits
            If edit.Key = ImageEffect.Brightness Then
                imagefactory.Brightness(edit.Value)
            ElseIf edit.Key = ImageEffect.Contrast Then
                imagefactory.Contrast(edit.Value)
            ElseIf edit.Key = ImageEffect.Saturation Then
                imagefactory.Saturation(edit.Value)
            End If
        Next
        imagefactory.Save(tempImage)
        pbImage.ImageLocation = tempImage
    End Sub

End Class
