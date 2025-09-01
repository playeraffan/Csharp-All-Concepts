using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__vehical_mangment_system_
{
    class car
    {
        protected string brand;
        protected string name;
        protected int modelyear;

        public car(string brand, string name, int modelyear)
        { 
            this.brand = brand;
            this.name = name;
            this.modelyear = modelyear;
        }
        public void showdetails() {
            Console.WriteLine($"{brand} , {name} , {modelyear}");
        }
    }
    class registerd : car 
    {
        protected bool registration;
        public registerd(string brand, string name, int modelyear, bool registration) : base (brand, name, modelyear)
        { 
        this.registration = registration;
        }
        public void showcardetails() {

            showdetails();
            if (registration == true) {
                Console.WriteLine("Car is registered");
            }
            else { Console.WriteLine("car is not registered"); }
            Console.ReadLine();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            registerd cars = new registerd("Toyota", "Fortuner" , 2020 , true);
            cars.showcardetails();
        }
    }
}
