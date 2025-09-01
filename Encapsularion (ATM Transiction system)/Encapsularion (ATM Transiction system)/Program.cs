using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Encapsularion__ATM_Transiction_system_
{

    class ATM{
        private string accountholder;
        private int accountnumber;
        private double balance;

        public ATM(string accountholder, int accountnumber, double balance)
        {
            this.accountholder = accountholder;
            this.accountnumber = accountnumber;
            this.balance = balance;
        }

        public void deposite(double amount) {

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Amount Deposited New balane is: {balance}");
            }
            else {
                Console.WriteLine("invalid deposite Amount");
            }       
        }

        public void Withdraw(double amount)
        {

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Amount Widthdrawed New balance is: {balance}");
            }
            else
            {
                Console.WriteLine("invalid Insufficient Widthdraw Amount");
            }
        }

        public void GetBalance()
        { 
            Console.WriteLine($"Account Holder is {accountholder}");
            Console.WriteLine($"Account Number  is {accountnumber}");
            Console.WriteLine($"Your New balance is {balance}");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM myaccount = new ATM("affan", 12345, 78.5);
            myaccount.GetBalance();
            myaccount.deposite(1500);
            //myaccount.Withdraw(2000);
            myaccount.Withdraw(6000);
            myaccount.GetBalance();

        }
    }
}
