/* C# program two dates 

Current Date : 23/7/2015
By Adding 5 in Date : 28/7/2015

*/

using System;
public class add_two_dates
{
    public static void Main(string[] args)
    {
        DateTime SDate = new DateTime(2010, 10, 7);

        Console.WriteLine("Starting Date : "+ SDate);

        DateTime EDate = startDate.AddDays(10);

        Console.WriteLine("Ending Date : "+ EDate);
    	
        Console.readLine();
    }
}