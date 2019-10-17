/*
In C#, constructor is a special method which
 is invoked automatically at the time of object creation. 
It is used to initialize the data members of new object generally. 
The constructor in C# has the same name as class or struct.

There can be two types of constructors in C#.

1. Default constructor
2. Parameterized constructor
*/

using System;  
public class Employee  
{  
	public int id;   
	public String name;  
	public float salary;  
	public Employee(int i, String n,float s)  
	{  
		id = i;  
		name = n;  
		salary = s;  
	}  
	public void display()  
	{  
		Console.WriteLine(id + " " + name+" "+salary);  
	}  
}  

class TestEmployee
{  
   public static void Main(string[] args)  
   {  
		Employee e1 = new Employee(201, "Nobita", 890000f);  
		Employee e2 = new Employee(202, "Jerry", 490000f);  
		e1.display();  
		e2.display();  

   }  
}