namespace FindConsonants;

public static class StringExtension
{
    public static void GetConsonant(this string text)
    {
        const string consonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        string result = string.Empty;
        int counter = 0;
        
        foreach (var item in text)
        {
            if (consonant.Contains(item))
            {
                result += item;
                counter++;
            }
        }


        Console.WriteLine($"Consonant letter - {result}\nCount letter - {counter}");
    }

    public static void GetNumber(this string text)
    {
        string number = "1234567890";
        string result = string.Empty;
        int counter = 0;

        foreach (var items in text)
        {
            if (number.Contains(items))
            {
                result += items;
                counter++;
            }
        }

        Console.WriteLine($"number in text - {result}\ncount number - {counter}");
    }
}