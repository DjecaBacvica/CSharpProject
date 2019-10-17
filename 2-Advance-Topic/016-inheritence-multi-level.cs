/*
C# Multi Level Inheritance Example
When one class inherits another class which is further inherited by another class, 
it is known as multi level inheritance in C#. 
Inheritance is transitive so the last derived class acquires
 all the members of all its base classes.
*/
using System;  
public class Animal  
{  
	public void eat() { Console.WriteLine("Eating..."); }  
}  
public class Dog: Animal  
{  
	public void bark() { Console.WriteLine("Barking..."); }  
}  
public class BabyDog : Dog  
{  
	public void weep() { Console.WriteLine("Weeping..."); }  
}  

class TestInheritance2
{  
	public static void Main(string[] args)  
	{  
		BabyDog d1 = new BabyDog();  
		d1.eat();  
		d1.bark();  
		d1.weep();  
	}  
}
