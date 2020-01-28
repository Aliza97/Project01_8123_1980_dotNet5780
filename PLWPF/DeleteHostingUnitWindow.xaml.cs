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
    /// Logique d'interaction pour DeleteHostingWindow.xaml
    /// </summary>
    public partial class DeleteHostingUnitWindow : Window
    {
        BL.IBL bl;
        BE.HostingUnit hosting;
        public DeleteHostingUnitWindow()
        {
            InitializeComponent();
            hosting = new BE.HostingUnit();
            DataContext = hosting;
            bl = BL.FactoryBL.GetBL();
            this.HostingUnitKey.ItemsSource = bl.GetAllHostingUnits(); //Enum.GetValues(typeof(hostingunitList));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = hosting;
            try
            {
                bl.DeleteHostingUnit(hosting.HostingUnitKey);
                MessageBox.Show("הזמנתך נמחקה", "הצלחה", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "הודעת שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning); }
       
    }
    }
}
