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

namespace Labra11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyColor color;
        Dictionary<string, MyColor> myColors;
        public MainWindow()
        {
            color = new MyColor();
            myColors = new Dictionary<string, MyColor>();
            InitializeComponent();
            tb1.DataContext = color;
            tb2.DataContext = color;
            tb3.DataContext = color;
            myGrid.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(color.Hex);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (myColors.ContainsKey(tbSaveAs.Text))
            {
                MessageBox.Show("A color with the specified name already exists.", "Error", MessageBoxButton.OK);
            }
            else
            {
                myColors.Add(tbSaveAs.Text, color);
                Button newButton = new Button();
                newButton.Content = tbSaveAs.Text;
                newButton.Click += new RoutedEventHandler(newButton_Click);
                newButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(color.Hex);
                myStackPanel.Children.Add(newButton);
            }
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            Button temp = (Button)sender;

            foreach (KeyValuePair<string, MyColor> kvp in myColors)
            {
                if (kvp.Key == (string)temp.Content)
                {
                    MessageBox.Show((string)temp.Content, (string)temp.Content, MessageBoxButton.OK);
                }
            }
            
        }

        private void sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color.Red = (int)sldRed.Value;
            color.Green = (int)sldGreen.Value;
            color.Blue = (int)sldBlue.Value;
            tbAsHex.Text = color.Hex;
            myGrid.Background = (SolidColorBrush)new BrushConverter().ConvertFrom(color.Hex);
        }

        private void tbSaveAs_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= tbSaveAs_GotFocus;
        }
    }
}
