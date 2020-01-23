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

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for addOrder.xaml
    /// </summary>
    public partial class addOrder : Page
    {
        BL.IBL bl;
        BE.Order myOrder;
        public addOrder()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            myOrder = new Order();
            DataContext = myOrder;
            //x.ItemsSource = Enum.GetValues(typeof(BE.x));
            //y.ItemsSource = Enum.GetValues(typeof(BE.y));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
