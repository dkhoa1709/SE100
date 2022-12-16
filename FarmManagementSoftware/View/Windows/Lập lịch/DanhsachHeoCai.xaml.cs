﻿using FarmManagementSoftware.Model;
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
using System.Windows.Shapes;

namespace FarmManagementSoftware.View.Windows.Lập_lịch
{
    /// <summary>
    /// Interaction logic for DanhsachHeoCai.xaml
    /// </summary>
    public partial class DanhsachHeoCai : Window
    {
        List<HEO> Listheo { get; set; }
        public HEO heo { get; set; }
        public DanhsachHeoCai()
        {
            InitializeComponent();

            Listheo = DataProvider.Ins.DB.HEOs.Where(h => h.LOAIHEO.TenLoaiHeo.Contains("ái")).ToList();
            ListMaHeo_.ItemsSource = Listheo;
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListMaHeo_.SelectedItems.Clear();

            var item = sender as ListViewItem;
            if (item != null)
            {
                item.IsSelected = true;
                ListMaHeo_.SelectedItem = item;
            }
        }

        private void ListViewItem_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ListViewItem item = sender as ListViewItem;
            if (item != null && item.IsSelected)
            {

            }
        }

        private void check_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public string TranferCode()
        {
            heo = (HEO)ListMaHeo_.SelectedItem;
            return heo.MaHeo;
        }
    }
}
