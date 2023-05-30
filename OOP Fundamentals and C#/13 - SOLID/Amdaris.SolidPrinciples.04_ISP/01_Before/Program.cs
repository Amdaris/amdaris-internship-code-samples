Console.WriteLine("ISP overview");

#region Classes
public interface IAnimal
{
    void Eat();
    void Sleep();
    void Fly();
    void Swim();
}

public class Bird : IAnimal
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

    public void Swim()
    {
        throw new NotImplementedException();
    }
}

public class Fish : IAnimal
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
        throw new NotImplementedException();
    }

    public void Swim()
    {
        // Code for swimming
    }
}
#endregion
