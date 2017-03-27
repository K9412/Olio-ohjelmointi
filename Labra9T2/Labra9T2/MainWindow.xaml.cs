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

namespace Labra9T2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double eurot, markat;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtMarkat_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool test = double.TryParse(txtMarkat.Text, out markat);
            if (!test)
            {
                txtMarkat.Text = "Koita uudestaan";
            }
        }
        private void txtEurot_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool test = double.TryParse(txtEurot.Text, out eurot);
            if (!test)
            {
                txtEurot.Text = "Koita uudestaan";
            }
        }
        private void btnEuroiksi_Click(object sender, RoutedEventArgs e)
        {
            txtEurot.Text = (markat / 6).ToString("0.00");
        }
        private void btmMarkoiksi_Click(object sender, RoutedEventArgs e)
        {
            txtMarkat.Text = (eurot * 6).ToString("0.00");
        }
    }
}
