/* C# program execute Single Cast Delegate And Event */

using System;
public class single_delegate_event
{
    public delegate void MyDelegate(int a);  
  
    public class XX  
    {  
        public event MyDelegate MyEvent;  

        public void RaiseEvent(){  
            MyEvent(20);  
            Console.WriteLine("Event Raised");  
        }  
		
        public void Display(int x)  {  
            Console.WriteLine("Display Method {0}", x); 
        }  
    }  
	
    public static void Main(string[] args)
    {
        XX obj = new XX();  
        obj.MyEvent += new MyDelegate(obj.Display);  
        obj.RaiseEvent();  
		
    	Console.readLine();
    }
}