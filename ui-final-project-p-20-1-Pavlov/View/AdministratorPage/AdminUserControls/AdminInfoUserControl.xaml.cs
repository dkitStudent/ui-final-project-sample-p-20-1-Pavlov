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
using ui_final_project_p_20_1_Pavlov.Core;
using ui_final_project_p_20_1_Pavlov.Model;

namespace ui_final_project_p_20_1_Pavlov.View.AdministratorPage.AdminUserControls
{
    /// <summary>
    /// Логика взаимодействия для AdminInfoUserControl.xaml
    /// </summary>
    public partial class AdminInfoUserControl : UserControl
    {
        public AdminInfoUserControl()
        {
            InitializeComponent();
            DataUserInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.FIO).ToList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idUser = (DataUserInfo.SelectedItem as User).UserID;
            var result = MessageBox.Show("Хотите удалить пользователя?", "Системное сообщение", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                User user = (from u in FrameNavigate.DB.Users where u.UserID == idUser select u).SingleOrDefault();
                FrameNavigate.DB.Users.Remove(user);
                FrameNavigate.DB.SaveChanges();
                DataUserInfo.ItemsSource = FrameNavigate.DB.Users.OrderBy(u => u.FIO).ToList();
            }
        }
    }
}
