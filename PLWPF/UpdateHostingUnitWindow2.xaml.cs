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
            //HostingUnitKey.SelectedValuePath = "HostingUnitKey";



        }

        private void HostingUnitKey_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String[] help = HostingUnitKey.SelectedValue.ToString().Split(' ');
            String h = help[0];
            hosting = bl.GetHostingUnit(Int32.Parse(h));
            DataContext = hosting;
            //Owner.Text = hosting.Owner.FamilyName.ToString();
            HostingUnitName.Text = hosting.HostingUnitName.ToString();
            subArea.Text = hosting.subArea.ToString();
            adults.Text = hosting.adults.ToString();
            kids.Text = hosting.kids.ToString();
            Area.SelectedItem = hosting.area;
            jacuzziOption1.IsChecked = !hosting.jaccuzi;
            gardenOption1.IsChecked = !hosting.garden;
            attractionOption1.IsChecked = !hosting.childrenAttractions;
            poolOption1.IsChecked = !hosting.pool;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {

            //hosting.HostingUnitName = this.HostingUnitName.Text;
            //hosting.HostingUnitKey = this.HostingUnitKey.SelectedItem;
            //hosting.Owner = x.Owner;
            //hosting.area = this.area.SelectedItem;
            //hosting.pool = (BE.Pool)this.PoolComboxBox.SelectedItem;
            //hosting.garden = (BE.garden)this.garden.SelectedItem;
            //hosting.adults = int.Parse(adults.Text);
            //hosting.kids = int.Parse(kids.Text);
            //hosting.childrensAttractions = (BE.ChildrensAttractions)this.ChildrensAttractionComboxBox.SelectedItem;
            String[] help = HostingUnitKey.SelectedValue.ToString().Split(' ');
            String h = help[0];
            hosting = bl.GetHostingUnit(Int32.Parse(h));
          
            DataContext = hosting;
            //Owner.Text = hosting.Owner.ToString();
            HostingUnitName.Text = hosting.HostingUnitName.ToString();
            subArea.Text = hosting.subArea.ToString();
            adults.Text = hosting.adults.ToString();
            kids.Text = hosting.kids.ToString();
            Area.SelectedItem = hosting.area;
            jacuzziOption1.IsChecked = !hosting.jaccuzi;
            gardenOption1.IsChecked = !hosting.garden;
            attractionOption1.IsChecked = !hosting.childrenAttractions;
            poolOption1.IsChecked = !hosting.pool;


           
            this.DataContext = hosting;
            

            try
            {
                bl.UpdateHostingUnit(hosting);
                MessageBox.Show("יחדת ארוח שלך עודכנה", "הצלחה", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "הודעת שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
    }
}
