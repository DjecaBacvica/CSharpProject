/* C# program to find entered number is Odd or Even */

using System;
public class Exercise1
{
    public static void Main(string[] args)
    {
        int i;
        Console.Write("Enter a Number : ");
        i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.Write("Entered Number is an Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.Read();
        }		
    }
}