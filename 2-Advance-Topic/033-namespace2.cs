/*
C# namespace example: by fully qualified name
*/
using System;  
namespace First 
{
	public class Hello
	{  
		public void sayHello() {
			Console.WriteLine("Hello First Namespace"); 
		}
	}
}  

namespace Second  
{  
	public class Hello  
	{  
		public void sayHello(){
			Console.WriteLine("Hello Second Namespace");
		}  
	}  
}  

public class TestNamespace  
{  
	public static void Main()  
	{  
		First.Hello h1 = new First.Hello();  
		Second.Hello h2 = new Second.Hello();  
		h1.sayHello();  
		h2.sayHello();  
	}  
}