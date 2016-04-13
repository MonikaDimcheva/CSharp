/*Write a program that reads the 
coefficients a, b and c of a quadratic 
equation ax2 + bx + c = 0 and solves it (prints its real roots).
Output
    If two different real roots exist, print them on two separate lines
Print the smaller root on the first line
    If only one real root exists, print it on the only output line
    If no real root exists, print the string "no real roots"
    The roots, should they exist, must be printed with
precision exactly two digits after the floating point
Constraints
    The input will always consist of valid real numbers 
in the range [-1000, 1000] and will follow the described format
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double descriminant = (b * b) - 4 * (a * c);
        double firstRoot;
        double secondRoot;

        if (descriminant > 0)
        {
            firstRoot = -b - Math.Sqrt(descriminant) / (2 * a);
            secondRoot = -b + Math.Sqrt(descriminant) / (2 * a);
            if (firstRoot < secondRoot)
            {
                Console.WriteLine("{0:F2}", firstRoot);
                Console.WriteLine("{0:F2}", secondRoot);
            }
            else
            {
                Console.WriteLine("{0:F2}", secondRoot);
                Console.WriteLine("{0:F2}", firstRoot);
            }
        }
        else if (descriminant == 0)
        {
            firstRoot = secondRoot = (-b) / (2 * a);
            Console.WriteLine("{0:F2}", firstRoot);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}

