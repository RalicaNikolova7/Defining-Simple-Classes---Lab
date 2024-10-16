using System.Drawing;

namespace DayOfWeek;

public class Rectangle
{
    private int width;
    private int height;
    private string color;

    public int Width { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    static int CalculateArea(int width, int height)
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();

        Console.WriteLine($"Rect({rectangle.Width}, {rectangle.Height}, {rectangle.Color}) has area {(rectangle.Width)}.");
    }
}

