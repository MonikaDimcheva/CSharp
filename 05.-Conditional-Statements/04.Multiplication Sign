/*Write a program that shows the 
sign (+, - or 0) of the product of 
three real numbers, without calculating it.
    Use a sequence of if operators.
Input
    On the first three lines, you will receive 
the three numbers, each on a separate line
Output
    Output a single line - the sign of the product of the three numbers
Constraints
    The input will always consist of valid floating-point numbers
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if ((firstNumber * secondNumber * thirdNumber) > 0)
        {
            Console.WriteLine("+");
        }
        else if ((firstNumber * secondNumber * thirdNumber) < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

