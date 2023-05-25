namespace Static
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void MakeSound(int intensity)
        {
            string barkSound = new string('!', intensity);
            Console.WriteLine($"{Name} barks with intensity: " + barkSound);
        }
    }
}