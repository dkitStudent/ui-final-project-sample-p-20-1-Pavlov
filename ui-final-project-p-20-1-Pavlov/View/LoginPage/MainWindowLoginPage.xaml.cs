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
using ui_final_project_p_20_1_Pavlov.View.EmployerPage;

namespace ui_final_project_p_20_1_Pavlov.View.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для MainWindowLoginPage.xaml
    /// </summary>
    public partial class MainWindowLoginPage : Page
    {
        public MainWindowLoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userModel = FrameNavigate.DB.Users.FirstOrDefault(u => u.UserMail == TbLogin.Text && u.UserPhone == PsbPassword.Password);
                if (userModel == null)
                {
                    MessageBox.Show("Ошибка данных", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userModel.RoleID)
                    {
                        case 1:
                            //FrameNavigate.FrameObject.Navigate(new MainAdministratorPage());
                        case 2:
                            //FrameNavigate.FrameObject.Navigate(new MainUserPage());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void BtnWork_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainEmployerPage());
        }

        private void BtnRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new MainWindowRegistrationPage());
        }
    }
}
