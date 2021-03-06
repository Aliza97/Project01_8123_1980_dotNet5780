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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for HostingUnitWindow.xaml
    /// </summary>
    public partial class HostingUnitWindow : Window
    {
        public HostingUnitWindow()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Window w = new addHostingUnitWindow();
            w.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Window w = new DeleteHostingUnitWindow();
            w.Show();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            Window w = new UpdateHostingUnitWindow2();
            w.Show();
        }
    }
}
