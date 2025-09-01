using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Online_ticket_booking_
{
    class busserivices
    {
        protected void bus1() {
            Console.WriteLine("karachi to Lahore");
            Console.ReadLine();
        }
        protected void bus2()
        {
            Console.WriteLine("karachi to islamabad");
            Console.ReadLine();
        }
        protected void bus3()
        {
            Console.WriteLine("karachi to Hydeabad");
            Console.ReadLine();
        }  
    }
    class passenger : busserivices
    {
        protected int ticket_id;
        protected string name;
        public passenger(int ticket_id, string name) {
            if (ticket_id == 1 && name == "Affan")
            {
                Console.WriteLine($"{ticket_id} , {name}");
                bus1();
            }
            else if (ticket_id == 2 && name == "Zia")
            {
                Console.WriteLine($"{ticket_id} , {name}");
                bus2();
            }
            else if (ticket_id == 3 && name == "Usama")
            {
                Console.WriteLine($"{ticket_id} , {name}");
                bus1();
            }
            else 
            {
                Console.WriteLine("invalis id and name");
                Console.ReadLine();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            passenger passenger = new passenger(1 , "Affan");
        }
    }
}
