/* C# program to Add 1 to N number */

using System;
public class sum_one_to_n_num
{
    public static void Main(string[] args)
    {
        int i, sum = 0,n;

        Console.Write("Enter the Nth Number : ");
        n = int.Parse(Console.ReadLine());

        for (i = 1; i <= n; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("\nSum of N Numbers : " + sum);
		
    	Console.readLine();
    }
}