/*Write a program that finds the biggest of 5 numbers that 
are read from the console, using only 5 if statements.
Input
    On the first 5 lines you will receive the 5 numbers,
each on a separate line
Output
    On the only output line, write the biggest of the 5 numbers
Constraints
    The 5 numbers will always be valid floating-point 
numbers in the range [-200, 200]
    Time limit: 0.1s
    Memory limit: 16MB

*/
using System;

class BiggestOf5
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

        double fourthNumber = double.Parse(Console.ReadLine());
        while (fourthNumber < -200 || fourthNumber > 200)
        {
            fourthNumber = double.Parse(Console.ReadLine());
        }
        double fifthNumber = double.Parse(Console.ReadLine());
        while (fifthNumber < -200 || fifthNumber > 200)
        {
            fifthNumber = double.Parse(Console.ReadLine());
        }
        if (firstNumber >= secondNumber && firstNumber >= thirdNumber
            && firstNumber >= fourthNumber && firstNumber >= fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }
        if (secondNumber > firstNumber && secondNumber >= thirdNumber
           && secondNumber >= fourthNumber && secondNumber >= fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }
        if (thirdNumber > firstNumber && thirdNumber > secondNumber
          && thirdNumber >= fourthNumber && thirdNumber >= fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }
        if (fourthNumber > firstNumber && fourthNumber > secondNumber
          && fourthNumber > thirdNumber && fourthNumber >= fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }
        if (fifthNumber > firstNumber && fifthNumber > secondNumber
          && fifthNumber > thirdNumber && fifthNumber > fourthNumber)
        {
            Console.WriteLine(fifthNumber);
        }
    }
}
