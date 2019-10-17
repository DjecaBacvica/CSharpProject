using System;  
namespace CallByReference  
{  
	class Program  
	{  
		// User defined function  
		public void Show(ref int val)  
		{  
			 val *= val; // Manipulating value  
			Console.WriteLine("Inside the show function "+val);  
			// No return statement  
		}  
		
		// Main function, execution entry point of the program  
		static void Main(string[] args)  
		{  
			int val = 50;  
			Program program = new Program(); // Creating Object  
			Console.WriteLine("Before calling the function "+val);  
			program.Show(ref val);       
			Console.WriteLine("After calling the function " + val);  
		}  
	}  
}