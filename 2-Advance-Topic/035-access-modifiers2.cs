/*
C# Access modifiers or specifiers are the keywords that are used to specify accessibility 
or scope of variables and functions in the C# application.

C# provides five types of access specifiers.

Public
Protected
Internal
Protected internal
Private

We can choose any of these to protect our data. 
Public is not restricted and Private is most restricted. 
The following table describes about the accessibility of each.
*/

using System;  
namespace AccessSpecifiers  
{  
	class ProtectedTest  
	{  
		protected string name = "Shashikant";  
		protected void Msg(string msg)  
		{  
			Console.WriteLine("Hello " + msg);  
		}  
	}  
	class Program  
	{  
		static void Main(string[] args)  
		{  
			ProtectedTest protectedTest = new ProtectedTest();  
			// Accessing protected variable  
			Console.WriteLine("Hello "+ protectedTest.name);  
			// Accessing protected function  
			protectedTest.Msg("Swami Ayyer");  
		}  
	}  
}