using System;      
public class IfExample  
{  
	public static void Main(string[] args)  
	{  
		Console.WriteLine("Enter a number to check grade:");  
		int num = Convert.ToInt32(Console.ReadLine());  

		if (num <0 || num >100)  
		{  
			Console.WriteLine("wrong number");  
		}  
		else if(num >= 0 && num < 35)
		{  
			Console.WriteLine("Fail");  
		}  
		else if (num >= 35 && num < 50)  
		{  
			Console.WriteLine("D Grade");  
		}  
		else if (num >= 50 && num < 70)  
		{  
			Console.WriteLine("C Grade");  
		}  
		else if (num >= 70 && num < 90)  
		{  
			Console.WriteLine("B Grade");  
		}  
		else if (num >= 90 && num < 100)  
		{  
			Console.WriteLine("A Grade");  
		}    
	}  
}