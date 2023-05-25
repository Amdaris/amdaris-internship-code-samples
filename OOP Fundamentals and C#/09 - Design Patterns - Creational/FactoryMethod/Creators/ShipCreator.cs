using FactoryMethod.Models;

namespace FactoryMethod.Creators
{
    public class ShipCreator : TransportCreator
    {
        public override Transport CreateTransport(float capacity, string name)
        {
            return new Ship
            {
                Capacity = capacity,
                Name = name
            };
        }
    }
}
