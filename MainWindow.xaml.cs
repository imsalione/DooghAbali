using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DooghAbali
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SolidColorBrush hoverColor = new SolidColorBrush(Colors.LightGray);
        private SolidColorBrush normalColor = new SolidColorBrush(Colors.Gray);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void datetime_Loaded(object sender, RoutedEventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy");
        }

        private void exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("آیا می‌خواهید از برنامه خارج شوید؟", "توجه!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            order.Show();

            this.Close();
        }

        private void btnImsalione_Click(object sender, RoutedEventArgs e)
        {
            string websiteLink = "https://www.imsalione.ir";

            Process.Start(new ProcessStartInfo(websiteLink) { UseShellExecute = true });
        }
    }
}