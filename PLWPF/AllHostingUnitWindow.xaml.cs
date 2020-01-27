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
    /// Logique d'interaction pour AllHostingUnitWindow.xaml
    /// </summary>
    public partial class AllHostingUnitWindow : Window
    {
        BL.IBL bl = BL.FactoryBL.GetBL();
            public AllHostingUnitWindow()
        {
            InitializeComponent();
            DataContext = bl.GetAllHostingUnits();
        }

     
    }
}
