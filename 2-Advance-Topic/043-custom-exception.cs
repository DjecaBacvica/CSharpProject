/*
C# allows us to create user-defined or custom exception. 
It is used to make the meaningful exception. 
To do this, we need to inherit Exception class.
*/

using System;  
public class InvalidAgeException : Exception  
{  
	public InvalidAgeException(String message)  
	: base(message)  
	{  
  
	}  
}

public class TestUserDefinedException  
{  
	static void validate(int age)  
	{  
		if (age < 18)  
		{  
			throw new InvalidAgeException("Sorry, Age must be greater than 18");  
		}  
	}  
	public static void Main(string[] args)  
	{  
		try  
		{  
			validate(12);  
		}  
		catch (InvalidAgeException e) 
		{ 
			Console.WriteLine(e); 
		}  
		Console.WriteLine("Rest of the code");  
	}  
}