﻿using System;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Password == "123456")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                txtAttention.Text = "";

                this.Close();
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    txtLogin.SelectAll();
                    txtLogin.Focus();
                    txtAttention.Text = "رمز ورود اشتباه است";
                }
            }
            
        }
    }
}
