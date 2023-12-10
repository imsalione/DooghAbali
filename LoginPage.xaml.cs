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

        private void btnSubmitBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtLogin.Password == "123456")
            {
                this.Close();

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                txtAttention.Text = "رمز ورود اشتباه است.";
                txtLogin.IsTabStop = true;
                txtLogin.SelectAll();
            }
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (txtLogin.Password == "123456")
            {
                this.Close();

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                txtAttention.Text = "رمز ورود اشتباه است.";
                txtLogin.IsTabStop = true;
                txtLogin.SelectAll();
            }
        }
    }
}
