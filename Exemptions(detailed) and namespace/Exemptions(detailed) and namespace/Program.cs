using System;
using System.IO;  //for dile not found exception
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemptions_detailed__and_namespace
{
    //Custom Excemption Class
    public class AgeExcemption : Exception
    {
        public AgeExcemption(string message) : base(message) { }
    }

    //class using multiple exceptions
    public class Exceptionexamples
    {
        public void handleexceptions()
        {
            try
            {
                // 1)Index out of Range
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]); //Error

                // 2)null reference
                string price = null;
                Console.WriteLine(price.Length); //Error

                // 3)devide by zero exception
                int num = 10;
                int result = num / 0; //error

                // 4)format exception
                int age = int.Parse("abc"); //error

                // 5)file not found exception
                string filepath = "C:\\nonexistentfile.txt";
                string content = File.ReadAllText(filepath);

                //6)custom exception (Age velidation)
                CheckAge(15); //age less than 18
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Index out of range cought: {ex.Message}");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"null reference cought: {ex.Message}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"devide by zero cought: {ex.Message}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Format excption cought: {ex.Message}");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found cought: {ex.Message}");

            }
            catch (AgeExcemption ex)
            {
                Console.WriteLine($"custom age exception cought: {ex.Message}");

            }
            finally //this block always executes either error or no
            {
                Console.WriteLine("Finally block executed.");
            }
        }

        public void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new AgeExcemption("you are minor you cant get access!");
            }
        }

    }
}
namespace Anothernamespace
{
   // using Exemptions_detailed__and_namespace;  (we can use it to import properties of another namspace)
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("==Exception Handling demo==");
            
            Exemptions_detailed__and_namespace.Exceptionexamples example = new Exemptions_detailed__and_namespace.Exceptionexamples();

            example.handleexceptions();

            Console.WriteLine("\nprogram execution completed");
            Console.ReadLine();
        }
    }
}
