using System.Globalization;

namespace DayOfWeeek;

class Program
{
    static void Main(string[] args)
    {
        string dateAsText = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateAsText, "dd-M-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine(date.DayOfWeek);
    }
}
