/*
Local variables can't be sealed.
*/
using System;  
public class TestSealed  
{  
	public static void Main()  
	{  
		sealed int x = 10;  
		x++;  
		Console.WriteLine(x);  
	}  
}