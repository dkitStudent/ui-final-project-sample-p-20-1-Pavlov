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
    /// Логика взаимодействия для AdminInfoOrderControl.xaml
    /// </summary>
    public partial class AdminInfoOrderControl : UserControl
    {
        public AdminInfoOrderControl()
        {
            InitializeComponent();
            DataOrderInfo.ItemsSource = FrameNavigate.DB.OrderBoards.OrderBy(w => w.OrderBoardID).ToList();
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            int idOrder = (DataOrderInfo.SelectedItem as OrderBoard).OrderBoardID;
            var result = MessageBox.Show("Хотите удалить заказ?", "Системное сообщение", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                OrderBoard orderBoard = (from b in FrameNavigate.DB.OrderBoards where b.OrderBoardID == idOrder select b).SingleOrDefault();
                FrameNavigate.DB.OrderBoards.Remove(orderBoard);
                FrameNavigate.DB.SaveChanges();
                DataOrderInfo.ItemsSource = FrameNavigate.DB.OrderBoards.OrderBy(w => w.OrderBoardID).ToList();
            }
        }
    }
}
