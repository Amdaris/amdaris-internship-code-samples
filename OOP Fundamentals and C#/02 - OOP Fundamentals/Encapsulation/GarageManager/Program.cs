// See https://aka.ms/new-console-template for more information
using VehicleLibrary;

List<Motorcycle> motorcycles = new List<Motorcycle>();
motorcycles.Add(new Motorcycle("Ducati", "Ninja"));
motorcycles.Add(new Motorcycle("Harley-Davidson", "Nightster"));

foreach (var motorcycle in motorcycles)
{
    motorcycle.StartEngine();
}

//List<Car> cars = new List<Car>();
//cars.Add(new Car("Nissan", "Skyline"));
//cars.Add(new Car("Subaru", "Impreza"));

//foreach (var car in cars)
//{
//    car.StartEnginge();
//}