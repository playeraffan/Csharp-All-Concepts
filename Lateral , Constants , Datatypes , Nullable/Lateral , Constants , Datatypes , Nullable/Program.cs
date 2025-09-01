using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lateral___Constants___Datatypes___Nullable
{
    internal class Program
    {     //contstants value can't be changed
        const double pi = 3.14159;
        const int dayInWeeks = 7;

        static void Main(string[] args)
        {
            //uses of datatypes and laterals

            int intlit = 100; //for int values
            float flolit = 10.05f; //for decimal values (f in necessary)
            double doublit = 999.99; //more precise than float
            char charlit = 'B'; // only for one character
            string strlit = "hello world"; //for text or sentenec
            bool boollit = false; //for true or false
            object objlit = 42; //fo any value

            //var (copilar will automatically detect daattype)

            var message = "I am learning  C#"; //compiler will detect it as string automatically

            //dynamic (will be change at runtime)

            dynamic myVar = 5; //it is in int
            Console.WriteLine($"Dynamic value: {myVar}");

            myVar = "Now I am a String."; //Now it has become string
            Console.WriteLine($"Dynamic Value: {myVar}");

            // Nullable Types (Agar kisi variable ko NULL bhi rehne dena ho to ? lagate hain)

            int? nullableInt = null; // Is variable me ya to number hoga ya phir NULL
            double? nullableDouble = 3.14; // NULL bhi ho sakta hai aur number bhi
            bool? isEnabled = null; // True/False ya phir NULL bhi ho sakta hai

            // Null Coalescing Operator (??) 
            // Agar variable NULL ho to default value assign ho jaye
            int result = nullableInt ?? 0; // Agar nullableInt NULL hai to 0 use kare
            Console.WriteLine($"Result: {result}");

            //way of assigning default value by conditional statements
            string? name = null;
            if (name == null)
            {
                name = "Default Name";
            }
            Console.ReadLine();
        }
    }
}
