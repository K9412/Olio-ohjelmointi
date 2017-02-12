using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rengas
{
    class Tyre
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " Size: " + Size + "\n";
        }
    }
    class Vehicle
    {
        private List<Tyre> tyres = new List<Tyre>();
        private int maxTyres = 4;

        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tyre> Tyres { get { return tyres; } }
        

        public void AddTyre(Tyre tyre)
        {
            if (Tyres.Count < maxTyres)
            {
                Tyres.Add(tyre);
            }
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Tyre tyre in tyres)
            {
                temp += tyre;
            }
            return "VEHICLE: " + Name + " " + Model + "\n" + "TYRES:\n" + temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tyre a = new Tyre();
            a.Brand = "Nokia";
            a.Model = "Hakkapeliitta";
            a.Size = 20;

            Tyre b = new Tyre();
            b.Brand = "Michelin";
            b.Model = "Pro";
            b.Size = 17;

            Vehicle one = new Vehicle();
            one.Name = "Kia";
            one.Model = "A1";
            one.AddTyre(a);
            one.AddTyre(a);
            one.AddTyre(a);
            one.AddTyre(a);
            Console.WriteLine(one.ToString());

            Vehicle two = new Vehicle();
            two.Name = "BMW";
            two.Model = "M3 Sedan";
            two.AddTyre(b);
            two.AddTyre(b);
            two.AddTyre(b);
            two.AddTyre(b);
            Console.WriteLine(two.ToString());
        }
    }
}
