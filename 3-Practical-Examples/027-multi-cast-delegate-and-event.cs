* C# program Of Multi cast delegate and event */

using System;
public class multi_delegate_event
{
    public delegate void MyDelegate(int a, int b);  
  
    public class XX  
    {  
        public event MyDelegate MyEvent;  

        public void RaiseEvent(int a, int b){  
            MyEvent(a, b);  
            Console.WriteLine("Event Raised");  
        }  

        public void Add(int x, int y){  
            Console.WriteLine("Add Method {0}", x + y); 
        }  

        public void Subtract(int x, int y){  
            Console.WriteLine("Subtract Method {0}", x - y);  
        }  
    }  
	
    public static void Main(string[] args)
    {
        XX obj = new XX();  
		
        obj.MyEvent += new MyDelegate(obj.Add);  
        obj.MyEvent += new MyDelegate(obj.Subtract);  
        obj.RaiseEvent(20, 10);  
		
    	Console.readLine();
    }
}