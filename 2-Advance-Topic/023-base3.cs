/*
C# inheritance: calling base class constructor internally
Whenever you inherit the base class, base class constructor is internally invoked. 
Let's see the example of calling base constructor.
*/
using System;  
public class Animal
{  
	public Animal()
	{  
		Console.WriteLine("animal...");  
	}  
}  
public class Dog:Animal  
{  
	public Dog()  
	{  
		Console.WriteLine("dog...");  
	}       
}  
public class TestOverriding  
{  
	public static void Main()  
	{  
		Dog d = new Dog();     
	}  
}