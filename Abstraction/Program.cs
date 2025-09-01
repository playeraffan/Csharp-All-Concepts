using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    { 
      public abstract void Sound();
        
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.Sound(); // Outputs: Bark
            myDog.Sleep(); // Outputs: Sleeping...

            Console.ReadLine();
        }
    }
}
// Interface (Pure Abstract)
namespace Interface
{
    interface IAnimal
    {
        void Sound();
        void Sleep();
    }
    class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal myCat = new Cat();
            myCat.Sound(); // Outputs: Meow
            myCat.Sleep(); // Outputs: Sleeping...
            Console.ReadLine();
        }
    }
}
