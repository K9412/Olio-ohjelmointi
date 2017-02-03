using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplifier
{
    public class Amplifier
    {
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                {
                    volume = 100;
                    Console.WriteLine("Too high - Volume set to 100");
                }
                else if (value < 0)
                {
                    volume = 0;
                    Console.WriteLine("Too low - Volume set to 0");
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Amp set to " + value);
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amp1 = new Amplifier();

            string lineIn;
            int volume;
            do
            {
                Console.Write("Set volume: ");
                lineIn = Console.ReadLine();
                bool test = int.TryParse(lineIn, out volume);
                if (test)
                {
                    amp1.Volume = volume;
                }
            } while (true);
        }
    }
}
