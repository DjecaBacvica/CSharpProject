/* C# program to convert Temprature from Celsius to Fahrenheit */

using System;
public class temp_con
{
    public static void Main(string[] args)
    {
    	int celsius, faren;
		
        Console.WriteLine("Enter the Temperature in Celsius(°C) : ");           
        celsius = int.Parse(Console.ReadLine());
		
        faren = (celsius * 9) / 5 + 32;            
        Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
		
        Console.ReadLine();
    }
}