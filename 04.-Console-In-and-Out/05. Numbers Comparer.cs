/*Write a program that gets two numbers from 
the console and prints the greater of them.
Output
    On the only line print the larger of the two numbers
    *Try implementing it without using if-statements
Constraints
    The input will always be valid and in the described format.
    The numbers A and B will always be valid real number
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine((firstNumber > secondNumber) ? firstNumber : secondNumber);
    }
}

