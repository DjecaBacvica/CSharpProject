/* C# program to get Fibonacci Series  */

using System;
public class fibonacci_series
{
    public static void Main(string[] args)
    {
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); //printing 0 and 1    
         for(i=2; i < number; ++i)   
         {    
             n3=n1+n2;    
             Console.Write(n3+" ");    
             n1=n2;    
             n2=n3;    
         } 
    	Console.readLine();
    }
}