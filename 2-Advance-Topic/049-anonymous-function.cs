/*
Anonymous function is a type of function that does not has name. 
In other words, we can say that a function without name is known as anonymous function.
In C#, there are two types of anonymous functions:
Lambda Expressions
Anonymous Methods
C# Lambda Expressions
Lambda expression is an anonymous function which we can use to create delegates. 
We can use lambda expression to create local functions that can be passed as an argument. 
It is also helpful to write LINQ queries.
C# Lambda Expression Syntax

(input-parameters) => expression
*/

using System;  
namespace LambdaExpressions  
{  
	class Program  
	{  
		delegate int Square(int num);  
		static void Main(string[] args)  
		{  
			Square GetSquare = x => x * x;  
			int j = GetSquare(5);    
			Console.WriteLine("Square: "+j);  
		}  
	}  
}
---
using System;  
namespace AnonymousMethods  
{  
	class Program  
	{  
		public delegate void AnonymousFun();  
		static void Main(string[] args)  
		{  
			AnonymousFun fun = delegate () {  
				Console.WriteLine("This is anonymous function");  
			};  
			fun();  
		}  
	}
}	