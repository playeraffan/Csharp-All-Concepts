using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Vehical_mangament__
{
    class Car {
         private int model_year;
        private string model_name;
       private string brand;
       private bool registered;
        public void setcardetail(int model_year, string model_name, string brand, bool registered)
        {
            this.model_year = model_year;
            this.model_name = model_name;
            this.brand = brand;
            this.registered = registered;      
        }
        public int get_model_year() { 
        return model_year;
        }
        public string get_name()
        {
            return model_name;
        }
        public string get_brand()
        {
            return brand;
        }
        public string is_registered()
        {
            return registered ?"car is registered" : "car is not registered"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.setcardetail(2008, "Corolla", "Toyota", true);
            car.setcardetail(2010, "Civic", "Honda", false);
            Console.WriteLine($"Car model is : {car.get_model_year()} , Car brand is {car.get_brand()} , Car name is : {car.get_name()} , Registration {car.is_registered()} ");
            Console.ReadLine();
        }
    }
}
