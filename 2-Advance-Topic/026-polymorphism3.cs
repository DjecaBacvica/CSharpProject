/*
Runtime Polymorphism with Data Members
Runtime Polymorphism can't be achieved by data members in C#. 
Let's see an example where we are accessing the field by reference variable 
which refers to the instance of derived class.
*/
using System;  
public class Animal
{  
	public string color = "white";  
}  
public class Dog: Animal  
{  
	public string color = "black";  
}  

public class TestSealed  
{  
	public static void Main()  
	{  
		Animal d = new Dog();  
		Console.WriteLine(d.color);  
	}  
}


