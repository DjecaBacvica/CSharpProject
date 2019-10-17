/*
In C#, inheritance is a process in which one object acquires all the properties and behaviors
 of its parent object automatically. 
In such way, you can reuse, 
extend or modify the attributes and behaviors which is defined in other class.

In C#, the class which inherits the members of another class is called derived class
 and the class whose members are inherited is called base class. 
 The derived class is the specialized class for the base class.

Advantage of C# Inheritance
Code reusability: Now you can reuse the members of your parent class. 
So, there is no need to define the member again. 
So less code is required in the class.
*/

using System;  
public class Employee  
{  
	public float salary = 40000;  
}  
public class Programmer: Employee  
{  
	public float bonus = 10000;  
}  

class TestInheritance
{  
	public static void Main(string[] args)  
	{  
		Programmer p1 = new Programmer();  
		Console.WriteLine("Salary: " + p1.salary);  
		Console.WriteLine("Bonus: " + p1.bonus);
	}  
}