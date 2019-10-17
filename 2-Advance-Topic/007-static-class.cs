/*
The C# static class is like the normal class but it cannot be instantiated. 
It can have only static members. 
The advantage of static class is that it provides you guarantee
 that instance of static class cannot be created.

Points to remember for C# static class
C# static class contains only static members.
C# static class cannot be instantiated.
C# static class is sealed.
C# static class cannot contain instance constructors.
*/

using System;  
public static class MyMath  
{  
	public static float PI=3.14f;   
	public static int cube(int n){return n*n*n;}  
}  

class TestMyMath
{  
   public static void Main(string[] args)  
   {  
		Console.WriteLine("Value of PI is: " + MyMath.PI);  
		Console.WriteLine("Cube of 3 is: " + MyMath.cube(3));  
   }  
}

