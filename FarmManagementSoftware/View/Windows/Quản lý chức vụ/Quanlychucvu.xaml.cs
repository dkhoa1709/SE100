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
using System.Windows.Shapes;

namespace FarmManagementSoftware.View.Windows.Quản_lý_chức_vụ
{
    /// <summary>
    /// Interaction logic for Quanlychucvu.xaml
    /// </summary>
    public partial class Quanlychucvu : Window
    {
        public Quanlychucvu()
        {
            InitializeComponent();
        }

        private void btn_ThemClick(object sender, RoutedEventArgs e)
        {
            ThemChucVu themChucVu = new ThemChucVu();
            themChucVu.ShowDialog();
        }
    }
}
