using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        private bool powerSwitch = false;
        private int volume;
        private double frequency = 2000.0;

        public bool PowerSwitch
        {
            get
            {
                return powerSwitch;
            }
            set
            {
                powerSwitch = value;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if(value >= 0 && value <= 9)
                {
                    volume = value;
                }
                else if(value < 0)
                {
                    volume = 0;
                }
                else
                {
                    volume = 9;
                }
            }
        }
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if(value >= 2000.0 && value <= 26000.0)
                {
                    frequency = value;
                }
                else if(value > 26000.0)
                {
                    frequency = 26000.0;
                }
                else
                {
                    frequency = 2000.0;
                }
            }
        }


        public override string ToString()
        {
            return "Power: " + powerSwitch + "\nVolume: " + volume + "\nFrequency: " + frequency + "\n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Radio a = new Radio();
            Console.WriteLine(a.ToString());
            a.PowerSwitch = true;
            a.Volume = 100;
            Console.WriteLine(a.ToString());
            a.Volume = 9;
            Console.WriteLine(a.ToString());
            a.Frequency = 27000;
            Console.WriteLine(a.ToString());
            a.Frequency = 26000.1;
            Console.WriteLine(a.ToString());
            a.Frequency = 1500;
            Console.WriteLine(a.ToString());
            a.Frequency = 5000.30;
            Console.WriteLine(a.ToString());
        }
    }
}
