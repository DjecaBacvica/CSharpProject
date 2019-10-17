/* C# program to count of words from input string  */

using System;
public class num_of_words
{
    public static void Main(string[] args)
    {
        string str;
    	int i, wrd,l;
	
        Console.Write("Input the string : ");
        str = Console.ReadLine();
	
        l = 0;
        wrd = 1;

        /* loop till end of string */
        while (l <= str.Length - 1)
        {
            /* check whether the current character is white space or new line or tab character*/
            if(str[l]==' ' || str[l]=='\n' || str[l]=='\t')
            {
                wrd++;
            }
            l++;
        }

        Console.Write("Total number of words in the string is : {0}\n", wrd);
        Console.readLine();
    }
}