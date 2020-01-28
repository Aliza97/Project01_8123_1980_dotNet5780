using System.Windows;

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour privateAreaWindow.xaml
    /// </summary>
    public partial class privateAreaWindow : Window
    {
        BL.IBL bl;
        //BE.GuestRequest myguestRequest;
        public privateAreaWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            //myguestRequest = new BE.GuestRequest();
            //DataContext = myguestRequest;

            //AddOrder.Visibility = Visibility.Hidden;
            //UpdateOrder.Visibility = Visibility.Hidden;
            //OrdersList.Visibility = Visibility.Hidden;
            //GuestRequestList.Visibility = Visibility.Hidden;
        }

        private void hostingunit_Click(object sender, RoutedEventArgs e)
        {
            Window w = new UpdateHostingUnitWindow2();
            w.Show();
        }

        private void deleteHu_Click(object sender, RoutedEventArgs e)
        {
            Window w = new DeleteHostingUnitWindow();
            w.Show();
        }

        private void allguestr_Click(object sender, RoutedEventArgs e)
        {
            Window w = new AllRequestWindow();
            w.Show();



            //    IEnumerable<BE.GuestRequest> guestrequests = bl.GetAllRequests();
            //    foreach (BE.GuestRequest myguestRequest in guestrequests)
            //    {
            //        this. .Content += guestrequests.ToString();
            //        this.Content += "*********************\n";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            Window w = new addOrderWindow();
            w.Show();
        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            Window w = new UpdateOrderWindow();
            w.Show();
        }

        private void OrdersList_Click(object sender, RoutedEventArgs e)
        {
            Window w = new AllOrdersWindow();
            w.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new AllHostingUnitWindow();
            w.Show();

        }

       
    }
    }

