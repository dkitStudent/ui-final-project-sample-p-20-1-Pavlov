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
using ui_final_project_p_20_1_Pavlov.Core;
using ui_final_project_p_20_1_Pavlov.Model;
using ui_final_project_p_20_1_Pavlov.View.LoginPage;

namespace ui_final_project_p_20_1_Pavlov.View.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для MainEmployerPage.xaml
    /// </summary>
    public partial class MainEmployerPage : Page
    {
        public MainEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new LoginEmployerPage());
        }

        private void BtnLoginEmployer_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employer employerModel = FrameNavigate.DB.Employers.FirstOrDefault(m => m.CompanyName == TbCompanyName.Text);
                if (employerModel == null) 
                {
                    MessageBox.Show("Ошибка данных", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    BtnCheck.IsEnabled = false;
                    BtnLoginEmployer.IsEnabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
