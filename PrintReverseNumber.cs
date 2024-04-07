using System;
class PrintReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Reverse of {0} is {1}", num, ReverseNumber(num));
    }
    static int ReverseNumber(int number)
    {
        int reversed = 0;
        while (number != 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        return reversed;
    }
}