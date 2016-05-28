/*Write a program that finds the biggest 
of three numbers that are read from the console.
Input
    On the first three lines you will receive the three numbers, 
each on a separate line.
Output
    On the only output line, write the biggest of the three numbers.
Constraints
    The three numbers will always be valid floating-point 
numbers in the range [-200, 200].
    Time limit: 0.1s
    Memory limit: 16MB

*/
using System;

class BiggestOf3
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        while (firstNumber < -200 || firstNumber > 200)
        {
            firstNumber = double.Parse(Console.ReadLine());
        }
        double secondNumber = double.Parse(Console.ReadLine());
        while (secondNumber < -200 || secondNumber > 200)
        {
            secondNumber = double.Parse(Console.ReadLine());
        }
        double thirdNumber = double.Parse(Console.ReadLine());
        while (thirdNumber < -200 || thirdNumber > 200)
        {
            thirdNumber = double.Parse(Console.ReadLine());
        }

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            Console.WriteLine(thirdNumber);
        }
    }
}

