/* C# program to perform various Bitwise operations */

using System;
public class bitwise_op
{
    public static void Main(string[] args)
    {
    	 int a = 60;            /* 60 = 0011 1100 */ 
         int b = 13;            /* 13 = 0000 1101 */
         int c = 0; 
         
         c = a & b;             /* 12 = 0000 1100 */ 
         Console.WriteLine("Line 1 - Value of c is ", c );
         
         c = a | b;             /* 61 = 0011 1101 */
         Console.WriteLine("\nLine 2 - Value of c is ", c);
         
         c = a ^ b;             /* 49 = 0011 0001 */
         Console.WriteLine("\nLine 3 - Value of c is ", c);
         
         c = ~a;                /*-61 = 1100 0011 */
         Console.WriteLine("\nLine 4 - Value of c is ", c);
         
         c = a << 2;      /* 240 = 1111 0000 */
         Console.WriteLine("\nLine 5 - Value of c is ", c);
         
         c = a >> 2;      /* 15 = 0000 1111 */
         Console.WriteLine("\nLine 6 - Value of c is ", c);
         Console.ReadLine();
    }
}