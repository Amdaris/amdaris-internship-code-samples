using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class TruckCreator : TransportCreator
    {
        public override Transport CreateTransport(float capacity, string name)
        {
            return new Truck
            {
                Capacity = capacity,
                Name = name
            };
        }
    }
}
