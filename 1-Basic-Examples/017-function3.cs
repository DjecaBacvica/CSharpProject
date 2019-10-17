using System;  
namespace FunctionExample  
{  
	class Program  
	{  
		// User defined function  
		public string Show(string message)  
		{  
			Console.WriteLine("Inside Show Function");  
			return message;  
		}  
		
		// Execution entry point of the program  
		static void Main(string[] args)  
		{  
			Program program = new Program();  
			string message = program.Show("Students");  
			Console.WriteLine("Hello "+message);  
		}  
	}  
}