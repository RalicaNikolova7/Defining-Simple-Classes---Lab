namespace RandomizeWords;

class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(' ');

        Random rnd = new Random();

        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {

            int pos2 = rnd.Next(words.Length);

            var a = words[pos2];
            var b = words[pos1];

            words[pos2] = b;
            words[pos1] = a;

            // TODO: Swap words[pos1] with words[pos2]
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}

