/* C# program execute Single Cast Delegate */

using System;
public class single_cast_delegate
{
    public delegate void delmethod();    
  
    public class P    
    {  
        public static void display(){    
            Console.WriteLine("Hello!");    
        }    

        public static void show(){    
            Console.WriteLine("Hi!");    
        }    

        public void print(){
            Console.WriteLine("Print");
        }
    }
	
    public static void Main(string[] args)
    {
        delmethod del1 = P.show;
  
        // here we have assigned static method display() of class P 
        // to delegate delmethod() using new operator
		
        // you can use both ways to assign the delagate
        delmethod del2 = new delmethod(P.display);
		
        P obj = new P();
        // here first we have create instance of class P and assigned 
        // the method print() to the delegate i.e. delegate with class    
        delmethod del3 = obj.print;

        del1();
        del2();
        del3();
    	Console.readLine();
    }
}

