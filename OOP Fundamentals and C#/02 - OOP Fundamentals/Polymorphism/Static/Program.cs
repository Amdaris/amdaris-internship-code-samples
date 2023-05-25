using Static;

Animal animal = new Animal("Generic Animal");
animal.MakeSound();
animal.MakeSound("Roar!");

Dog dog = new Dog("Rufus");
dog.MakeSound();
dog.MakeSound(3);

Cat cat = new Cat("Fluffy");
cat.MakeSound();

Animal dogAnimal = new Animal("Robert");
Animal catAnimal = new Animal("Snowball");
Animal combinedAnimal = dogAnimal + catAnimal;

Console.WriteLine(combinedAnimal);