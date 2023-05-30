namespace VehicleLibrary
{
    internal class Vehicle
    {
        private string _brand;

        protected int speed;

        public Vehicle(string brand)
        {
            _brand = brand;
            speed = 0;
        }

        public string Brand
        { get { return _brand; } }

        public void Accelerate(int amount)
        {
            speed += amount;
        }

        public void Break()
        {
            speed = 0;
        }
    }
}