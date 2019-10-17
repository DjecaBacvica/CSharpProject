using System;  
namespace FunctionExample  
{  
	class Program  
	{  
		// User defined function without return type  
		public void Show() // No Parameter  
		{  
			Console.WriteLine("Function Call without parameter");  
			// No return statement  
		}  

		// Execution entry point of the program  
		static void Main(string[] args)  
		{  
			Program program = new Program(); // Creating Object  
			program.Show(); // Calling Function             
		}  
	}
}