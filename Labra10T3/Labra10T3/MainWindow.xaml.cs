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

namespace Labra10T3
{
    public class Lotto
    {
        public static Random rnd = new Random();
        public List<int> DrawNumbers(string gameType)
        {
            List<int> Numbers = new List<int>();
            int numbersToDraw = 0, extraNumbers = 0, largestNumber = 0, largestExtraNumber = 0;
            if (gameType == null) { return null; }
            if (gameType == "Lotto") { numbersToDraw = 7; largestNumber = 39; }
            if (gameType == "Viking Lotto") { numbersToDraw = 6; largestNumber = 48; }
            if (gameType == "Eurojackpot") { numbersToDraw = 5; extraNumbers = 2; largestNumber = 50; largestExtraNumber = 10; }

            for (int x = 0; x < numbersToDraw; x++)
            {
                int number = rnd.Next(1, largestNumber + 1);
                while (Numbers.Contains(number))
                {
                    number = rnd.Next(1, largestNumber + 1);
                }
                Numbers.Add(number);
            }
            Numbers.Sort();
            List<int> extraNumbersList = new List<int>();
            for (int x = 0; x < extraNumbers; x++)
            {
                int number = rnd.Next(1, largestExtraNumber + 1);
                while (Numbers.Contains(number) || extraNumbersList.Contains(number))
                {
                    number = rnd.Next(1, largestExtraNumber + 1);
                }
                extraNumbersList.Add(number);
            }
            if (extraNumbers != 0)
            {
                extraNumbersList.Sort();
                Numbers = Numbers.Concat(extraNumbersList).ToList();
            }

            return Numbers;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            cmbGame.ItemsSource = new List<string> { "", "Lotto", "Viking Lotto", "Eurojackpot" };
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            Lotto lotto = new Lotto();
            List<int> Numbers = new List<int>();

            int rows = 0;
            bool test = int.TryParse(txtDraws.Text, out rows);
            string output = "";
            if (test)
            {
                for (int x = 0; x < rows; x++)
                {
                    string numbers = "";
                    Numbers = lotto.DrawNumbers(cmbGame.Text);

                    foreach (int number in Numbers)
                    {
                        numbers += number + " ";
                    }
                    output += "Row " + (x + 1) + ": " + numbers + "\n";
                }
                txtNumbers.Text = output;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumbers.Text = null;
        }
    }
}
