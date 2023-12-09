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
        private bool isMouseCaptured;
        private double offsetX, offsetY;

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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string websiteLink = "https://www.imsalione.ir";

            Process.Start(new ProcessStartInfo(websiteLink) { UseShellExecute = true });
        }

        private void dragBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseCaptured)
            {
                // جابجایی فرم به موقعیت جدید موس
                Point position = e.GetPosition(this);
                Left = position.X - offsetX;
                Top = position.Y - offsetY;
            }
        }

        private void dragBorder_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isMouseCaptured)
            {
                // آزاد کردن موس
                dragBorder.ReleaseMouseCapture();
                isMouseCaptured = false;
            }
        }

        private void dragBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!isMouseCaptured)
            {
                // نگه‌داشتن موس توسط فرم
                dragBorder.CaptureMouse();
                isMouseCaptured = true;

                // محاسبه افست موس نسبت به ابتدای فرم
                Point position = e.GetPosition(this);
                offsetX = position.X - Left;
                offsetY = position.Y - Top;
            }
        }
    }
}