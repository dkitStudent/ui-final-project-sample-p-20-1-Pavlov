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

namespace ui_final_project_p_20_1_Pavlov.View.AdministratorPage.AdminUserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoEmployerControl.xaml
    /// </summary>
    public partial class AdminInfoEmployerControl : UserControl
    {
        public AdminInfoEmployerControl()
        {
            InitializeComponent();
            DataEmployerInfo.ItemsSource = FrameNavigate.DB.Employers.OrderBy(w => w.DirectorFIO).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idEmployer = (DataEmployerInfo.SelectedItem as Employer).EmployerID;
            var result = MessageBox.Show("Хотите удалить компанию?", "Системное сообщение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            if (result == MessageBoxResult.Yes)
            {
                Employer employer = (from w in FrameNavigate.DB.Employers where w.EmployerID == idEmployer select w).SingleOrDefault();
                FrameNavigate.DB.Employers.Remove(employer);
                FrameNavigate.DB.SaveChanges();
                DataEmployerInfo.ItemsSource = FrameNavigate.DB.Employers.OrderBy(w => w.DirectorFIO).ToList();
            }
        }
    }
}
