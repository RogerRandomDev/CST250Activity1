using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalConsole
{
    public class Dog : Animal , IDomesticated
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor. Good puppy.");
        }
        public new void Talk()
        {
            Console.WriteLine("Bark Bark Bark");
        }
        public override void Sing()
        {
            Console.WriteLine("Hoooooooowl");
        }
        public void Fetch(String thing)
        {
            Console.WriteLine("Oh boy. here is your " + thing + ". lets do it again!");
        }

        public void TouchMe()
        {
            Console.WriteLine("Please scratch behind my ears.");
        }

        public void FeedMe()
        {
            Console.WriteLine("It's suppertime. the very best time of day!");
        }
    }
}
