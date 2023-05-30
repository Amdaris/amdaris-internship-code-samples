Rectangle rectangle = new Square();

rectangle.Width = 5;
rectangle.Height = 10;

Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");

#region Classes
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int CalculateArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; } 
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
}
#endregion
