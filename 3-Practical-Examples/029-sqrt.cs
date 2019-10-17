/* C# program to find Square Root of Entered number  */

using System;
public class find_square_root
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number : ");

        int Number = Convert.ToInt32(Console.ReadLine());

        double SqrtNumber = Math.Sqrt(Number);

        Console.WriteLine("Square root of "+Number+" is: "+SqrtNumber);

        Console.ReadLine();
    }
}