/*Write a program that reads two positive 
integer numbers N and M and prints how many 
numbers exist between them such that the reminder 
of the division by 5 is 0.
Constraints
    0 <= N <= M <= 2000
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class Interval
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int sum = 0;
        while (firstNumber < 0 || firstNumber > secondNumber || firstNumber > 2000)
        {
            firstNumber = int.Parse(Console.ReadLine());
        }
        while (secondNumber < 0 || secondNumber > 2000)
        {
            secondNumber = int.Parse(Console.ReadLine());
        }

        for (int count = firstNumber + 1; count < secondNumber; count++)
        {
            if (count % 5 == 0)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);
    }
}

