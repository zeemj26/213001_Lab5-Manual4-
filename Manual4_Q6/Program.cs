using System;

class Program
{
    static void Main()
    {
        // Define a 2D rectangular array to store test marks
        int[,] testMarks = new int[5, 10];

        // Initialize the array with sample test marks (you can replace these values)
        InitializeTestMarks(testMarks);

        // Display the test marks for each course and student
        DisplayTestMarks(testMarks);
    }

    static void InitializeTestMarks(int[,] marks)
    {
        // Initialize the array with sample test marks (you can replace these values)
        for (int course = 0; course < 5; course++)
        {
            for (int student = 0; student < 10; student++)
            {
                marks[course, student] = 70 + course * 5 + student;
            }
        }
    }

    static void DisplayTestMarks(int[,] marks)
    {
        Console.WriteLine("Test Marks for 5 Courses and 10 Students:");

        for (int student = 0; student < 10; student++)
        {
            Console.WriteLine($"Student {student + 1}:");

            for (int course = 0; course < 5; course++)
            {
                Console.WriteLine($"  Course {course + 1}: {marks[course, student]}");
            }

            Console.WriteLine();
        }
    }
}

