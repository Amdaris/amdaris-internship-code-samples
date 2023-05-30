using System.Net.Http.Headers;

namespace GenericsDemo
{
    public interface ILivingBeing
    {
        string Name { get; }
    }

    public class Plant : ILivingBeing
    {
        public string Name { get; set; }

        public int Height { get; private set; }

        public void Grow()
        {
            Console.WriteLine("Growing");
            Height++;
        }
    }

    public class Animal<K> : ILivingBeing where K : class
    {
        public string Name { get; set; }

        public int Weight { get; set; }

        public void Eat(K food)
        {
            Console.WriteLine($"Eating {food}");
        }
    }

    public class Herbivore : Animal<Plant>
    {
    }

    public class Predator<K> : Animal<K> where K : Herbivore
    {
    }

    public class Farmer
    {
        public void Feed<T, K>(T animal, K food) where T : Animal<K> where K : class
        {
            Console.WriteLine($"Feeding {animal} with {food}");
        }

        public void Feed<T, K>(T animal) where T : Animal<K> where K : class, new()
        {
            Console.WriteLine("Preparing the food");
            K food = new K();
            Console.WriteLine($"Feeding {animal} with {food}");
        }
    }

    public class GenericsDemo
    {
        public static void Main(string[] args)
        {
            Plant grass = new Plant();
            Herbivore antelope = new Herbivore();
            Predator<Herbivore> lion = new Predator<Herbivore>();

            antelope.Eat(grass);
            //antelope.Eat(lion); // Compile-error
            lion.Eat(antelope); // OK

            Farmer farmer = new Farmer();
            //farmer.Feed(lion, grass); // Compile-error, farmer can feed an animal only apropriate food
            farmer.Feed(antelope, grass);

            farmer.Feed<Herbivore, Plant>(antelope);

            Mouse mouse = new Mouse();
            farmer.Feed<Mouse, Cheese>(mouse, new Cheese(""));
            //farmer.Feed<Mouse, Cheese>(mouse);
        }
    }

    public class Mouse : Animal<Cheese>
    {
    }

    public class Cheese
    {
        public Cheese(string kind)
        {
            Kind = kind;
        }

        public string Kind { get; }
    }

}