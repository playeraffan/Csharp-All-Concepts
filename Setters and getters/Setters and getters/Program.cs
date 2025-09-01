using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setters_and_getters
{
    class Employee
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else Console.WriteLine("ID can't be negetive value!");
            }
        }

            public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) name = value;
                else Console.WriteLine("Name can't be Empty!");
            }
        }

         public double Salary 
        {
            get { return salary; }
            set
            {
                if (value > 0) salary = value;
                else Console.WriteLine("Salary Can't br negetive!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = -5;
            employee.Name = "";
            employee.Salary = -19999;

            employee.Id = 5;
            employee.Name = "Affan";
            employee.Salary = 200000;
            Console.WriteLine($"ID: {employee.Id} , Name: {employee.Name} , Salary: {employee.Salary} ");

            Console.ReadLine();
        }
    }
}
