/* C# program to find first position of perticular Substring from whole string */

using System;
public class position_substring
{
    public static void Main(string[] args)
    {
        string str1;
        string findstr; 
		
        Console.Write("Input a String: ");
        str1 = Console.ReadLine();
 
        Console.Write("Input a substring to be found in the string: ");
        findstr = Console.ReadLine();   
		
        int index = str1.IndexOf(findstr);
        if(index<0)
            Console.WriteLine("The substring no found  in the given string \n");
        else
            Console.WriteLine("Index Of "+findstr+" is : "+index);
		
    	Console.readLine();
    }
}