// See https://aka.ms/new-console-template for more information
using System;
public class Harmonic
{
    public static void Main()
    {
        int i, n;
        double sum = 0.0;

        Console.Write("Enter the value of N : ");
        n = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            Console.Write("1/{0} + ", i);
            sum += 1 / (float)i;

        }
        Console.Write("\nSum of Series upto {0} terms is: {1} \n", n, sum);
    }
}