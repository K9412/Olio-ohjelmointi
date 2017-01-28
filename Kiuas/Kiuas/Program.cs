using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    // field variables
    // properties
    // constructors
    // methods
    // events
    // indexer
    // destructor
    class Kiuas
    {
        public bool onOff { get; set; }
        public int temperature { get; set; }
        public int humidity { get; set; }

        public Kiuas()
        {

        }
        public Kiuas(bool OnOff)
        {
            onOff = OnOff;
        }
        public Kiuas(bool OnOff, int Temperature, int Humidity)
        {
            onOff = OnOff;
            temperature = Temperature;
            humidity = Humidity;
        }
        public void PrintData()
        {
            Console.WriteLine("Kiuas is " + onOff);
            Console.WriteLine("The temperature is at " + temperature);
            Console.WriteLine("The humidity is at " + humidity);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas();
            kiuas1.PrintData();

            kiuas1.onOff = true;
            kiuas1.temperature = 200;
            kiuas1.PrintData();

            Kiuas kiuas2 = new Kiuas(true, 100, 90);
            kiuas2.PrintData();
        }
    }
}
