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
    /// Interaction logic for addGuestRequest.xaml
    /// </summary>
    public partial class addGuestRequest : Page
    {
        BL.IBL bl;
        BE.GuestRequest myguestRequest;
        public addGuestRequest()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            myguestRequest = new BE.GuestRequest();
            DataContext = myguestRequest;
            //x.ItemsSource = Enum.GetValues(typeof(BE.x));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = myguestRequest;
            try
            {
                bl.AddGuestRequest(myguestRequest);
                MessageBox.Show("בקשתך התקבלה", "הצלחה", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "הודעת שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }

 

        private void lastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void firstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SubArea_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
