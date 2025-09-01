using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_and_deconstructor
{
    class person
    {
        public string Name;
        public int Age;

        //Constructor
        public person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Decontructor
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation using contructor
            person p = new person("Ali" , 25);

            //Extract value using decontructor
            var (name, age) = p;
            Console.WriteLine(name , age);
            Console.ReadLine();
        }
    }
}
