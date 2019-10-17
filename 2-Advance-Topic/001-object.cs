/*
In C#, Object is a real world entity, for example, chair, car, pen, mobile, laptop etc.
In other words, object is an entity that has state and behavior. 
Here, state means data and behavior means functionality.
Object is a runtime entity, it is created at runtime.
Object is an instance of a class. 
All the members of the class can be accessed through object.
Let's see an example to create object using new keyword.
*/

using System;  
public class Student  
{  
	int id;//data member (also instance variable)    
	String name;//data member(also instance variable)    
	 
	public static void Main(string[] args)  
	{  
		Student s1 = new Student();//creating an object of Student    
		s1.id = 101;  
		s1.name = "Ketan shrivastav";  
		Console.WriteLine(s1.id);  
		Console.WriteLine(s1.name);  
	}  
}