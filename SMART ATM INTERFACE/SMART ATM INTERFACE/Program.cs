using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_atm_interface
{
    class bankaccount
    {
        private decimal balance;

        public bankaccount(decimal initialbalance)
        {
            balance = initialbalance;
        }

        public void deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"deposited: ${amount}. new balance: ${balance}\n");
            Console.ReadLine();
        }

        public void transact(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Transaction failed! Insufficient balance.\n");
            }
            else
            {
                balance -= amount;

                Console.WriteLine($"Transaction successful! Amount deducted: ${amount}. Remaining Balance: ${balance}]\n");
                Console.ReadLine();
            }
        }

        public decimal getbalance()
        {
            return balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the ATM system\n");
            Console.ReadLine();

            bankaccount account = new bankaccount(0);

            Console.WriteLine("enter initial deposit amount:");
            decimal depositamount = Convert.ToDecimal(Console.ReadLine());
            account.deposit(depositamount);

            while (true)
            {
                Console.WriteLine("choose an option");
                Console.WriteLine("1. deposit");
                Console.WriteLine("2. transaction");
                Console.WriteLine("3. check balance");
                Console.WriteLine("4. exit");
                Console.Write("enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("enter amount to deposit:");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        account.deposit(amount);
                        break;

                    case 2:
                        Console.Write("enter amount to transact:");
                        decimal transactamount = Convert.ToDecimal(Console.ReadLine());
                        account.deposit(transactamount);
                        break;
                    case 3:
                        Console.WriteLine($"current balance: ${account.getbalance()}\n");
                        break;
                    case 4:
                        Console.WriteLine("thanks you for using the ATM system . goodbye");
                        return;
                    default:
                        Console.WriteLine("invalid choice. please try again.\n");
                        break;
                }
            }
        }
    }
}
