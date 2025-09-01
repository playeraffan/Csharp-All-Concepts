using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation__Online_ticketing_system_
{
    class Ticket
    {
        private string ticketHolder;
        private double ticketprice;
        private int ticketNumber;
        public void ticketdetails(string ticketHolder, double ticketprice, int ticketNumber)
        { 
            this.ticketHolder = ticketHolder;
            this.ticketprice = ticketprice;
            this.ticketNumber = ticketNumber;
        }
        public string getticketholder() 
        {
            return ticketHolder;
        }
        public double getprice()
        {
            return ticketprice;
        }
        public int getticketnum()
        {
            return ticketNumber;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            ticket.ticketdetails("Affan", 34.5, 65);
            Console.WriteLine($"ticket holder is : {ticket.getticketholder()} , Ticket price is : {ticket.getprice()} " +
                $" , Ticket number is ; {ticket.getticketnum()}");
            Console.ReadLine();
        }
    }
}
