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
    /// Логика взаимодействия для LoginEmployerPage.xaml
    /// </summary>
    public partial class LoginEmployerPage : Page
    {
        public LoginEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employer userModel = FrameNavigate.DB.Employers.FirstOrDefault(u => u.EmployerMail == TBLogin.Text && u.EmployerPhone == PBPassword.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    FrameNavigate.FrameObject.Navigate(new DetailEmployerPage());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowLoginPage());
        }
    }
}
