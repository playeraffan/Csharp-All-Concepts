using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate__non_parameterized_
{

    delegate void CustomerRegistered(); //declare delegate

    class CRM
    {
        public CustomerRegistered customerregistered; //variable for delegate

        public void SendEmailMessage() {
            Console.WriteLine("Welcome Email Sent!");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CRM crm = new CRM(); //object for CRM class

            crm.customerregistered = crm.SendEmailMessage; //Assigning method to variable

            crm.customerregistered(); //invoking delegate


        }
    }
}
