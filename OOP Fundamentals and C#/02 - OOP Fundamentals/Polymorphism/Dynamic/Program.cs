using Dynamic;

Animal[] animals = new Animal[]
{
    new Cat(),
    new Dog(),
    new Bird(),
    new Insect()
};

foreach (Animal animal in animals)
{
    animal.MakeSound();    
}

IAirbornAnimal[] flyingAnimals = new IAirbornAnimal[]
{
    new Bird(),
    new Insect()
};
foreach (IAirbornAnimal flyingAnimal in flyingAnimals)
{
    flyingAnimal.Fly();
}