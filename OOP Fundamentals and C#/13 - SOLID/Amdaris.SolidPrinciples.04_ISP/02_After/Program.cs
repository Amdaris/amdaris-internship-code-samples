Console.WriteLine("ISP overview");

#region Classes
public interface IAnimal
{
    void Eat();
    void Sleep();
}

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public class Bird : IAnimal, IFlyable
{
    public void Eat()
    {
        // Code for eating
    }

    public void Sleep()
    {
        // Code for sleeping
    }

    public void Fly()
    {
        // Code for flying
    }
}

public class Fish : IAnimal, ISwimmable
{
    public void Eat()
    {
        // Code for eating
    }

    public void Sleep()
    {
        // Code for sleeping
    }

    public void Swim()
    {
        // Code for swimming
    }
}
#endregion
