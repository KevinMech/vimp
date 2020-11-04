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

namespace vimp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string tempImage {get; set;}

        public MainWindow()
        {
            InitializeComponent();
        }

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
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(openFile.FileName);
                    bitmap.EndInit();
                    pbImage.Source = bitmap;
                    // Clean up temporary image if one already exists
                    if (tempImage != null)
                        File.Delete(tempImage);
                    // Create a temporary copy of the image to make edits on
                    tempImage = Environment.GetEnvironmentVariable("TEMP") + "\\vimpedit_" + openFile.SafeFileName;
                    File.Copy(openFile.FileName, tempImage, true);
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("An error has occured while trying to load your image. Please load a different image or try again!" + Environment.NewLine + "Error Message: " + ex.Message, "Loading image error!", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}
