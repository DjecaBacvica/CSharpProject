/*
C# program to find Factorial Number of enterd number
Meaning of Factorial Number
4! = 4*3*2*1 = 24    
6! = 6*5*4*3*2*1 = 720      
*/

using System;
public class factorial
{
    public static void Main(string[] args)
    {
		 int i,fact=1,number;      
         Console.Write("Enter any Number: ");      
         number= int.Parse(Console.ReadLine());
		
         for(i=1;i<=number;i++){      
        	 fact=fact*i;      
         }      
       	Console.Write("Factorial of " +number+" is: "+fact);  
		
    	Console.readLine();
    }
}