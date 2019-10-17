/* C# program execute Simple Struct */

using System;
struct MyStruct
{
    public int x;
    public int y;
}

class simple_struc
{
    public static void Main()
    {
        MyStruct w3st = new MyStruct();
        w3st.x = 15;
        w3st.y = 25;
        int sum = w3st.x + w3st.y;
        Console.WriteLine("The sum of x and y is {0}\n",sum);
    }
}

