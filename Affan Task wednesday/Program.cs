using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Affan_Task_wednesday
{

    interface IEmployeeActions
        {
        void Showdetails();
        double calculateSalary();
    }
    abstract class Employee : IEmployeeActions
    {
        private int id;
        private string name;
        private string department;
        protected double baseSalary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }


        public Employee(int id, string name, string department , double baseSalary) {
            this.id = id;
            this.name = name;
            this.department = department;
            this.baseSalary = baseSalary;
        }
        public abstract double calculateSalary();

        public virtual void Showdetails()
        {
            Console.WriteLine($"ID: {id} , Name: {name} , Department: {department}");
        }
    
    }

    class Manager : Employee
    {
        private double bonus;
        public Manager(int id, string name, string department, double baseSalary, double bonus) : base(id,name, department, baseSalary)
        {
            this.bonus = bonus;
        }

        public override double calculateSalary() {
            return baseSalary + bonus; 
        }

        public override void Showdetails()
        {
            base.Showdetails();
            Console.WriteLine($"Role:Manager , Total salary: {calculateSalary()}");
        }
    }
    class Developer : Employee
    {
        private int extraHour;
        private double hourlyRate;

        public Developer(int id, string name, string department, double baseSalary, int extraHour, double hourlyRate) :base(id, name, department, baseSalary)
        {
            this.extraHour = extraHour;
            this.hourlyRate = hourlyRate;

        }

        public override double calculateSalary()
        {
            return baseSalary + (extraHour * hourlyRate);
        }

        public override void Showdetails()
        {
            base.Showdetails();
            Console.WriteLine($"Role: developer , total Salary: {calculateSalary()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            { 
            new Manager(1 , "Alice" , "HR" , 50000 , 10000),
            new Developer(2, "Bob" , "IT", 40000, 10 , 500)
            };
            foreach (var emp in employees)
            { 
             emp.Showdetails();
                Console.WriteLine("---------------");
            }
        }
    }
}
