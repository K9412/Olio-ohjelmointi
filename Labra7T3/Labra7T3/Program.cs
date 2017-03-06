using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            int x;
            double y;
            List<int> integers = new List<int>();
            List<double> doubles = new List<double>();

            do
            {
                Console.Write("Give a number (bad input ends)> ");
                value = Console.ReadLine();

                if (int.TryParse(value, out x))
                {
                    integers.Add(x);
                }
                else if (double.TryParse(value, out y))
                {
                    doubles.Add(y);
                }
            } while (int.TryParse(value, out x) || double.TryParse(value, out y));

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("../../integers.txt"))
            {
                foreach (int integer in integers)
                {
                    writer.WriteLine(integer);
                }
            }
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("../../doubles.txt"))
            {
                foreach (double d in doubles)
                {
                    writer.WriteLine(d);
                }
            }
        }
    }
}
