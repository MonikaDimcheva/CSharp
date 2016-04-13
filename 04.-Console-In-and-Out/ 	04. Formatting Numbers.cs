/*Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
The program then prints them in 4 virtual columns on the console. 
Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.
*/
using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            a = int.Parse(Console.ReadLine());
        }
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string aToHex = a.ToString("X");
        string aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');

        // Console.WriteLine("     a     " + "        b     " + "        c     " + "        result      ");
        // Console.WriteLine("      {0}         {1}       {2}      {3} |{4}| {5:F2}|{6:F3} |      ", a, b, c, aToHex,aToBinary,b,c);

        for (int i = 0; i <= 1; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                if (i == 0)
                {
                    Console.Write("\na\t");
                    Console.Write("b\t");
                    Console.Write("c\t");
                    Console.WriteLine("result");
                    break;
                }
                else if (i == 1)
                {
                    Console.Write(a + "\t");
                    Console.Write(b + "\t");
                    Console.Write(c + "\t");
                    Console.WriteLine(aToHex + " |" + aToBinary + "| {0:F2}|{1:F3} |", b, c);
                    break;
                }
            }
        }
    }
}

