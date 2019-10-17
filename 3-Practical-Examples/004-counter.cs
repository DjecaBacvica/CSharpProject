/* C# program to count number of 1's from entered Integer Array elements */

using System;
public class num_of_ones
{
    public static void Main(string[] args)
    {
        int m, count = 0;
        Console.WriteLine("Enter the Limit : ");
        m = int.Parse(Console.ReadLine());
		
        int[] a = new int[m];
        Console.WriteLine("Enter the Numbers :");
		
        for (int i = 0; i < m; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
		
        foreach (int o in a)
        {
            if (o == 1)
                count++;
        }
        Console.WriteLine("Number of 1's in the Entered Number : ");
        Console.WriteLine(count);
        Console.ReadLine();
    }
}