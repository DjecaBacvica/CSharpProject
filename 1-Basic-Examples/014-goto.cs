using System;  
public class GotoExample
{  
	public static void Main(string[] args)  
	{  
		suitable:  
		Console.WriteLine("You are not suitable to vote!");  

		Console.WriteLine("Enter your age:\n");  
		int age = Convert.ToInt32(Console.ReadLine());  
		if (age < 18)
		{  
			goto suitable;  
		}  
		else  
		{  
			Console.WriteLine("You are suitable to vote!");   
		}  
	}  
 }