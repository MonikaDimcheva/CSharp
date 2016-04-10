/*Write a program that prints the first 
1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
*/

using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
        //Console.BufferHeight = 1010;
        for (int num = 2; num <= 1001; num++)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(-num);
            }
        }
    }
}

