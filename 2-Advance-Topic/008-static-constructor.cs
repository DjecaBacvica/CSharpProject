/*
C# static constructor is used to initialize static fields. 
It can also be used to perform any action that is to be performed only once. 
It is invoked automatically before first instance is created or any static member is referenced.

Points to remember for C# static Constructor
1. C# static constructor cannot have any modifier or parameter.
2. C# static constructor is invoked implicitly. It can't be called explicitly.
*/

using System;  
public class Account  
{  
	public int id;   
	public String name;  
	public static float rateOfInterest;  
	public Account(int id, String name)  
	{  
		this.id = id;  
		this.name = name;  
	}  
	static Account()  
	{  
		rateOfInterest = 9.5f;  
	}  
	public void display()  
	{  
		Console.WriteLine(id + " " + name+" "+rateOfInterest);  
	}  
}  

class TestEmployee
{  
   public static void Main(string[] args)  
   {  
		Account a1 = new Account(101, "Sonoo");  
		Account a2 = new Account(102, "Mahesh");  
		a1.display();  
		a2.display();  
   }  
}