using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLibrary
{
    public class Motorcycle 
    {
        public int Speed { get; private set; }

        private string _brand;

        public string _model;


        public Motorcycle(string brand, string model) 
        {
            _brand = brand;
            _model = model;
        }

        public void Accelerate (int amount)
        {
            Speed += amount;
        }

        public void Break()
        {
            Speed = 0;
        }

        public void StartEngine()
        {
            Console.WriteLine($"The {_brand} {_model} starts its engine");
        }

        public void ShowSpeed()
        {            
            Console.WriteLine($"The {_brand} {_model} is currently traveling at {Speed} km/h");
        }

    }
}
