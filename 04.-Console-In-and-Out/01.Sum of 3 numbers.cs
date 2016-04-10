/*Write a program that reads 3 real numbers 
from the console and prints their sum.
Input
    1.On the first line, you will receive the number a
    2.On the second line, you will receive the number b
    3.On the third line, you will receive the number c
Output-Your output should consist only of a single line - 
the sum of the three numbers.
Constraints
    1.a, b and c will always be valid real numbers 
    between -1000 and 1000, inclusive
    2.Time limit: 0.1s
    3.Memory limit: 16MB
*/
using System;

class SumOfThreeNumbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        while ((a <= -1000) || (a >= 1000))
        {
            a = double.Parse(Console.ReadLine());
        }
        while ((b <= -1000) || (b >= 1000))
        {
            b = double.Parse(Console.ReadLine());
        }
        while ((c <= -1000) || (c >= 1000))
        {
            c = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(a + b + c);
    }
}
