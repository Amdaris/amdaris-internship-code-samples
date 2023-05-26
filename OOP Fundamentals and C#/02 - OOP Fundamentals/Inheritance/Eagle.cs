namespace InheritanceDemo
{
    public class Eagle : FlyingAnimal, IAnimalWithSound
    {
        public Eagle(string color, int wingspan) : base(color, wingspan)
        {
        }

        public override void Feed()
        {
            Console.WriteLine("The hawk eats meat");
        }

        public void MakeSound()
        {
            Console.WriteLine("The hawk screeches");
        }
    }
}