/*Write a program that enters 3 real numbers and prints them 
sorted in descending order.
    Use nested if statements.
    Don’t use arrays and the built-in sorting functionality.
Input
   On the first three lines, you will receive the three 
numbers, each on a separate line.

Output
    Output a single line on the console - the sorted numbers, 
separated by a whitespace
Constraints
    The three numbers will always be valid integer numbers
in the range [-1000, 1000]
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class Sort3Numbers
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        while (firstNumber < -1000 || firstNumber > 1000)
        {
            firstNumber = double.Parse(Console.ReadLine());
        }
        double secondNumber = double.Parse(Console.ReadLine());
        while (secondNumber < -1000 || secondNumber > 1000)
        {
            secondNumber = double.Parse(Console.ReadLine());
        }
        double thirdNumber = double.Parse(Console.ReadLine());
        while (thirdNumber < -1000 || thirdNumber > 1000)
        {
            thirdNumber = double.Parse(Console.ReadLine());
        }
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber)
        {
            if (secondNumber >= thirdNumber)
            {

                Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + " " + thirdNumber + " " + secondNumber);
            }
        }
        if (secondNumber > firstNumber && secondNumber >= thirdNumber)
        {
            if (firstNumber >= thirdNumber)
            {
                Console.WriteLine(secondNumber + " " + firstNumber + " " + thirdNumber);
            }
            else
            {
                Console.WriteLine(secondNumber + " " + thirdNumber + " " + firstNumber);
            }
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(thirdNumber + " " + firstNumber + " " + secondNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber + " " + secondNumber + " " + firstNumber);
            }
        }
    }
}

