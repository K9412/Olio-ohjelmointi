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

namespace Labra10T4
{
    class Kiuas
    {
        private double temperature, humidity;
        public double Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value >= 0.00 && value <= 120.00)
                {
                    temperature = value;
                }
                else
                {
                    temperature = 0.00;
                }
            }
        }
        public double Humidity
        {
            get
            {
                return humidity;
            }
            set
            {
                if (value <= 100.00 && value >= 0.00)
                {
                    humidity = value;
                }
                else
                {
                    humidity = 0.00;
                }
            }
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kiuas kiuas = new Kiuas();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text += (((Button)sender).Content).ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1);
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            double number = 0;
            if ((bool)rdbTemperature.IsChecked)
            {
                double.TryParse(txtValue.Text, out number);
                kiuas.Temperature = number;
                lblTemperature.Content = kiuas.Temperature.ToString();
                txtValue.Text = null;
            }
            else if ((bool)rdbHumidity.IsChecked)
            {
                double.TryParse(txtValue.Text, out number);
                kiuas.Humidity = number;
                lblHumidity.Content = kiuas.Humidity.ToString();
                txtValue.Text = null;
            }
        }
    }
}
