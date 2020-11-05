using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System.Net.Cache;

namespace vimp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<ImageEffect, double> edits = new Dictionary<ImageEffect, double>();
        private string origImage { get; set; }
        private string tempImage {get; set;}

        enum ImageEffect
        {
            Brightness,
            Contrast,
            Saturation
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used to locate the image to edit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            //Configure openfiledialog object
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select Image to Edit";
            openFile.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg";

            try
            {
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Insert Bitmap into Image Component
                    updateImage(openFile.FileName);
                    // Clean up temporary image if one already exists
                    if (tempImage != null)
                        File.Delete(tempImage);
                    // Create a temporary copy of the image to make edits on
                    tempImage = Environment.GetEnvironmentVariable("TEMP") + "\\vimpedit_" + openFile.SafeFileName;
                    File.Copy(openFile.FileName, tempImage, true);
                    origImage = openFile.FileName;
                }
        }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An error has occured while trying to load your image. Please load a different image or try again!" + Environment.NewLine + "Error Message: " + ex.Message, "Loading image error!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
}

        /// <summary>
        /// Checks if brightness checkbox is checked, and enables the trackbar accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBrightness_Checked(object sender, RoutedEventArgs e)
        {
            edits.Add(ImageEffect.Brightness, 50);
            trkBrightness.Value = 50;
            trkBrightness.IsEnabled = true;
            updateEffects(tempImage);
            updateImage(tempImage);
        }

        /// <summary>
        /// Checks if brightness checkbox is unchecked, and disables the trackbar accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBrightness_Unchecked(object sender, RoutedEventArgs e)
        {
            edits.Remove(ImageEffect.Brightness);
            trkBrightness.IsEnabled = false;
            updateEffects(tempImage);
            updateImage(tempImage);
        }

        private void trkBrightness_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            edits[ImageEffect.Brightness] = trkBrightness.Value;
            updateEffects(tempImage);
            updateImage(tempImage);
        }

        /// <summary>
        /// Draws the effects onto temporary image before final save
        /// </summary>
        /// <param name="tempLocation">file location of the temp image to save to</param>
        private void updateEffects(string tempLocation)
        {
            using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(origImage))
            {
                // For each edit made by user, apply the effect to the temporary image 
                foreach (KeyValuePair<ImageEffect, double> edit in edits)
                {
                    if (edits.ContainsKey(ImageEffect.Brightness))
                        image.Mutate(x => x.Brightness((float)edits[ImageEffect.Brightness]));
                }
                image.Save(tempLocation);
            }
        }

        /// <summary>
        /// Updates the temporary image shown in imagebox before final save
        /// </summary>
        /// <param name="tempLocation"></param>
        private void updateImage(string tempLocation)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.None;
            image.UriCachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            image.UriSource = new Uri(tempLocation, UriKind.RelativeOrAbsolute);
            image.EndInit();
            pbImage.Source = image;
        }
    }
}
