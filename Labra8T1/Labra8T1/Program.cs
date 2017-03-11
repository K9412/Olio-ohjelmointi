using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T1
{
    class Die
    {
        private Random r = new Random();

        public int Roll
        {
            get
            {
                return r.Next(1, 7);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many times do you want to throw the die? > ");
                int throwAmount;
                bool test = int.TryParse(Console.ReadLine(), out throwAmount);
                if (test)
                {
                    ThrowTheDie(throwAmount);
                }
                else
                {
                    throw new Exception("You didn't enter an integer!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ThrowTheDie(int throwAmount)
        {
            Dictionary<int, int> dieThrows = new Dictionary<int, int>();
            Die die = new Die();
            int sum = 0;

            for (int x = 0; x < throwAmount; x++)
            {
                int rollValue = die.Roll;
                if (dieThrows.ContainsKey(rollValue))
                {
                    dieThrows[rollValue]++;
                }
                else
                {
                    dieThrows.Add(rollValue, 1);
                }
                sum += rollValue;
            }

            Console.WriteLine("The die is thrown {0} times.", throwAmount);
            Console.WriteLine("The average is " + (double)sum / throwAmount);
            foreach (KeyValuePair<int, int> throws in dieThrows.OrderBy(y => y.Key))
            {
                Console.WriteLine("{0} count is {1}", throws.Key, throws.Value);
            }
        }
    }
}
