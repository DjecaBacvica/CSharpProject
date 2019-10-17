/*
A destructor works opposite to constructor, It destructs the objects of classes. 
It can be defined only once in a class. Like constructors, it is invoked automatically.
C# destructor cannot have parameters. 
Moreover, modifiers can't be applied on destructors.
*/

using System;  
public class Employee  
{  
	public Employee()  
	{  
		Console.WriteLine("Constructor Invoked");  
	}  
	~Employee()  
	{  
		Console.WriteLine("Destructor Invoked");  
	}  
}  

class TestEmployee
{  
   public static void Main(string[] args)  
   {  
		Employee e1 = new Employee();  
		Employee e2 = new Employee();  
   }  
}
