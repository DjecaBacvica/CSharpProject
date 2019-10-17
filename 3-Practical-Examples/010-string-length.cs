/* C# program To find length of String Without using function  */

using System;
public class String_Length
{
    public static void Main(string[] args)
    {
    	string str;
    	int l= 0;

        Console.Write("Input the string : ");
        str = Console.ReadLine();

        foreach(char chr in str)
        {
            l += 1;
        }
        Console.Write("Length of the string is : ", l);
        Console.readLine();
    }
}