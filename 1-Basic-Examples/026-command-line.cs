using System;  
namespace CSharpProgram  
{  
	class Program  
	{  
		// Main function, execution entry point of the program  
		static void Main(string[] args) // string type parameters  
		{  
			// Command line arguments  
			Console.WriteLine("Argument length: "+args.Length);  
			Console.WriteLine("Supplied Arguments are:");  
			foreach (Object obj in args)  
			{  
				Console.WriteLine(obj);       
			}  
		}  
	}  
}