using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge
{
    class Item
    {
        public string Name { get; set; }
        public string BestBefore { get; set; }

        public override string ToString()
        {
            return Name + ", Best before: " + BestBefore + "\n";
        }
    }
    class Fridge
    {
        private const int maxCapacity = 10;
        private List<Item> items = new List<Item>();
        private bool light = false;
        private bool doorIsOpen = false;
        private bool signalFromDoorSensor = true; //true niin ovi on kiinni

        public bool OpenTheDoor
        {
            get
            {
                return doorIsOpen;
            }
            set
            {
                doorIsOpen = value;
                if (doorIsOpen == true)
                {
                    signalFromDoorSensor = false;
                    light = SetLight();
                }
            }
        }
        public void AddItem(Item item)
        {
            if (items.Count < maxCapacity)
            {
                items.Add(item);
            }
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Item item in items)
            {
                temp += item;
            }
            return "FRIDGE\nDoor is open: " + doorIsOpen + ", Light is: " + light + "\n" + "ITEMS\n" + temp;
        }
        private bool SetLight()
        {
            if (signalFromDoorSensor == false)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item banana = new Item();
            banana.Name = "Banana";
            banana.BestBefore = "20.2.2017";
            Item milk = new Item();
            milk.Name = "Milk";
            milk.BestBefore = "19.2.2017";
            Item beer = new Item();
            beer.Name = "Karjala";
            beer.BestBefore = "1.1.2019";
            Item deadCat = new Item();
            deadCat.Name = "Kisse";
            deadCat.BestBefore = "10.1.2010";

            Fridge a = new Fridge();
            a.AddItem(banana);
            a.AddItem(milk);
            a.AddItem(beer);
            a.AddItem(deadCat);
            Console.WriteLine(a.ToString());
            a.OpenTheDoor = true;
            Console.WriteLine(a.ToString());
        }
    }
}
