/* C# program to Declare and Initialize Struct Without new Keyword */

using System;
public struct newStruct
{
    public int m, n;
    public newStruct(int pt1, int pt2)
    {
        m = pt1;
        n = pt2;
    }
}

// Declare and initialize struct objects.
class struc_without_new
{
    public static void Main()
    {
        newStruct myPoint;

        myPoint.m = 30;
        myPoint.n = 40;

        Console.Write("\nnewStruct : ");
        Console.WriteLine("m = "+myPoint.m+" n = " myPoint.n);

        Console.ReadKey();
    }
}