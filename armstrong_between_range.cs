using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the last number: ");
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            Console.WriteLine("Invalid input: The last number should be greater than or equal to the first number.");
            return;
        }

        Console.WriteLine("Armstrong numbers between " + start + " and " + end + " are: ");
        for (int num = start; num <= end; num++)
        {
            if (IsArmstrong(num))
            {
                Console.WriteLine(num + " is Armstrong");
            }
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Method to check if a number is an Armstrong number
    static bool IsArmstrong(int num)
    {
        // Handle negative numbers
        if (num < 0)
            return false;

        int sum = 0;
        int originalNum = num;
        int digits = CountDigits(num);

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }

        return sum == originalNum;
    }

    // Method to count the number of digits in a number
    static int CountDigits(int num)
    {
        int count = 0;
        while (num != 0)
        {
            count++;
            num /= 10;
        }
        return count;
    }
}
