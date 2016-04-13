/*Write a program that enters a number N and 
after that enters more N numbers and calculates 
and prints their sum.
Note: You may need to use a for-loop.
Constraints
    1 <= N <= 200
    All numbers will be valid floating-point numbers in the range [-1000, 1000]
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        double countNumbers = double.Parse(Console.ReadLine());
        while (countNumbers < 1 || countNumbers > 200)
        {
            countNumbers = double.Parse(Console.ReadLine());
        }
        double sum = 0;

        for (double count = 1; count <= countNumbers; count++)
        {
             double n= double.Parse(Console.ReadLine());
             sum += n;
        }
        Console.WriteLine(sum);
    }
}

