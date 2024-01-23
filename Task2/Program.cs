var rectangle = new Rectangle();
rectangle.Height = 5;
rectangle.Width = 7;
System.Console.WriteLine(rectangle.GetArea());

public class Rectangle
{
    public double Width{get;set;}
    public double Height{get;set;}
    public double GetArea()
    {
        return Width * Height;
    }
    
}