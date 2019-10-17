/*
Enum in C# is also known as enumeration. 
It is used to store a set of named constants such as season, days, month, size etc. 
The enum constants are also known as enumerators. 
Enum in C# can be declared within or outside class and structs.

Enum constants has default values which starts from 0 and incremented to one by one. 
But we can change the default value.

Points to remember
enum has fixed set of constants
enum improves type safety
enum can be traversed
*/
using System;  
public class EnumExample  
{  
	public enum Season { WINTER, SPRING, SUMMER, FALL }    
  
	public static void Main()  
	{  
		int x = (int)Season.WINTER;  
		int y = (int)Season.SUMMER;  
		Console.WriteLine("WINTER = {0}", x);  
		Console.WriteLine("SUMMER = {0}", y);  
	}  
}