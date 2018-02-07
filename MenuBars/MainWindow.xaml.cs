using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;

namespace MenuBars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Closes the app
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Opens the open dialog
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        // Opens the save dialog
        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        // Unchecks other fonts and changes font for the text box
        private void MenuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void MenuFontCourier_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Courier");
        }

        private void MenuFontArial_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontTimes.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Arial");
        }

        //Stole code from here https://msdn.microsoft.com/en-us/library/system.windows.controls.menuitem.click(v=vs.110).aspx

        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxDoc.FontWeight = FontWeights.Bold;
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBoxDoc.FontWeight = FontWeights.Normal;
        }

        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            txtBoxDoc.FontStyle = FontStyles.Italic;
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            txtBoxDoc.FontStyle = FontStyles.Normal;
        }

        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxDoc.FontSize < 18)
            {
                txtBoxDoc.FontSize += 2;
            }
        }

        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxDoc.FontSize > 10)
            {
                txtBoxDoc.FontSize -= 2;
            }
        }

    }
}
