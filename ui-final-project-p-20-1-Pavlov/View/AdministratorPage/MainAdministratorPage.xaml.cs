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

namespace ui_final_project_p_20_1_Pavlov.View.AdministratorPage
{
    /// <summary>
    /// Логика взаимодействия для MainAdministratorPage.xaml
    /// </summary>
    public partial class MainAdministratorPage : Page
    {
        public MainAdministratorPage()
        {
            InitializeComponent();
        }

        private void MenuItemUser_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            //GridContentLoad.Children.Add(new AdminInfoUserControl());
        }

        private void MenuItemEmployer_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            //GridContentLoad.Children.Add(new AdminInfoEmployerControl());
        }
        private void MenuItemOrder_Click(object sender, RoutedEventArgs e)
        {
            GridContentLoad.Children.Clear();
            //GridContentLoad.Children.Add(new AdminInfoOrderControl());
        }
    }
}