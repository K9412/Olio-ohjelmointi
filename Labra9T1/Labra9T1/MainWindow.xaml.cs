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

namespace Labra9T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int trucks = 0;
        int cars = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTrucks_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            txtTrucks.Text = trucks.ToString();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            txtCars.Text = cars.ToString();
        }
    }
}
