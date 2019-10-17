/* 
C# program check Entered number is Armstrong or not  
Armstrong number is a number that is equal to the sum of cubes of its digits.
371 = (3*3*3)+(7*7*7)+(1*1*1)      
	= 27+343+1
	= 371
*/

using System;
public class armstrong_number
{
    public static void Main(string[] args)
    {
        int  n,r,sum=0,temp;      
        Console.Write("Enter the Number : ");      
        n= int.Parse(Console.ReadLine());  
		
        temp=n;      
        while(n>0)      
        {      
            r=n%10;      
            sum=sum+(r*r*r);      
            n=n/10;      
        }
		
        if(temp==sum)      
            Console.Write("Armstrong Number.");     
        else      
            Console.Write("Not Armstrong Number.");  
			
    	Console.readLine();
    }
}