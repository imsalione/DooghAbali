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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void datetime_Loaded(object sender, RoutedEventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy");
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