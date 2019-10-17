/* 
C# program to print star pattern 
output : 
       *
       *
      ***
     *****
    *******
*/

using System;
public class pattern
{
    public static void Main(string[] args)
    {
        int i, j, k;
        for (i = 1; i <= 5; i++)
        {
            for (j = i; j < 5; j++)
            {
            	Console.Write(" ");
            }
            for (k = 1; k < (i * 2); k++)
            {
            	Console.Write("*");
            }
            Console.WriteLine();
        }
    	Console.readLine();
    }
}
Završetak čavrljanja
Unesite poruku...

