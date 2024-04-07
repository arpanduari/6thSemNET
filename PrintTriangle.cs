using System;

class PrintTriangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows for the triangle: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
