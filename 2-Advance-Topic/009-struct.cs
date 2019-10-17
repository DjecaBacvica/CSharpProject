/*
In C#, classes and structs are blueprints that are used to create instance of a class. 
Structs are used for lightweight objects such as Color, Rectangle, Point etc.
Unlike class, structs in C# are value type than reference type. 
It is useful if you have data that is not intended to be modified after creation of struct.
*/

using System;  

public struct Rectangle  
{  
	public int width, height;  
}  
 
public class TestStructs  
{  
	public static void Main()  
	{  
		Rectangle r = new Rectangle();  
		r.width = 4;  
		r.height = 5;  
		Console.WriteLine("Area of Rectangle is: " +(r.width * r.height));  
	}  
}
