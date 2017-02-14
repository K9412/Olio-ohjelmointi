using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6T1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPersonClass();
        }
        static void TestPersonClass()
        {
            Persons myFriends = new Persons();
            Person friend1 = new Person();
            friend1.Firstname = "Kirsi";
            friend1.Lastname = "Kernel";
            friend1.SocialSecurityNumber = "121270-123A";

            Person friend2 = new Person { Firstname = "Jack", Lastname = "Russel", SocialSecurityNumber = "141218+BBB1" };
            Person friend3 = new Person { Firstname = "Jamppa", Lastname = "Lopez", SocialSecurityNumber = "123543-12AA" };
            Person friend4 = new Person { Firstname = "Teppo", Lastname = "Testaaja", SocialSecurityNumber = "010101-0101" };

            myFriends.AddPerson(friend1);
            myFriends.AddPerson(friend2);
            myFriends.AddPerson(friend3);
            myFriends.AddPerson(friend4);

            Console.WriteLine("** KAVERIREKISTERI **");
            myFriends.ShowPersons();

            //testataan kaverin hakua
            Console.Write("Anna kaverin indeksi: ");
            string retval = Console.ReadLine();
            int index;
            bool test = int.TryParse(retval, out index);
            if (test)
            {
                Person searchedFriend = myFriends.GetPerson(index);
                if (searchedFriend != null)
                {
                    Console.WriteLine("Löytyi ystävä nimeltä {0}", searchedFriend.ToString());
                }
                else
                {
                    Console.WriteLine("Ei kaveria antamallasi indeksillä.");
                }
            }
            else
            {
                Console.WriteLine("Et antanut numeroa.");
            }

            Console.Write("Anna kaverisi henkilötunnus: ");
            retval = Console.ReadLine();
            Person searchedPerson = myFriends.FindPerson(retval);
            if (searchedPerson != null)
            {
                Console.WriteLine(searchedPerson.ToString());
            }
            else
                Console.WriteLine("Ei löytynyt.");
            

        }
    }
}
