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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application_kyropatkina.Pages.Pages;

namespace Application_kyropatkina.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_shop_first_page.xaml
    /// </summary>
    public partial class Page_shop_first_page : Page
    {
        public Page_shop_first_page()
        {
            InitializeComponent();
        }

        private void loaded_forma_wpf(object sender, RoutedEventArgs e)
        {
            frame_navigate.Navigate(new Page_list_game());
        }
    }
}
