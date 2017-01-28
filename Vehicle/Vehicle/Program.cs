using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string name;
        public uint speed;
        public uint tyres;

        public void PrintData()
        {
            Console.WriteLine(name);
            Console.WriteLine(speed);
            Console.WriteLine(tyres);
            Console.WriteLine();
        }
        public string ToString()
        {
            string temp = string.Format("{0} {1} {2}", name, speed, tyres);
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.name = "Lada";
            vehicle.speed = 180;
            vehicle.tyres = 3;
            vehicle.PrintData();
            string data = vehicle.ToString();
            Console.WriteLine(data);
            vehicle.name = "BMW";
            vehicle.speed = 60;
            data = vehicle.ToString();
            Console.WriteLine(data);

        }
    }
}
