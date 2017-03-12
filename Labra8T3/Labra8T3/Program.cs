using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T3
{
    class Register
    {
        private Dictionary<Fisherman, List<Fish>> fisherInfo;

        public Register()
        {
            fisherInfo = new Dictionary<Fisherman, List<Fish>>();
        }
        public void AddNewFisher(Fisherman fisherman, List<Fish> fish = null)
        {
            fisherInfo.Add(fisherman, fish);
        }
        public string GetFisherInfo(Fisherman fisherman)
        {
            if (fisherInfo.ContainsKey(fisherman))
            {
                string temp = "";
                temp += "Fisher: [" + fisherman.Name + "] has caught:\n";
                foreach (Fish fish in fisherInfo[fisherman].OrderByDescending(x => x.Weight))
                {
                    temp += fish.ToString() + "\n\n";
                }
                return temp;
            }
            return null;
        }
    }
    class Fisherman
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return Name + " " + PhoneNumber;
        }
    }
    class Fish
    {
        public string Species { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return "Species: " + Species + " " + Length + "cm " + Weight + "kg \n" + "Place: " + Place + "\n" +
                "Location: " + Location;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Register fisherRegister = new Register();
            Fish salmon = new Fish { Species = "Salmon", Length = 120, Weight = 3.5, Location = "Jyväskylä",
                                                                            Place = "The lake of Jyväskylä" };
            Fish perch = new Fish { Species = "Perch", Length = 60, Weight = 1.2,
                                            Location = "The northern edge of Finland", Place = "River Teno" };
            Fish perch2 = new Fish
            {
                Species = "Perch",
                Length = 40,
                Weight = 0.7,
                Location = "The northern edge of Finland",
                Place = "River Teno"
            };

            Fisherman fisher = new Fisherman();
            fisher.Name = "Kirsi Kernel";
            fisher.PhoneNumber = "04001234567";
            Fisherman fisher2 = new Fisherman { Name = "Paavo Kernel", PhoneNumber = "04007654321" };
            List<Fish> fishList = new List<Fish> { perch, salmon };
            List<Fish> fishList2 = new List<Fish> { perch2 };

            fisherRegister.AddNewFisher(fisher, fishList2);
            fisherRegister.AddNewFisher(fisher2, fishList);

            Console.WriteLine(fisherRegister.GetFisherInfo(fisher2));
            Console.WriteLine(fisherRegister.GetFisherInfo(fisher));
        }
    }
}
