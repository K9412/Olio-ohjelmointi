using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private string name;
        private string profession;
        private int salary;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public Employee()
        {

        }
        public Employee(string nameIn, string professionIn, int salaryIn)
        {
            name = nameIn;
            profession = professionIn;
            salary = salaryIn;
        }
        public override string ToString()
        {
            return "\nEMPLOYEE" + "\nName: " + Name + "\nProfession: " + Profession + "\nSalary: " + Salary;
        }
    }
    public class Boss : Employee
    {
        private string car;
        private int bonus;

        public string Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }
        public int Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

        public Boss()
        {

        }
        public Boss(string nameIn, string professionIn, int salaryIn, string carIn, int bonusIn) : base(nameIn, professionIn, salaryIn)
        {
            car = carIn;
            bonus = bonusIn;
        }
        public override string ToString()
        {
            return "\nBOSS" + "\nName: " + Name + "\nProfession: " + Profession + "\nSalary: " + Salary + "\nCar: " + Car + "\nBonus: " + Bonus;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee("Jamppa", "Camel jockey", 9000);
            Console.WriteLine(one.ToString());

            Boss a = new Boss();
            a.Name = "Anna";
            a.Car = "Porsche";
            a.Profession = "Camel caretaker";
            a.Salary = 10000;
            a.Bonus = 5000;
            Console.WriteLine(a.ToString());

            Boss b = new Boss("Pekka", "Camel farmer", 15000, "Ferrari", 5000);
            Console.WriteLine(b.ToString());

            one.Profession = "Camel trainer";
            one.Salary = 12000;
            Console.WriteLine(one.ToString());
        }
    }
}
