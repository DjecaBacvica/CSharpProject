/* C# program for Sum Of Two Number */

using System;
public class sum_two_num
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine("Sum of "+num1+" and "+num2+" is : "+sum);  
        Console.ReadLine();
    }
}