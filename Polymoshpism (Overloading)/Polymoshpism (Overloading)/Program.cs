using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymoshpism__Overloading_
{
    class polymorph
    {
        public int a = 10, b = 20;

        public int add()
        {
            return a + b;
        }

        public int add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            polymorph sum = new polymorph();
            Console.WriteLine(sum.add());
            Console.WriteLine(sum.add(3 , 5));
            Console.ReadLine();
        }
    }
}
