using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class DesktopFan
    {
        private string color = "White";
        private bool powerSwitch = false;

        public virtual string Color
        {
            get
            {
                return color;
            }
        }
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

        public override string ToString()
        {
            return "Desktop fan, Color: " + color + " Power: " + powerSwitch + "\n";
        }
    }
    class Lamp : DesktopFan
    {
        public override string ToString()
        {
            return "Lamp, Color: " + Color + " Power: " + PowerSwitch + "\n";
        }
    }
    class Television : DesktopFan
    {
        private string color = "Black";

        public override string Color
        {
            get
            {
                return this.color;
            }
        }
        public override string ToString()
        {
            return "Television, Color: " + color + " Power: " + PowerSwitch + "\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DesktopFan a = new DesktopFan();
            Console.WriteLine(a.ToString());
            a.PowerSwitch = true;
            Console.WriteLine(a.ToString());

            Lamp b = new Lamp();
            Console.WriteLine(b.ToString());

            Television c = new Television();
            Console.WriteLine(c.Color);
            c.PowerSwitch = true;
            Console.WriteLine(c.ToString());
        }
    }
}
