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
    /// Logique d'interaction pour addHostingUnitWindow.xaml
    /// </summary>
    public partial class addHostingUnitWindow : Window
    {
        BL.IBL bl;
        BE.HostingUnit hosting;
        public addHostingUnitWindow()
        {

            InitializeComponent();
            hosting = new BE.HostingUnit();
            DataContext = hosting;
            bl = BL.FactoryBL.GetBL();
            this.Area.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Area));

        }
        public int GetA8digitNumber()
        {
            Random r = new Random();
            int num = r.Next(10000000, 99999999);
            return num;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            DataContext = hosting;
            hosting.adults = Int32.Parse(adults.Text.ToString());
            hosting.kids = Int32.Parse(kids.Text.ToString());
            hosting.stars = Int32.Parse(stars.Text.ToString());
            do {
                hosting.HostingUnitKey = GetA8digitNumber(); 
            
            } while (bl.GetHostingUnit(hosting.HostingUnitKey) != null);

            if (jacuzziOption1.IsChecked == false)
                 hosting.jaccuzi =false;
            else
                hosting.jaccuzi = true;

            hosting.garden = (gardenOption1.IsChecked == false);
            hosting.pool = (poolOption1.IsChecked == false);
            hosting.childrenAttractions =( attractionOption1.IsChecked == false);


            hosting.HostingUnitName = HostingUnitName.Text;
            //hosting.Owner.FamilyName = Owner.Text;
            hosting.subArea = subArea.Text;


                bl.AddHostingUnit(hosting);

            MessageBoxResult result = MessageBox.Show("Thank You, your unit has been added. Would you like to add another hosting unit?", "Status", MessageBoxButton.YesNo, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    Window addHostingUnitWindow = new addHostingUnitWindow();
                    addHostingUnitWindow.Show();
                    break;
                case MessageBoxResult.No:
                    this.Close();
                    break;
            }
            this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        }
    }

