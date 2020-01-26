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
    /// Logique d'interaction pour addGuestRequestWindow.xaml
    /// </summary>
    public partial class addGuestRequestWindow : Window
    {
        BL.IBL bl;
        BE.GuestRequest myguestRequest;
        public addGuestRequestWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            myguestRequest = new BE.GuestRequest();
            DataContext = myguestRequest;
            this.Area.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Area));
           // this.SubArea.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.s));
            this.Type.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Type));

            this.pool.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Pool));
            this.garden.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Garden));
            this.jaccuzi.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Jacuzzi));
            this.childrenAttractions.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.ChildrenAttractions));

        }

        public int GetA8digitNumber()
        {
            Random r = new Random();
            int num = r.Next(10000000, 99999999);
            return num;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = myguestRequest;
            myguestRequest.GuestRequestKey = GetA8digitNumber();
            try
            {
                bl.AddGuestRequest(myguestRequest);
                MessageBox.Show("בקשתך התקבלה", "הצלחה", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "הודעת שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }        

      
      
     
        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
