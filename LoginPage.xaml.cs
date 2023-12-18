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
using System.Windows.Shapes;

namespace DooghAbali
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            pswLogin.Password = "8080";
            string pswEntered = pswLogin.Password;
            if (pswEntered == "8080")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                txtAttention.Text = "";

                this.Close();
            }
            else
            {
                pswLogin.SelectAll();
                pswLogin.Focus();
                txtAttention.Text = "رمز ورود اشتباه است!";
            }
        }

        private void pswLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Password == "رمز عبور را وارد کنید...")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = System.Windows.Media.Brushes.Black; // تغییر رنگ متن به سیاه
            }
        }

        private void pswLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = "Enter password here...";
                passwordBox.Foreground = System.Windows.Media.Brushes.Gray; // تغییر رنگ متن به خاکستری
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pswLogin.Focus();
        }
    }
}
