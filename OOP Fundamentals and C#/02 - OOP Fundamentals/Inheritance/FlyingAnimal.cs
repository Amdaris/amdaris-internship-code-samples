namespace InheritanceDemo
{
    public abstract class FlyingAnimal
    {
        public string Color { get; private set; }
        public int Wingspan { get; private set; }

        protected FlyingAnimal(string color, int wingspan)
        {
            Color = color;
            Wingspan = wingspan;
        }

        public abstract void Feed();

        public virtual void TakeFlight()
        {
            Console.WriteLine("The flying animal spreads it's wings");
        }
    }
}