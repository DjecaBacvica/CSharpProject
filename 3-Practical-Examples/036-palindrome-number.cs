/* 
C# program to find enterd number is palindrome or not  
If given number and its reverse number contain same value then. 
This number is known as palindrome number
Exa : 252, 18981, 6336
*/

using System;
public class palindrome_number
{
    public static void Main(string[] args)
    {
        int n,r,sum=0,temp;    
        Console.Write("Enter the Number: ");   
        n = int.Parse(Console.ReadLine());  
        temp=n; 
		
        while(n>0)      
        {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
        }
		
        if(temp==sum)      
           Console.Write("Number is Palindrome.");      
        else      
           Console.Write("Number is not Palindrome");
		   
        Console.readLine();
    }
}