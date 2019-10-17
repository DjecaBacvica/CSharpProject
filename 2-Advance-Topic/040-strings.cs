/*
In C#, string is an object of System.String class that represent sequence of characters. 
We can perform many operations on strings such as concatenation, 
comparision, getting substring, search, trim, replacement etc.

string vs String
In C#, string is keyword which is an alias for System.String class. 
That is why string and String are equivalent. 
We are free to use any naming convention.
	
    string s1 = "hello";//creating string using string keyword  
    String s2 = "welcome";//creating string using String class
*/

using System;  
public class StringExample  
{  
	public static void Main(string[] args)  
	{  
		string s1 = "hello";  
  
		char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };  
		string s2 = new string(ch);  
		 
		Console.WriteLine(s1);  
		Console.WriteLine(s2);  
	}  
}