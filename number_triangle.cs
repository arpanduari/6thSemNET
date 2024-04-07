using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the height of the triangle:");
        int height = int.Parse(Console.ReadLine());

        PrintNumberTriangle(height);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void PrintNumberTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            // Print numbers for the current row
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine(); // Move to the next line for the next row
        }
    }
}
