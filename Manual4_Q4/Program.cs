using System;

class Program
{
    static void Main()
    {
        int[] responses = { 3, 4, 2, 3, 4, 5, 3, 2, 1, 4, 3, 4, 5, 5, 3, 2, 2, 4, 4, 3, 1, 3, 5, 4, 3, 2, 4, 3, 2, 2, 5, 4, 3, 1, 2, 3, 5, 4, 4 };

        // Initialize an array to store the frequency of each response
        int[] frequency = new int[5];

        // Count the frequency of each response
        foreach (int response in responses)
        {
            frequency[response - 1]++;
        }

        // Display the frequency summary
        for (int i = 0; i < frequency.Length; i++)
        {
            int responseNumber = i + 1;
            int count = frequency[i];
            Console.WriteLine($"Response {responseNumber} given by: {count} people");
        }
    }
}
