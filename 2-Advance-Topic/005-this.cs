/*
In c# programming, this is a keyword that refers to the current instance of the class. 
There can be 3 main usage of this keyword in C#.

1. It can be used to refer current class instance variable. 
It is used if field names (instance variables) and parameter names are same, 
that is why both can be distinguish easily.
2. It can be used to pass current object as a parameter to another method.
3. It can be used to declare indexers.
*/

using System;  
public class Employee  
{  
	public int id;   
	public String name;  
	public float salary;  
	public Employee(int id, String name,float salary)  
	{  
		this.id = id;  
		this.name = name;  
		this.salary = salary;  
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
		Employee e1 = new Employee(101, "Sonoo", 890000f);  
		Employee e2 = new Employee(102, "Mahesh", 490000f);  
		e1.display();  
		e2.display();  
   }  
}