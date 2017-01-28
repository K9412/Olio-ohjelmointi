using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisio
{
    class Televisio
    {
        private bool powerOn = false;
        private uint channel;
        private uint volume;

        public void PowerSwitch()
        {
            powerOn = !powerOn;
        }
        public void ChangeChannel(uint Channel)
        {
            if(powerOn == true)
            {
                channel = Channel;
            }
        }
        public void ChangeVolume(uint Volume)
        {
            if(powerOn == true)
            {
                volume = Volume;
            }
        }
        public void PrintStatus()
        {
            Console.WriteLine("The television is: " + powerOn);
            Console.WriteLine("The channel is: " + channel);
            Console.WriteLine("The volume is at: " + volume);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Televisio televisio1 = new Televisio();
            televisio1.ChangeChannel(3);
            televisio1.ChangeVolume(50);
            televisio1.PowerSwitch();
            televisio1.PrintStatus();

            televisio1.ChangeChannel(3);
            televisio1.ChangeVolume(50);
            televisio1.PrintStatus();

            televisio1.PowerSwitch();
            televisio1.PrintStatus();


        }
    }
}
