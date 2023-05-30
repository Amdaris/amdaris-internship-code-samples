Shape rectangle = new Rectangle() { Width = 5, Height = 10 };
Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");

Shape square = new Square() { SideLength = 5 };
Console.WriteLine($"Square area: {square.CalculateArea()}");

#region Classes
public class Shape
{
    public virtual int CalculateArea()
    {
        return 0;
    }
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public int SideLength { get; set; }

    public override int CalculateArea()
    {
        return SideLength * SideLength;
    }
}
#endregion
