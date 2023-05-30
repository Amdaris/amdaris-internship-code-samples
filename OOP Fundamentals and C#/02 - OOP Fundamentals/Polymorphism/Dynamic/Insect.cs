using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    public class Insect :Animal, IAirbornAnimal
    {
        public void Fly()
        {
            Console.WriteLine("My 4 wings are flapping");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bzzt");
        }
    }
}
