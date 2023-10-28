using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputString = "This is a sample sentence with words like cat, dog, and bird.";
        string[] result = ExtractWordsWithCriteria(inputString);

        Console.WriteLine("Words of length 4 to 5 containing vowels:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }

    static string[] ExtractWordsWithCriteria(string input)
    {
        // Define a regular expression pattern to match words of length 4 to 5 containing vowels
        string pattern = @"\b[aeiouAEIOU]{0,5}[a-zA-Z]{4,5}[aeiouAEIOU]{0,5}\b";

        // Use Regex to find all matching words
        MatchCollection matches = Regex.Matches(input, pattern);

        // Convert the matches to a string array
        string[] result = matches
            .Cast<Match>()
            .Select(match => match.Value)
            .ToArray();

        return result;
    }
}

