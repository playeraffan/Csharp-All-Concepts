using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
       public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 1 starting..");
                Thread.Sleep(4000);
                Console.WriteLine("task 1 Completed...");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("task 2 starting..");
                Thread.Sleep(5000);
                Console.WriteLine("task 2 Completed...");
            });
        }
        public static async void Task3()
        {
            await Task.Run(() => 
            {
                Console.WriteLine("task 3 starting..");
                Thread.Sleep(1000);
                Console.WriteLine("task 3 Completed...");
            });
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 4 starting..");
                Thread.Sleep(3000);
                Console.WriteLine("task 4 Completed...");
            });
           
        }
      
    }
}
