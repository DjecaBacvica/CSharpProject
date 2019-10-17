/*
Namespaces in C# are used to organize too many classes so that it can be easy to handle the application.
In a simple C# program, we use System.
Console where System is the namespace and Console is the class. 
To access the class of a namespace, we need to use namespacename.classname. 
We can use using keyword so that we don't have to use complete name all the time.
In C#, global namespace is the root namespace. 
The global::System will always refer to the namespace "System" of .Net Framework.
*/
using System;  
namespace ConsoleApplication1  
{  
	class Program  
	{  
		static void Main(string[] args)  
		{  
			Console.WriteLine("Hello Namespace!");  
		}  
	}  
}