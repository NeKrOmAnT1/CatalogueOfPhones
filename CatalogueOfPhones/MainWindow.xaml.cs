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

namespace CatalogueOfPhones
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

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            if(rb_1.IsChecked == true)
            {
                MessageBox.Show("Цена на Samsung Galaxy S21 5G 8/128GB 89990 руб");
            }
            if(rb_2.IsChecked == true)
            {
                MessageBox.Show("Цена на Apple iPhone 12 mini 64GB 64990 руб");
            }
            if(rb_3.IsChecked == true)
            {
                MessageBox.Show("Цена на Samsung Galaxy S9 Plus 64GB 30900 руб");
            }
            if (rb_4.IsChecked == true)
            {
                MessageBox.Show("Цена на OnePlus 8T 8/128GB 42468 руб");
            }
            if (rb_5.IsChecked == true)
            {
                MessageBox.Show("Цена на Apple iPhone 11 128GB 53990 руб");
            }
            if (rb_6.IsChecked == true)
            {
                MessageBox.Show("Цена на Google Pixel 5 8/128GB 58990 руб");
            }
            if (rb_7.IsChecked == true)
            {
                MessageBox.Show("Цена на Poco X3 NFC 6/128GB 19490 руб");
            }
            if (rb_8.IsChecked == true)
            {
                MessageBox.Show("Цена на Xiaomi Redmi Note 8 Pro 6/128GB 18980 руб");
            }
            if (rb_9.IsChecked == true)
            {
                MessageBox.Show("Цена на HONOR 20 6/128GB 24990 руб");
            }
            if (rb_10.IsChecked == true)
            {
                MessageBox.Show("Цена на realme 7 Pro 8/128GB 24600 руб");
            }
        }
    }
}
