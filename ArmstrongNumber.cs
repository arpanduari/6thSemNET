using System;

class ArmstrongNumber
{
    static void Main(string[] args)
    {
        printArmStrong(1, 2000);
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
    static void printArmStrong(int start, int end)
    {
        for (int i = start; i <= end; ++i)
        {
            if (checkArmstrong(i))
            {
                Console.WriteLine($"{i} is Armstrong");
            }
        }
    }
}