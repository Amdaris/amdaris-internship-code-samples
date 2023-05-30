namespace VehicleLibrary
{
    internal class Car : Vehicle
    {
        private string _model;

        public Car(string brand, string model) : base(brand)
        {
            _model = model;
        }

        public void StartEngine()
        {
            string model = _model;

            string brand = Brand;

            Console.WriteLine($"The {brand} {model} starts its engine");
        }

        public void ShowSpeed()
        {
            string model = _model;

            string brand = Brand;
            int speed = base.speed;

            Console.WriteLine($"The {brand} {model} is currently traveling at {speed} km/h");
        }
    }
}