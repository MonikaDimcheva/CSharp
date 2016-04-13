/*Write a program that reads an integer number N 
from the console and prints all the numbers in 
the interval [1, n], each on a single line.
Output
    You should print the numbers from 1 to N, each on a separate line
Constraints
    1 <= N < 1000
    N will always be a valid integer number
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        while (number < 1 || number > 1000)
        {
            number = int.Parse(Console.ReadLine());
        }
        for (int count = 1; count <= number; count++)
        {
            Console.WriteLine(count);
        }
    }
}

