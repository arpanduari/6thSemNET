using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the height of the triangle:");
        int height = int.Parse(Console.ReadLine());

        PrintNumberTriangle(height);
    }

    static void PrintNumberTriangle(int height)
    {
        int num = 1;
        for (int i = 1; i <= height; i++)
        {
            // Print spaces to align the numbers correctly
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            // Print numbers for the current row
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine(); // Move to the next line for the next row
        }
    }
}
