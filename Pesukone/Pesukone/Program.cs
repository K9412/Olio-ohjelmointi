using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Pesukone
    {
        //field variables
        private uint washProgram;
        private bool programRunning;

        //properties
        public bool powerOn{ set; get; }
        public bool waterOn { set; get; }
        public uint waterTemperature { set; get; }
        public uint washTime { set; get; }

        //constructors
        public Pesukone()
        {
            powerOn = false;
        }
        public Pesukone(bool poweron)
        {
            powerOn = poweron;
        }
        public Pesukone(bool poweron, uint washprogram)
        {
            powerOn = poweron;
            washProgram = washprogram;
            WashProgram(washprogram);
        }

        //methods
        public void PrintStatus()
        {
            Console.WriteLine("Power on : " + powerOn);
            Console.WriteLine("Water : " + waterOn);
            Console.WriteLine("Running : " + programRunning);
            Console.WriteLine("Wash program : " + washProgram);
            Console.WriteLine("Water temperature : " + waterTemperature);
            Console.WriteLine("Wash time : " + washTime);
            Console.WriteLine();
        }
        public void StartMachine()
        {
            programRunning = ProgramRunning(powerOn, waterOn, washProgram);
            if (programRunning)
            {
                Console.WriteLine("Washing machine started running!");
            }
            else
            {
                Console.WriteLine("Washing machine did not start running. Check your settings.");
                Console.WriteLine();
            }

        }
        public void WashProgram(uint washprogram)
        {
            switch (washprogram)
            {
                case 1:
                    washProgram = 1;
                    waterTemperature = 40;
                    washTime = 90;
                    break;
                case 2:
                    washProgram = 2;
                    waterTemperature = 60;
                    washTime = 60;
                    break;
                case 3:
                    washProgram = 3;
                    waterTemperature = 95;
                    washTime = 60;
                    break;
                default:
                    Console.WriteLine("No such program exists. Program set to 0.");
                    washProgram = 0;
                    break;
            }
        }
        private bool ProgramRunning(bool poweron, bool wateron, uint washprogram)
        {
            if(poweron == true && wateron == true)
            {
                if (washprogram >= 1 && washprogram <= 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone1 = new Pesukone();
            pesukone1.StartMachine();
            pesukone1.PrintStatus();
            
            pesukone1.powerOn = true;
            pesukone1.StartMachine();
            pesukone1.PrintStatus();

            pesukone1.waterOn = true;
            pesukone1.StartMachine();
            pesukone1.PrintStatus();

            pesukone1.WashProgram(2);
            pesukone1.StartMachine();
            pesukone1.PrintStatus();

            Pesukone pesukone2 = new Pesukone(true, 3);
            pesukone2.StartMachine();
            pesukone2.PrintStatus();

            Pesukone pesukone3 = new Pesukone(true, 4);
            pesukone3.StartMachine();
            pesukone3.PrintStatus();

            Pesukone pesukone4 = new Pesukone(true);
            pesukone4.waterOn = true;
            pesukone4.WashProgram(1);
            pesukone4.StartMachine();
            pesukone4.PrintStatus();
        }
    }
}
