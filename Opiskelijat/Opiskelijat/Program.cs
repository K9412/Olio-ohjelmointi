using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelijat
{
    class Student
    {
        public string name { get; set; }
        public uint age { get; set; }
        public string studentID { get; set; }
        public string field { get; set; }

        public Student()
        {

        }
        public Student(string Name, uint Age, string StudentID, string Field)
        {
            name = Name;
            age = Age;
            studentID = StudentID;
            field = Field;
        }
        public string Asleep()
        {
            if (field == "IT")
            {
                return "asleep";
            }
            return "awake";
        }
        public void StudentStatus()
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student age: " + age);
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Student field: " + field);
            Console.WriteLine("Student is: " + Asleep());
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 5;
            Student[] array = new Student[arraySize];
            for(int x = 0; x < array.Length; x++)
            {
                array[x] = AddStudent();
            }
            for(int x = 0; x < array.Length; x++)
            {
                array[x].StudentStatus();
            }
        }
        static Student AddStudent()
        {
            Student temp = new Student();
            Console.Write("Name > ");
            temp.name = Console.ReadLine();
            Console.Write("Age > ");
            temp.age = uint.Parse(Console.ReadLine());
            Console.Write("ID > ");
            temp.studentID = Console.ReadLine();
            Console.Write("Field > ");
            temp.field = Console.ReadLine();
            Console.WriteLine();

            return temp;
        }
    }
}
