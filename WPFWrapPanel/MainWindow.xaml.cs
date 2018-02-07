using System.Windows;
using System.Windows.Input;

namespace WrapPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handling that posts the mouse x, y position in title
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            usersName = UsersName.Text;

            MessageBox.Show($"Hello {usersName}");
        }
    }
}
