/* C# program to count number of Alphabets, Digits and Special charactor from Entered String  */

using System;
public class alpha_digit_spchar
{
    public static void Main(string[] args)
    {
        string str;
        int alp, digit, splch, i,l;
        alp = digit = splch = i = 0;
 	
      	Console.Write("Input the string : ");
      	str = Console.ReadLine();	
      	l=str.Length; 

        while(i< l)
        {
            if((str[i] >= 'a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
            {
                alp++;
            }
            else if(str[i]>='0' && str[i]<='9')
            {
                digit++;
            }
            else
            {
                splch++;
            }
            i++;
        }

        Console.Write("Number of Alphabets in the string is : {0}\n", alp);
        Console.Write("Number of Digits in the string is : {0}\n", digit);
        Console.Write("Number of Special characters in the string is : {0}\n\n", splch);
        Console.readLine();
    }
}
