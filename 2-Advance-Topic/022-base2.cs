/*
C# base keyword example: calling base class method
By the help of base keyword, we can call the base class method also. 
It is useful if base and derived classes defines same method. 
In other words, if method is overridden. 
If derived class doesn't define same method, there is no need to use base keyword. 
Base class method can be directly called by the derived class method.

Let's see the simple example of base keyword which calls the method of base class.
*/

using System;  
public class Animal
{  
	public virtual void eat(){  
		Console.WriteLine("eating...");  
	}  
}  
public class Dog: Animal  
{  
	public override void eat()  
	{  
		base.eat();  
		Console.WriteLine("eating bread...");  
	}  
	  
}  
public class TestBase  
{  
	public static void Main()  
	{  
		Dog d = new Dog();  
		d.eat();  
	}  
}