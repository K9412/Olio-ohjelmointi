using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5T3
{
    abstract class Mammal
    {
        public uint Age { get; set; }

        public abstract string Move();
    }
    class Human : Mammal
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public void GrowUp()
        {
            Age += 1;
        }
        public override string Move()
        {
            return "I'm moving!";
        }
        public override string ToString()
        {
            return "\nAge: " + Age + ", Name: " + Name + ", Height: " + Height + ", Weight: " + Weight;
        }
    }
    class Baby : Human
    {
        public string Diaper { get; set; }

        public override string Move()
        {
            return "I'm crawling!";
        }
        public override string ToString()
        {
            return "\n" + base.ToString() + ", Diapers: " + Diaper;
        }
    }
    class Adult : Human
    {
        public string Car { get; set; }

        public override string Move()
        {
            return "I'm walking!";
        }
        public override string ToString()
        {
            return "\n" + base.ToString() + ", Car: " + Car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human one = new Human();
            one.Age = 25;
            one.Height = 180;
            one.Name = "Abdul";
            one.Weight = 70;
            Console.WriteLine(one.ToString());
            Console.WriteLine(one.Move());
            one.GrowUp();
            Console.WriteLine(one.ToString());

            Adult two = new Adult();
            two.Age = 30;
            two.Height = 185;
            two.Name = "Vladimir";
            two.Weight = 100;
            two.Car = "Lada";
            Console.WriteLine(two.ToString());
            Console.WriteLine(two.Move());
            two.GrowUp();
            Console.WriteLine(two.ToString());

            Baby three = new Baby();
            three.Age = 1;
            three.Diaper = "Pampers";
            three.Height = 40;
            three.Name = "Jonne";
            three.Weight = 5;
            Console.WriteLine(three.ToString());
            Console.WriteLine(three.Move());
            three.GrowUp();
            Console.WriteLine(three.ToString());
        }
    }
}
