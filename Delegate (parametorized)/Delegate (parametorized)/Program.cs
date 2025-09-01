using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate__parametorized_
{
    delegate void CustomerRegistered(string customername); //declare delegate with parameter

    class CRM
    { 
       
        public CustomerRegistered customerregisterd; //delegate variable declare 

        public void SendWelcomeEmail(string name) //function that will store in email must be parameterized because delegate is parameterized                                                
        {
            Console.WriteLine($"Welcom email sent to {name}!");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CRM crm = new CRM(); //CRM class ka object

            crm.customerregisterd = crm.SendWelcomeEmail;

            crm.customerregisterd("Affan");
        }
    }
}
