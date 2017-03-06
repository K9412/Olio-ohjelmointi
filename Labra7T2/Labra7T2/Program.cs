using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7T2
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] names = GetNames();

                PrintNames(names);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static string[] GetNames()
        {
            if (System.IO.File.Exists(@"E:\Temp\nimet.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"E:\Temp\nimet.txt");
                return lines;
            }
            else
            {
                throw new MyException("Specified file doesn't exist.");
            }
        }
        static void PrintNames(string[] names)
        {
            Dictionary<string, int> nameDictionary = new Dictionary<string, int>();

            for (int x = 0; x < names.Length; x++)
            {
                if (nameDictionary.ContainsKey(names[x]))
                {
                    nameDictionary[names[x]]++;
                }
                else
                {
                    nameDictionary.Add(names[x], 1);
                }
            }

            Console.WriteLine("Found {0} rows and {1} names.", names.Length, nameDictionary.Count);
            foreach (KeyValuePair<string, int> key in nameDictionary.OrderBy(key => key.Key))
            {
                Console.WriteLine("Name {0} was found {1} times", key.Key, key.Value);
            }
        }
    }
}
