/* 
C# program to print star pattern 
output : 
***
 ***
  ***
   ***
	***
*/

using System;
public class pattern_one
{
    public static void Main(string[] args)
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j < i; j++)
            {
            	Console.Write(" ");
            }
			
            for (j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    	Console.readLine();
    }
}