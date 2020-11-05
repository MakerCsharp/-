using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using static Application_kyropatkina.librarys.Data_base;

namespace Application_kyropatkina.Pages.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_list_game.xaml
    /// </summary>
    public partial class Page_list_game : Page
    {
        public Page_list_game()
        {
            InitializeComponent();
            
            ListView_frame_list_game.ItemsSource = contex.Games.ToList();
        }

        private void Button_game_show(object sender, RoutedEventArgs e)
        {

        }
    }
}
