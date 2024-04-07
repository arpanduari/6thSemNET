using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        printArmstrong(1, 2000);
    }

    static bool checkArmstrong(int num)
    {
        int numberOfDigits = num.ToString().Length;
        if (numberOfDigits == 1)
        {
            return true;
        }
        int tempNum = num;
        int total = 0;
        while (num > 0)
        {
            int rem = num % 10;
            total += (int)Math.Pow(rem, numberOfDigits);
            num /= 10;
        }
        return total == tempNum;
    }
    static void printArmstrong(int start, int end)
    {
        Console.WriteLine($"Armstrong Number from {start} to {end}: ");
        for (int i = start; i <= end; ++i)
        {
            if (checkArmstrong(i))
            {
                Console.Write($"{i} ");
            }
        }
    }
}