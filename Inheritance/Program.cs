using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.youtube.com/watch?v=t7j-C0fRv9k

/* Inheritance:
 * Enables us to build a class based on another class
 * Defines an "is-a" relationship between classes
 * Class that is being inherited is the base (or super) class
 * Class that is inheriting is the child class or subclass
 * Allows for greater code reusability
 * An absolute fundamental part of OOP
 * 
 * 
 */

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Nicholas nick = new Nicholas();
            //Character nick = new Nicholas(); this call also works
            nick.Speak();
            Console.ReadKey();
        }
    }
    class Character
    {
        public string name;
        public void Speak()
        {
            Console.WriteLine($"Hi, my name is {name}!");
        }
    }
    class Tommy : Character
    {
        public Tommy()
        {
            this.name="Tommy";
        }
    }
    class Nicholas : Character
    {
        public Nicholas()
        {
            this.name = "Nick";
        }
    }
}