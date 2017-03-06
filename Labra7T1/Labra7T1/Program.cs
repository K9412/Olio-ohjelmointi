using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7T1
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            Console.Write("EXCEPTION: ");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("How many lines of text do you wish to write to file? > ");
                int lines;
                bool test = int.TryParse(Console.ReadLine(), out lines);
                if (test)
                {
                    GetLines(lines);
                }
                else
                {
                    throw new MyException("You didn't give a number!");
                }
                PrintLines();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void GetLines(int lines)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("../../T1-Lines.txt"))
            {
                for (int x = 0; x < lines; x++)
                {
                    Console.Write("Line {0}/{1} > ", (x + 1), lines);
                    string temp = Console.ReadLine();
                    writer.WriteLine(temp);
                }
            }
        }
        static void PrintLines()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("../../T1-Line.txt");
                Console.WriteLine("\nContents of file:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                throw new MyException("File not found!");
            }
            
        }
    }
}
