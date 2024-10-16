using System.Drawing;

namespace RectangleClass;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();

        rectangle.Width = int.Parse(Console.ReadLine());
        rectangle.Height = int.Parse(Console.ReadLine());
        rectangle.Color = Console.ReadLine();

        Console.WriteLine($"Rect({rectangle.Width}, {rectangle.Height}, {rectangle.Color}) has area {rectangle.CalculateArea()}.");
    }
}

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public int CalculateArea()
    {
        return Width * Height;
    }
}
