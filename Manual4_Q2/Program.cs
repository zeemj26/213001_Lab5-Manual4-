using System;

class Program
{
    static void Main()
    {
        string[] words = {
            "hello",
            "and",
            "welcome",
            "to",
            "this",
            "demo!"
        };

        string result = Merger(words);

        Console.WriteLine(result);
    }

    static string Merger(string[] array)
    {
        // Use string.Join to concatenate the elements of the array
        string mergedString = string.Join(" ", array);
        return mergedString;
    }
}

