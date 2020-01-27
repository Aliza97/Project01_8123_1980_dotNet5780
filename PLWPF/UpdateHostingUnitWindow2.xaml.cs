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
    /// Logique d'interaction pour UpdateHostingUnitWindow2.xaml
    /// </summary>
    public partial class UpdateHostingUnitWindow2 : Window
    { 
        BL.IBL bl;
        BE.HostingUnit hosting;
        public UpdateHostingUnitWindow2()
        {
            InitializeComponent();
            hosting = new BE.HostingUnit();
            DataContext = hosting;
            bl = BL.FactoryBL.GetBL();
            
            HostingUnitKey.ItemsSource = bl.GetAllHostingUnits();
            HostingUnitKey.SelectedValuePath = "HostingUnitKey";
        }

        private void HostingUnitKey_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            hosting = bl.GetHostingUnit((int)HostingUnitKey.SelectedValue);
            DataContext = hosting;
            Owner.Text = hosting.Owner.ToString();
            Area.SelectedItem = hosting.area;
            jacuzziOption1.IsChecked = !hosting.jaccuzi;
            jacuzziOption2.IsChecked = !hosting.jaccuzi;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
