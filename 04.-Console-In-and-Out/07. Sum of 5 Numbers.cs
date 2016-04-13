/*Write a program that reads 5 integer numbers 
from the console and prints their sum.
Constraints
    All 5 numbers will always be valid integer
numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class SumOfFiveNumbers
{
    static void Main(string[] args)
    {
        short firstNum = short.Parse(Console.ReadLine());
        short secondNum = short.Parse(Console.ReadLine());
        short thirdNum = short.Parse(Console.ReadLine());
        short fourthNum = short.Parse(Console.ReadLine());
        short fiftNum = short.Parse(Console.ReadLine());
        Console.WriteLine(firstNum+secondNum+thirdNum+fourthNum+fiftNum);
    }
}

