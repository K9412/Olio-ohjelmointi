using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Labra6T5
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string CreateRandomFirstName(Random rnd)
        {
            string firstName = "";
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int x = 0; x < 4; x++)
            {
                firstName += letters[rnd.Next(0, letters.Length)];
            }

            return firstName;
        }
        public string CreateRandomLastName(Random rnd)
        {
            string lastName = "";
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int x = 0; x < 10; x++)
            {
                lastName += letters[rnd.Next(0, letters.Length)];
            }

            return lastName;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int amount = 10000;

            //Typed list

            /*List<Person> persons = new List<Person>();
            
            AddRandomPeopleToList(rnd, persons, amount);

            FindRandomPeopleFromList(persons, 1000);*/



            //Dictionary

            /*Dictionary<string, Person> persons = new Dictionary<string, Person>();

            AddRandomPeopleToDictionary(rnd, persons, amount);

            FindRandomPeopleFromDictionary(persons, 1000);*/

        }
        static void AddRandomPeopleToList(Random rnd, List<Person> persons, int amount)
        {
            Person a;
            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int x = 0; x < amount; x++)
            {
                a = new Person();
                string temp = a.CreateRandomFirstName(rnd);
                a.FirstName = temp;
                temp = a.CreateRandomLastName(rnd);
                a.LastName = temp;
                persons.Add(a);
            }
            timer.Stop();

            Console.WriteLine("{0} People added into the list in: {1}", amount, timer.ElapsedMilliseconds + "ms");
        }
        static void FindRandomPeopleFromList(List<Person> persons, int count = 1)
        {
            Random rnd = new Random();
            Person tempPerson = new Person();
            string temp = "";
            int matches = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            do
            {
                temp = tempPerson.CreateRandomFirstName(rnd);
                foreach (Person p in persons)
                {
                    if (p.FirstName == temp)
                    {
                        Console.WriteLine("Found person with " + temp + " firstname: " + p.ToString());
                        matches++;
                    }
                }
            } while (matches < count);
            timer.Stop();

            Console.WriteLine("Amount of persons searched for: " + count);
            Console.WriteLine("Persons found in: " + timer.ElapsedMilliseconds + "ms");
        }
        static void AddRandomPeopleToDictionary(Random rnd, Dictionary<string, Person> persons, int amount)
        {
            Person a;
            Stopwatch timer = new Stopwatch();

            timer.Start();
            for (int x = 0; x < amount; x++)
            {
                a = new Person();
                a.FirstName = a.CreateRandomFirstName(rnd);
                a.LastName = a.CreateRandomLastName(rnd);
                string key = a.FirstName;

                if (!(persons.ContainsKey(key)))
                {
                    persons.Add(key, a);
                }
            }
            timer.Stop();

            Console.WriteLine("{0} People added into the dictionary in: {1}", amount, timer.ElapsedMilliseconds + "ms");
        }
        static void FindRandomPeopleFromDictionary(Dictionary<string, Person> persons, int count = 1)
        {
            Random rnd = new Random();
            Person tempPerson = new Person();
            string temp = "";
            int matches = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            do
            {
                temp = tempPerson.CreateRandomFirstName(rnd);
                foreach (var pair in persons)
                {
                    if (pair.Key == temp)
                    {
                        Console.WriteLine("Found person with " + temp + " firstname: " + pair.Value);
                        matches++;
                    }
                }
            } while (matches < count);
            timer.Stop();

            Console.WriteLine("Amount of persons searched for: " + count);
            Console.WriteLine("Persons found in: " + timer.ElapsedMilliseconds + "ms");
        }
    }
}
