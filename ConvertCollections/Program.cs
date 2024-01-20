// See https://aka.ms/new-console-template for more information

using ConvertCollections;

internal class Program
{
    public static void Main(string[] args)
    {
        IEnumerable<object> objects = new List<object>() { "str", "text", "word" };
        IEnumerable<string> strings = objects.Convert<object, string>();

        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }

        IEnumerable<string> text = new List<string>() { "2", "1", "3" };
        IEnumerable<int> ints = text.Convert<string, int>();

        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }
    }
}