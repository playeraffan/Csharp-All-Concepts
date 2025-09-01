using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__ATM_Transiction_
{
    class BankAccount
    {
        protected double balance;

        public BankAccount (double initialbalance)
        {
            this.balance = initialbalance;
        }
        public virtual void withdraw(double amount) {

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"withdrwl successfull new balance is {balance}");
            }
           
        }
        public void checkbalance() {
            Console.WriteLine($"Current balance is {balance}");
        }
    }
    class ATM : BankAccount 
        {
            public ATM(double initialbalance) : base(initialbalance) { }
            public override void withdraw(double amount)
            {
                if (amount > 1000)
                {
                    Console.WriteLine("Atm withdrawl limit is $1000");
                }
                else { 
                base.withdraw(amount);
                }
            }

        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM myAtm = new ATM(5000);

            myAtm.checkbalance();
            myAtm.withdraw(800);
            myAtm.withdraw(1200);

            Console.ReadLine();

            
        }
    }
}
