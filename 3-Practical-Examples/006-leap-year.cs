/* C# program to find Enterd year is Leap Year or not  */

using System;
public class leap_year
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Year in Four Digits : ");
        y = Convert.ToInt32(Console.ReadLine());
		
        if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
        {
            Console.WriteLine("{0} is a Leap Year", y);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year", y);
        }
        Console.ReadLine();
    }
}