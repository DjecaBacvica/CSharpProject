/*
In C#, constructor is a special method which
 is invoked automatically at the time of object creation. 
It is used to initialize the data members of new object generally. 
The constructor in C# has the same name as class or struct.

There can be two types of constructors in C#.

1. Default constructor
2. Parameterized constructor
*/

using System;  
public class Employee  
{  
	public Employee()  
	{  
		Console.WriteLine("Default Constructor Invoked");  
	}  
	
	public static void Main(string[] args)  
	{  
		Employee e1 = new Employee();  
		Employee e2 = new Employee();  
	}  
}