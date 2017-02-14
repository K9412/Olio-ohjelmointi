using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6T1
{
    class Person
    { 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }

    class Persons
    {
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public Person GetPerson(int index)
        {
            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            }
            return null;
        }
        public Person FindPerson(string socialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                if (person.SocialSecurityNumber.Equals(socialSecurityNumber))
                {
                    return person;
                }
            }
            return null;
            
        }
        public void ShowPersons()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
