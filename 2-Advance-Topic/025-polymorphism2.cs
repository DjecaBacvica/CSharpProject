/*
The term "Polymorphism" is the combination of "poly" + "morphs" which means many forms. 
It is a greek word. In object-oriented programming, we use 3 main concepts: 
inheritance, encapsulation and polymorphism.

There are two types of polymorphism in C#: 
compile time polymorphism and runtime polymorphism. 
Compile time polymorphism is achieved by method overloading and operator overloading in C#. 
It is also known as static binding or early binding. 
Runtime polymorphism in achieved by method overriding 
which is also known as dynamic binding or late binding.
*/
using System;  
public class Shape
{  
	public virtual void draw(){  
		Console.WriteLine("drawing...");  
	}  
}  
public class Rectangle: Shape  
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

public class TestPolymorphism  
{  
	public static void Main()  
	{  
		Shape s;  
		s = new Shape();  
		s.draw();  
		s = new Rectangle();  
		s.draw();  
		s = new Circle();  
		s.draw();       
	}  
}