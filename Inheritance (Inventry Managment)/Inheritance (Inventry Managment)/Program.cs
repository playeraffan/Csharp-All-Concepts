using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Inventry_Managment_
{
    class products
    {
        protected string name;
        protected double price;
        protected int stock;

        public products(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }
        public void showproduct()
        {
            Console.WriteLine($"product name is {name} , price is {price} , stock is {stock}");
        }

    }
    class grocery : products
    {
        protected string expiredate;

        public grocery(string name, double price, int stock, string expiredate) : base (name , price , stock) { 
         this.expiredate = expiredate;
        }
        public void showgrocerydetails()
        {
            showproduct();
            Console.WriteLine($"Expiredate : {expiredate}");
            Console.ReadLine();
        }
    }

    class Electronics : products
    {
        protected int warentyperiod;

        public Electronics(string name, double price, int stock, int warentyperiod) : base(name, price, stock)
        {
            this.warentyperiod = warentyperiod;
        }
        public void showelectronicsdetails()
        {
            showproduct();
            Console.WriteLine($"Warenty Period : {warentyperiod} Months");
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            grocery grocery = new grocery("Rice" , 34.4 , 9 , "12-march-2025");
            grocery.showgrocerydetails();
            Electronics electronics = new Electronics("TV", 100.7, 3, 12);
            electronics.showelectronicsdetails();
        }
    }
}
