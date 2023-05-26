// See https://aka.ms/new-console-template for more information
using InheritanceDemo;

Animal animal = new Animal("Generic Animal", "Blue");
Console.WriteLine(animal.Name);
Console.WriteLine(animal.Color);
Dog dog = new Dog("Rufus", "Brown");
Console.WriteLine(dog.Name);
Console.WriteLine(dog.Color);

Eagle eagle = new Eagle("Brown", 2);
Chicken chicken = new Chicken("Red", 1);

MakeAnimalSound(eagle);
//MakeAnimalSound(chicken); -- this will not work because Chicken does not implement IAnimalWithSound
FeedAnimal(eagle);
FeedAnimal(chicken);
TakeFlight(eagle);
TakeFlight(chicken);

void MakeAnimalSound(IAnimalWithSound animal)
{
    animal.MakeSound();
}

void FeedAnimal(FlyingAnimal animal)
{
    animal.Feed();
}

void TakeFlight(FlyingAnimal animal)
{
    animal.TakeFlight();
}