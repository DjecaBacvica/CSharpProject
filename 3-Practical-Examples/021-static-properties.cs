/* C# program to execute Static Properties */

using System;
public class static_properties
{
    public class PropertyClass
    {
    	static string co_name;
        // Static Property
        public static string _co_name
        {
            get{
                return co_name;
            }

            set{
                co_name = value;
            }
        }
    } 
	
    public static void Main(string[] args)
    {
    	PropertyClass._co_name = "Hello Students";
        Console.WriteLine(PropertyClass._co_name);
        Console.ReadLine();
    }
}

