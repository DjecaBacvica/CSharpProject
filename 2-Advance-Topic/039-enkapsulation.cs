/*
Encapsulation is the concept of wrapping data into a single unit. 
It collects data members and member functions into a single unit called class. 
The purpose of encapsulation is to prevent alteration of data from outside. 
This data can only be accessed by getter functions of the class.

A fully encapsulated class has getter and setter functions that are used to read and write data. 
This class does not allow data access directly.

Here, we are creating an example in which we have a class that encapsulates properties 
and provides getter and setter functions.
*/

namespace AccessSpecifiers  
{  
	class Student  
	{  
		// Creating setter and getter for each property  
		public string ID { get; set; }  
		public string Name { get; set; }  
		public string Email { get; set; }  
	}  
}

using System;  
namespace AccessSpecifiers  
{  
	class Program  
	{  
		static void Main(string[] args)  
		{  
			Student student = new Student();  
			
			// Setting values to the properties  
			student.ID = "101";  
			student.Name = "Mohan Ram";  
			student.Email = "mohan@example.com";  
			
			// getting values  
			Console.WriteLine("ID = "+student.ID);  
			Console.WriteLine("Name = "+student.Name);  
			Console.WriteLine("Email = "+student.Email);  
		}  
	}  
}