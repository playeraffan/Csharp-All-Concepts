using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Overriding_
{
    class Animal
    {
      public virtual void makesound()
        {
            Console.WriteLine("Animal makes Sound");
        }
    }
    class Cat : Animal
    {
        public override void makesound() 
        {
            Console.WriteLine("Cat sound ; meow!");
        }
    }
    class Dog : Animal
    {
        public override void makesound()
        {
            Console.WriteLine("Dog sound ; bow!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal sound =  new Animal();
            sound.makesound();

            Animal catsound = new Cat();
            catsound.makesound();

            Animal dogsound = new Dog();
            dogsound.makesound();
            Console.ReadLine();

        }
    }
}
