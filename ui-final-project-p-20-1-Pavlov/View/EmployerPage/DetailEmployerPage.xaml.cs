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

namespace ui_final_project_p_20_1_Pavlov.View.EmployerPage
{
    /// <summary>
    /// Логика взаимодействия для DetailEmployerPage.xaml
    /// </summary>
    public partial class DetailEmployerPage : Page
    {
        public DetailEmployerPage()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBTitle.Text) || string.IsNullOrEmpty(TBTime.Text) || string.IsNullOrEmpty(TBOrder.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Заказ №15 отправлен на модерирование", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                ClearTextBox();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.FrameObject.Navigate(new LoginEmployerPage());
        }
        private void ClearTextBox()
        {
            TBTitle.Text = string.Empty;
            TBOrder.Text = string.Empty;
            TBTime.Text = string.Empty;
        }
    }
}
