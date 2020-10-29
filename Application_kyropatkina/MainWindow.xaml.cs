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
using Application_kyropatkina.Pages;

namespace Application_kyropatkina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show_Page_first(object sender, RoutedEventArgs e)
        {
            page_shop.Navigate(new Page_shop_first_page());
        }

        private void show_page_team(object sender, RoutedEventArgs e)
        {
            page_shop.Navigate(new Teams());
        }

        private void show_my_page_library(object sender, RoutedEventArgs e)
        {
            page_shop.Navigate(new Page_library());
        }
    }
}
