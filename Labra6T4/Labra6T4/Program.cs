using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labra6T4
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }
        public ushort Number { get; set; }

        public Player()
        {

        }
        public Player(string firstName, string lastName, ushort age, ushort number)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Number = number;
        }

        public override string ToString()
        {
            return Number + " " + LastName + " " + FirstName + " " + Age;
        }
    }
    class Team
    {
        private List<Player> players;

        public string TeamName { get; set; }
        public string HomeTown { get; set; }

        public Team()
        {
            players = new List<Player>();
        }
        public Team(string teamName)
        {
            players = new List<Player>();
            TeamName = teamName;
            GetPlayers(teamName);
        }
        public Team(string teamName, string homeTown)
        {
            players = new List<Player>();
            TeamName = teamName;
            HomeTown = homeTown;
            GetPlayers(teamName);
        }

        public void GetPlayers(string team)
        {
            string directory = "../../";
            string txt = ".txt";
            string line = "";
            string[] data;

            using (StreamReader reader = new StreamReader(directory + team + txt))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Player player = new Player();
                    data = line.Split(default(string[]), StringSplitOptions.None);
                    player.Number = ushort.Parse(data[0]);
                    player.LastName = data[1];
                    player.FirstName = data[2];
                    player.Age = ushort.Parse(data[3]);

                    players.Add(player);
                }
            }
        }
        public void AddPlayer(string firstName, string lastName, ushort age, ushort number)
        {
            Player temp = new Player(firstName, lastName, age, number);
            players.Add(temp);
        }
        public void SavePlayers(string fileName)
        {
            string directory = "../../";
            string txt = ".txt";
            string data;

            using (StreamWriter writer = new StreamWriter(directory + fileName + txt))
            {
                foreach (Player p in players)
                {
                    data = p.ToString();
                    writer.WriteLine(data);
                }
            }
        }
        public void DeletePlayer(ushort playerNumber)
        {
            players.RemoveAll(a => a.Number == playerNumber);
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Player p in players)
            {
                temp += p.ToString() + "\n";
            }
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Team JYP = new Team("JYP");
            JYP.HomeTown = "Jyväskylä";

            Console.WriteLine(JYP.ToString());

            JYP.AddPlayer("Mikko", "Mallikas", 25, 1);
            Console.WriteLine(JYP.ToString());

            JYP.DeletePlayer(1);
            Console.WriteLine(JYP.ToString());

            JYP.AddPlayer("Pirkko", "Pirkokas", 18, 2);
            JYP.SavePlayers("JYP");
        }
    }
}
