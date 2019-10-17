/*
In C# programming, exception handling is performed by try/catch statement. 
The try block in C# is used to place the code that may throw exception. 
The catch block is used to handled the exception. 
The catch block must be preceded by try block.
*/
using System;  
public class ExExample  
{  
	public static void Main(string[] args)  
	{  
		try  
		{  
			int a = 10;  
			int b = 0;  
			int x = a / b;  
		}  
		catch (Exception e) 
		{ 
			Console.WriteLine(e); 
		}  
  
		Console.WriteLine("Rest of the code");  
	}  
}