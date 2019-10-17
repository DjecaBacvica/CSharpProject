/*
Abstract classes are the way to achieve abstraction in C#. 
Abstraction in C# is the process to hide the internal details and showing functionality only. 
Abstraction can be achieved by two ways:

Abstract class
Interface
Abstract class and interface both can have abstract methods which are necessary for abstraction.

Abstract Method
A method which is declared abstract and has no body is called abstract method. 
It can be declared inside the abstract class only. 
Its implementation must be provided by derived classes. For example:
public abstract void draw();  

An abstract method in C# is internally a virtual method 
so it can be overridden by the derived class.
	
You can't use static and virtual modifiers in abstract method declaration.

C# Abstract class
In C#, abstract class is a class which is declared abstract. 
It can have abstract and non-abstract methods. 
It cannot be instantiated. Its implementation must be provided by derived classes. 
Here, derived class is forced to provide the implementation of all the abstract methods.

Let's see an example of abstract class in C# which has one abstract method draw(). 
Its implementation is provided by derived classes: Rectangle and Circle. 
Both classes have different implementation.
*/
using System;  
public abstract class Shape  
{  
	public abstract void draw();  
}  
public class Rectangle : Shape  
{  
	public override void draw()  
	{  
		Console.WriteLine("drawing rectangle...");  
	}  
}  
public class Circle : Shape  
{  
	public override void draw()  
	{  
		Console.WriteLine("drawing circle...");  
	}  
}  
public class TestAbstract  
{  
	public static void Main()  
	{  
		Shape s;  
		s = new Rectangle();  
		s.draw();  
		s = new Circle();  
		s.draw();  
	}  
}