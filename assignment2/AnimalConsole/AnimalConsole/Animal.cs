using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalConsole
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal Talking");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
}
