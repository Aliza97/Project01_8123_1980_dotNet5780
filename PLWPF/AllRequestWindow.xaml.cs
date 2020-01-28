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
    /// Interaction logic for AllRequestWindow.xaml
    /// </summary>
    public partial class AllRequestWindow : Window
    {

        BL.IBL bl = BL.FactoryBL.GetBL();
        public AllRequestWindow()
        {
            InitializeComponent();
            this.RequestsDataGrid.ItemsSource = bl.GetAllRequests();
        }

        //    private void AllRequestsButton_Click(object sender, RoutedEventArgs e)
        //    {
        //        try
        //        {
        //            IEnumerable<BE.GuestRequest> guestrequests = bl.GetAllRequests();
        //            foreach (BE.GuestRequest guestrequest in guestrequests)
        //             {
        //                this.AllRequests.Content += guestrequests.ToString();
        //                this.AllRequests.Content += "*********************\n";
        //               }

        //         }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }

        //    }
        //}
    }
}
