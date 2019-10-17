/* C# program to find Cube Root of enterd number  */

using System;
public class find_cube_root
{
    public static void Main(string[] args)
    {
        double num, res;

        Console.Write("Enter the Number : ");

        num = double.Parse(Console.ReadLine());

        res = Math.Ceiling(Math.Pow(num, (double)1 / 3));

        Console.Write("Cube Root : " + res);
		
    	Console.readLine();
    }
}