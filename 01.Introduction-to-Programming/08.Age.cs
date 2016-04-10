/*Write a program that reads your birthday
(in the format MM.DD.YYYY) from the console 
and prints on the console how old you are 
you now and how old will you be after 10 years.
*/
using System;

class Age
{
    static void Main(string[] args)
    {
        DateTime input = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int currentAge = now.Year - input.Year;
        if (now < input.AddYears(currentAge)) currentAge--;
        Console.WriteLine(currentAge);
        Console.WriteLine(currentAge+10);
    }
}

