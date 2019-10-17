/* C# program to perform various Trigonomatric Function */

using System;
public class trigonometric_function
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Trignometric values in Degree");

        Console.WriteLine("sin (60) = {0}", Math.Sin(60 * Math.PI / 180));

        Console.WriteLine("cos (60) = {0}", Math.Cos(60 * Math.PI / 180));

        Console.WriteLine("tan (60) = {0}", Math.Tan(60 * Math.PI / 180));

        Console.WriteLine("arcsin (1/2) = {0}", Math.Asin(0.5) * 180 / Math.PI);

        Console.WriteLine("arccos (1/2) = {0}", Math.Acos(0.5) * 180 / Math.PI);

        Console.WriteLine("arctan (1/2) = {0}", Math.Atan(0.5) * 180 / Math.PI);
		
    	Console.readLine();
    }
}