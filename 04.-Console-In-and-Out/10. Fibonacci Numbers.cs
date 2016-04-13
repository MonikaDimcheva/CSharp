/*Write a program that reads a number N and prints on 
the console the first N members of the Fibonacci sequence 
(at a single line, separated by comma and space - ", ")
: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Constraints
    1 <= N <= 50
    N will always be a valid positive integer number
    Time limit: 0.1s
    Memory limit: 16MB
*/
using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        long count = long.Parse(Console.ReadLine());

        while (count < 1 || count > 50)
        {
            count = long.Parse(Console.ReadLine());
        }

        long temp = 0;
        long first = 0;
        long second = 1;

        if (count == 1)
        {
            Console.WriteLine("0");
        }
        else if (count == 2)
        {
            Console.WriteLine("0, 1");
        }
        else {
            Console.Write("0, 1, ");
            for (long i = 0; i <= count - 3; i++)
            {
                temp = first + second;
                first = second;
                second = temp;

                if (i == count - 3)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.Write(temp + ", ");
                }
            }
        }
    }
}
