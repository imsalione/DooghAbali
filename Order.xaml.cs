using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();

            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1001, ProductCategory = 100,Title = "دوغ یک لیتری", Count = 50, Price = "500,000 Rial", Description = "دوغ یک لیتری آبعلی" },
                new Product { ProductId = 1001, ProductCategory = 100,Title = "دوغ دو لیتری", Description = "دوغ دو لیتری آبعلی" },
                new Product { ProductId = 1001, ProductCategory = 100,Title = "دوغ سه لیتری", Description = "دوغ سه لیتری آبعلی" }
            };

            // متصل کردن محصولات به DataGrid
            dataGridProducts.ItemsSource = products;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PopulateStatesComboBox();

            if (cmbState.Items.Count > 0)
            {
                cmbState.SelectedIndex = 0;
                cmbCity.SelectedIndex = 0;
                cmbIdCustomer.SelectedIndex = 0;
            }
        }

        private void PopulateStatesComboBox()
        {
            string[] iranianStates = new string[]
            {
                "آذربایجان شرقی",
                "آذربایجان غربی",
                "اردبیل",
                "اصفهان",
                "البرز",
                "ایلام",
                "بوشهر",
                "تهران",
                "چهارمحال و بختیاری",
                "خراسان جنوبی",
                "خراسان رضوی",
                "خراسان شمالی",
                "خوزستان",
                "زنجان",
                "سمنان",
                "سیستان و بلوچستان",
                "فارس",
                "قزوین",
                "قم",
                "کردستان",
                "کرمان",
                "کرمانشاه",
                "کهگیلویه و بویراحمد",
                "گلستان",
                "گیلان",
                "لرستان",
                "مازندران",
                "مرکزی",
                "هرمزگان",
                "همدان",
                "یزد"
            };

            foreach (var state in iranianStates)
            {
                cmbState.Items.Add(state);
            }
        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string websiteLink = "https://www.imsalione.ir";

            Process.Start(new ProcessStartInfo(websiteLink) { UseShellExecute = true });
        }

        private void datetime_Loaded(object sender, RoutedEventArgs e)
        {
            datetime.Text = DateTime.Now.ToString("dddd، dd MMMM yyyy");
        }

        private void cmbState_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbCity.Items.Clear();

            if (cmbState.Items.Count > 0)
            {
                cmbCity.SelectedIndex = 0;
            }

            switch (cmbState.SelectedItem.ToString())
            {
                case "آذربایجان شرقی":
                    cmbCity.Items.Add("تبریز");
                    cmbCity.Items.Add("تسوج");
                    cmbCity.Items.Add("مراغه");
                    cmbCity.Items.Add("میانه");
                    break;

                case "آذربایجان غربی":
                    cmbCity.Items.Add("ارومیه");
                    cmbCity.Items.Add("خوی");
                    cmbCity.Items.Add("مهاباد");
                    cmbCity.Items.Add("سلماس");
                    break;
            }
        }

        public class Product
        {
            public int ProductId { get; set; }
            public int ProductCategory { get; set; }
            public string Title { get; set; }
            public int Count { get; set; }
            public string Price { get; set; }
            public string Description { get; set; }
        }


        private void cmbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbIdCustomer.Items.Clear();

            if (cmbIdCustomer.Items.Count == 0)
            {
                cmbIdCustomer.SelectedIndex = 0;
            }

            switch (cmbCity.SelectedItem.ToString())
            {
                case "تبریز":
                    cmbIdCustomer.Items.Add(1001001);
                    break;

                case "تسوج":
                    cmbIdCustomer.Items.Add(1001002);
                    break;
            }
        }
    }
}
