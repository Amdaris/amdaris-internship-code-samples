using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Bird : Animal, IAirbornAnimal
    {
        public void Fly()
        {
            Console.WriteLine("My 2 wings are flapping");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
