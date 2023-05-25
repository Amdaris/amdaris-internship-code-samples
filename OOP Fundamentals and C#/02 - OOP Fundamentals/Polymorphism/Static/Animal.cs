namespace Static
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound");
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine($"{Name} makes the sound: " + sound);
        }

        public static Animal operator +(Animal animal1, Animal animal2)
        {
            string combinedName = animal1.Name + " " + animal2.Name;
            return new Animal(combinedName);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}