/* C# program to find Total number of Vowel and Consonant from entered string */

using System;
public class vowel_consonant
{
    public static void Main(string[] args)
    {
        string str;
    	int i, len, vowel, cons;
	
        Console.Write("Input the string : ");
        str = Console.ReadLine();		

        vowel = 0;
        cons = 0;
        len = str.Length;

        for(i=0; i < len; i++)
        {

            if(str[i] =='a' || str[i]=='e' || str[i]=='i' 
                || str[i]=='o' || str[i]=='u' || str[i]=='A'
                || str[i]=='E' || str[i]=='I' || str[i]=='O'
                || str[i]=='U')
            {
                vowel++;
            }
            else if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
            {
                cons++;
            }
        }
		
        Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
        Console.Write("The total number of consonant in the string is : {0}\n\n", cons);
		
    	Console.readLine();
    }
}