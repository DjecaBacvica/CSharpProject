/* C# program to get power of number using Recursion */

using System;
public class power_of_num_recursion 
{
    public static void Main(string[] args)
    {
        int n = 5;
        int p = 2;
        long res;
        res = power(n, p);
        Console.WriteLine(res);
    	Console.readLine();
    }
	
    static long power (int n, int p)
    {
        if (p!=0) {
            return (n * power(n, p - 1));
        }
        return 1;
   }
}


