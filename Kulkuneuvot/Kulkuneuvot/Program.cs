using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulkuneuvot
{
    class Vehicle
    {
        private string make;
        private string model;
        private int yearOfManufacture;
        private string color;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int YearOfManufacture
        {
            get
            {
                return yearOfManufacture;
            }
            set
            {
                yearOfManufacture = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public override string ToString()
        {
            return "\nVehicle info\nMake: " + make + " Model: " + model + " Year: " + yearOfManufacture + " Color: " + color;
        }
    }
    class Bicycle : Vehicle
    {
        private bool transmission;
        private string transmissionModel;

        public bool Transmission
        {
            get
            {
                return transmission;
            }
            set
            {
                transmission = value;
            }
        }
        public string TransmissionModel
        {
            get
            {
                return transmissionModel;
            }
            set
            {
                transmissionModel = value;
            }
        }

        public Bicycle()
        {

        }
        public Bicycle(string makeIn, string modelIn, int yearOfManufatureIn, string colorIn, bool transmissionIn, string transmissionModelIn)
        {
            Make = makeIn;
            Model = modelIn;
            YearOfManufacture = yearOfManufatureIn;
            Color = colorIn;
            transmission = transmissionIn;
            transmissionModel = transmissionModelIn;
        }

        public override string ToString()
        {
            return "\nBIKE " + base.ToString() + " Transmission: " + transmission + " Transmission model: " + transmissionModel;
        }
    }
    class Boat : Vehicle
    {
        private string boatType;
        private int seatCount;

        public string BoatType
        {
            get
            {
                return boatType;
            }
            set
            {
                boatType = value;
            }
        }
        public int SeatCount
        {
            get
            {
                return seatCount;
            }
            set
            {
                seatCount = value;
            }
        }

        public override string ToString()
        {
            return "\nBOAT " + base.ToString() + " Boat type: " + boatType + " Seat count: " + seatCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle one = new Vehicle();
            one.Make = "Suzuki";
            one.Model = "PV";
            one.YearOfManufacture = 1987;
            one.Color = "Black";
            Console.WriteLine(one.ToString());

            Bicycle a = new Bicycle("Jopo", "Street", 2016, "Blue", false, "");
            Console.WriteLine(a.ToString());

            Boat b = new Boat();
            b.Make = "Terhi";
            b.Model = "385";
            b.YearOfManufacture = 2017;
            b.Color = "White";
            b.BoatType = "Motorboat";
            b.SeatCount = 4;
            Console.WriteLine(b.ToString());

        }
    }
}
