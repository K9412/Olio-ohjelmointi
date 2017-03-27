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

namespace Labra9T3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int ikkunaLeveys, ikkunaKorkeus, karmiLeveys;

            bool test1 = int.TryParse(txtLeveys.Text, out ikkunaLeveys);
            bool test2 = int.TryParse(txtKorkeus.Text, out ikkunaKorkeus);
            bool test3 = int.TryParse(txtKarmi.Text, out karmiLeveys);

            if (test1 && test2 && test3)
            {
                txtPintaAlaIkkuna.Text = (((ikkunaLeveys + (2 * karmiLeveys)) * (ikkunaKorkeus + (2 * karmiLeveys))) / 10).ToString() + "cm^2";
                txtPintaAlaLasi.Text = ((ikkunaLeveys * ikkunaKorkeus) / 10).ToString() + "cm^2";
                txtKarmiPiiri.Text = (((ikkunaLeveys * 2) + (ikkunaKorkeus * 2)) / 10).ToString() + "cm";
            }
        }
    }
}
