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
    /// Logique d'interaction pour UpdateOrderWindow.xaml
    /// </summary>
    public partial class UpdateOrderWindow : Window
    {
        BL.IBL bl;
        BE.Order myOrder;
        public UpdateOrderWindow()
        {
            InitializeComponent();
            myOrder = new BE.Order();
            bl = BL.FactoryBL.GetBL();
            DataContext = myOrder;
            this.Status.ItemsSource = Enum.GetValues(typeof(BE.MyEnums.Status));
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            DataContext = myOrder;

            try
            {
                bl.UpdateOrder(myOrder, (BE.MyEnums.Status)Status.SelectedItem);
                MessageBox.Show(" הזמנתך עודכנה", "הצלחה", MessageBoxButton.OK, MessageBoxImage.Information);
                //this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "הודעת שגיאה", MessageBoxButton.OK, MessageBoxImage.Warning); }
        }
    }
    }

