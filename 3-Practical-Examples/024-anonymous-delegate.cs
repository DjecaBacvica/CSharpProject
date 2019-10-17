/* C# program perform Anonymous Delegate */

using System;
public delegate void Test();  
public class anonymous_delegate
{
    public static void Main(string[] args)
    {
        Test Display = delegate()  
        {  
            Console.WriteLine("Anonymous Delegate method"); 
        };  
        Display(); 
		
    	Console.readLine();
    }
}