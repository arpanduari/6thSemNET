using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to reverse: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine("Reversed number: " + reversedNumber);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return reversedNumber;
    }
}
