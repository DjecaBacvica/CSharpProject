/* C# program execute Static Constructor */

using System;
class Sample
{
    public string param1, param2;
    static Sample()
    {
        Console.WriteLine("Static Constructor");
    }
    public Sample()
    {
        param1 = "Sample";
        param2 = "Instance Constructor";
    }
}

public class static_constructor
{
    public static void Main(string[] args)
    {
        // Here Both Static and instance constructors are invoked for first instance
        //staic constructor called when only first instant create
        Sample obj=new Sample();
        Console.WriteLine(obj.param1 + " " + obj.param2);
		
        // Here only instance constructor will be invoked
        Sample obj1 = new Sample();
        Console.WriteLine(obj1.param1 +" " + obj1.param2);
		
        Console.ReadLine();
    }
}

/*	
    Output:
	Static Constructor
	Sample Instance Constructor
	Sample Instance Constructor
*/