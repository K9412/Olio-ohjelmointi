using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaakaappi
{
    class Jaakaappi
    {
        private int temperature;
        private bool light = false;
        private bool doorIsOpen = false;
        private bool signalFromDoorSensor = true;

        public Jaakaappi()
        {
            Console.WriteLine("You created an instance of a type Jaakaappi.");
        }
        public void PrintStatus()
        {
            Console.WriteLine("The temperature is at : " + temperature);
            Console.WriteLine("The door is : " + doorIsOpen);
            Console.WriteLine("The light is : " + light);
            Console.WriteLine();
        }
        public int GetTemperature()
        {
            return temperature;
        }
        public void SetTemperature(int inTemperature)
        {
            if (inTemperature >= 1 && inTemperature <= 10)
            {
                temperature = inTemperature;
            }
        }
        public void OpenTheDoor()
        {
            signalFromDoorSensor = false;
            doorIsOpen = DoorIsOpen();
        }
        public void CloseTheDoor()
        {
            signalFromDoorSensor = true;
            doorIsOpen = DoorIsOpen();
        }
        bool SetLight()
        {
            if(light)
            {
                return false;
            }
            return true;
        }
        bool DoorIsOpen()
        {
            if(signalFromDoorSensor == false)
            {
                light = SetLight();
                return true;
            }
            light = SetLight();
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jaakaappi jaakaappi = new Jaakaappi();
            jaakaappi.PrintStatus();
            jaakaappi.OpenTheDoor();
            jaakaappi.PrintStatus();
            jaakaappi.CloseTheDoor();
            jaakaappi.PrintStatus();
            jaakaappi.SetTemperature(-5);
            jaakaappi.PrintStatus();
            jaakaappi.SetTemperature(5);
            jaakaappi.OpenTheDoor();
            jaakaappi.PrintStatus();

            Jaakaappi jaakaappi2 = new Jaakaappi();
            jaakaappi2.PrintStatus();
        }
    }
}
