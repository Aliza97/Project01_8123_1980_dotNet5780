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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void guestRequest_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new GuestRequestWindow();
            w.Show();
        }

        private void addHostingUnit_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new addHostingUnitWindow();
            w.Show();
        }

        private void privateButton_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new privateAreaWindow();
            w.Show();
        }

        private void AllOrdersButton_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new AllOrdersWindow();
            w.Show();
        }

        private void AllHostingButton_Click_2(object sender, RoutedEventArgs e)
        {

            Window w = new AllHostingUnitWindow();
            w.Show();
        }

    }
}
