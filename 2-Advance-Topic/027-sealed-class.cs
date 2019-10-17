/*
C# sealed keyword applies restrictions on the class and method. 
If you create a sealed class, it cannot be derived. 
If you create a sealed method, it cannot be overridden.

Structs are implicitly sealed therefore they can't be inherited
*/
using System;
sealed public class Animal
{  
	public void eat() {
	  Console.WriteLine("eating..."); 
	}  
}  
public class Dog: Animal  
{  
	public void bark() {
	  Console.WriteLine("barking...");
	}  
}  

public class TestSealed  
{  
	public static void Main()  
	{  
		Dog d = new Dog();  
		d.eat();  
		d.bark();  
	}
}