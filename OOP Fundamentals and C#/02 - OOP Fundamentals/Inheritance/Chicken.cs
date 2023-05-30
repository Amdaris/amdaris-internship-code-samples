namespace InheritanceDemo
{
    public class Chicken : FlyingAnimal
    {
        public Chicken(string color, int wingspan) : base(color, wingspan)
        {
        }

        public override void Feed()
        {
            Console.WriteLine("The chicken eats grain");
        }

        public override void TakeFlight()
        {
            Console.WriteLine("The chicken is not very good at flying");
        }
    }
}