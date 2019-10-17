/* C# program to get ASCII Value of Entered Charactor */

using System;
public class ascii_value
{
    public static void Main(string[] args)
    {
        char character;
    	Console.Write("Enter the character: ");
        character = Char.Parse(Console.ReadLine());
		
        Console.WriteLine("The ASCII value of '" + character + "' : " + (int)character);
		
        Console.ReadLine();
    }
}