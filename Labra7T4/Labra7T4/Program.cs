using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Labra7T4
{
    [Serializable]
    class TVProgram
    {
        public string ShowName { get; set; }
        public string Channel { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public string ShowInfo { get; set; }

        public TVProgram()
        {

        }
        public TVProgram(string showName, string channel, double startTime, double endTime, string showInfo)
        {
            ShowName = showName;
            Channel = channel;
            StartTime = startTime;
            EndTime = endTime;
            ShowInfo = showInfo;
        }
        public override string ToString()
        {
            return ShowName + " " + Channel + " " + StartTime + " " + EndTime + " " + ShowInfo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TVProgram one = new TVProgram
            {
                ShowName = "Salatut Elämät",
                Channel = "MTV3",
                StartTime = 19.30,
                EndTime = 20.00,
                ShowInfo = "Naurettavan huonoa draamaa parhaaseen katseluaikaan."
            };
            TVProgram two = new TVProgram("Castle", "MTV3", 21.00, 22.00, "Man solves crimes.");
            TVProgram three = new TVProgram("The lord of the rings: The fellowship of the ring", "Nelonen",
                21.00, 23.55, "A hobbit has a ring.");

            List<TVProgram> programs = new List<TVProgram>();
            programs.Add(one);
            programs.Add(two);
            programs.Add(three);

            System.IO.Stream writeStream = new System.IO.FileStream("TV-Shows.txt", System.IO.FileMode.OpenOrCreate,
                System.IO.FileAccess.Write);
            System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, programs);
            writeStream.Close();

            System.IO.Stream readStream = new System.IO.FileStream("TV-Shows.txt", System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            List<TVProgram> readPrograms = (List<TVProgram>)formatter.Deserialize(readStream);
            readStream.Close();

            foreach (TVProgram program in readPrograms)
            {
                Console.WriteLine(program.ToString());
            }
        }
    }
}
