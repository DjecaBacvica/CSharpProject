/*
In C#, base keyword is used to access fields, 
constructors and methods of base class.

You can use base keyword within instance method, 
constructor or instance property accessor only. 
You can't use it inside the static method.

C# base keyword: accessing base class field
We can use the base keyword to access the fields of the base class within derived class. 
It is useful if base and derived classes have the same fields. 
If derived class doesn't define same field, there is no need to use base keyword. 
Base class field can be directly accessed by the derived class.

Let's see the simple example of base keyword in C# which accesses the field of base class.
*/
using System;  
public class Animal
{  
	public string color = "white";  
}  
public class Dog: Animal  
{  
	string color = "black";  
	public void showColor()  
	{  
		Console.WriteLine(base.color);  
		Console.WriteLine(color);  
	}  
}  
public class TestBase  
{  
	public static void Main()  
	{  
		Dog d = new Dog();  
		d.showColor();  
	}  
}