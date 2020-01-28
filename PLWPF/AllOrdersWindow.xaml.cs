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

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour AllOrdersWindow.xaml
    /// </summary>
    public partial class AllOrdersWindow : Window
    {
        BL.IBL bl = BL.FactoryBL.GetBL();
        public AllOrdersWindow()
        {
            InitializeComponent();
            //DataContext = bl.GetAllOrders();
            this.OrdersDataGrid.ItemsSource = bl.GetAllOrders();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{

        //    System.Windows.Data.CollectionViewSource orderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderViewSource")));
        //    // Charger les données en définissant la propriété CollectionViewSource.Source :
        //    // orderViewSource.Source = [source de données générique]
        //}
    }
}
