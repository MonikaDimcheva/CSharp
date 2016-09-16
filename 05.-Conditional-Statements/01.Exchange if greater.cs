/*Write a program that reads two double values from 
the console A and B, stores them in variables and 
exchanges their values if the first one is greater 
than the second one. Use an if-statement. 
As a result print the values of the variables 
A and B, separated by a space.
Constraints
    A and B will always be valid real numbers between 
-100 and 100
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        double firstNumber = double.Parse(Console.ReadLine());
        while (firstNumber < -100 || firstNumber > 100)
        {
            firstNumber = double.Parse(Console.ReadLine());
        }
        double secondNumber = double.Parse(Console.ReadLine());
        while (secondNumber < -100 || secondNumber > 100)
        {
            secondNumber = double.Parse(Console.ReadLine());
        }

        if (firstNumber > secondNumber)
        {
            double temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
        else
        {
            Console.WriteLine(firstNumber + " " + secondNumber);
        }
    }
}
