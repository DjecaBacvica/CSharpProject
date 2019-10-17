/*
If derived class defines same method as defined in its base class, 
it is known as method overriding in C#. 
It is used to achieve runtime polymorphism. 
It enables you to provide specific implementation of the method 
which is already provided by its base class.

To perform method overriding in C#, 
you need to use virtual keyword with base class method 
and override keyword with derived class method.
*/
using System;  
public class Animal
{  
	public virtual void eat()
	{  
		Console.WriteLine("Eating...");  
	}  
}  

public class Dog: Animal  
{  
	public override void eat()  
	{  
		Console.WriteLine("Eating bread...");  
	}  
}  

public class TestOverriding  
{  
	public static void Main()  
	{  
		Dog d = new Dog();  
		d.eat();  
	}  
}