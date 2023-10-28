using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Decimal to Binary Conversion");
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryResult = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Binary: {binaryResult}");

        Console.WriteLine("\nBinary to Decimal Conversion");
        Console.Write("Enter a binary number: ");
        string binaryNumber = Console.ReadLine();

        int decimalResult = BinaryToDecimal(binaryNumber);
        Console.WriteLine($"Decimal: {decimalResult}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }
}

