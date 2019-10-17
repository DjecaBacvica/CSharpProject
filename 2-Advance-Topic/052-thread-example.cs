/*
static method
We can call static and non-static methods on the execution of the thread. 
To call the static and non-static methods, 
you need to pass method name in the constructor of ThreadStart class. 
For static method, we don't need to create the instance of the class. 
You can refer it by the name of class.
*/

using System;  
using System.Threading;  
public class MyThread  
{  
	public static void Th1()  
	{  
		for (int i = 0; i < 5; i++)  
		{  
			Console.WriteLine(i);  
		}  
	}  
}  
public class ThreadExample  
{  
	public static void Main()  
	{  
		Thread t1 = new Thread(new ThreadStart(MyThread.Th1));  
		Thread t2 = new Thread(new ThreadStart(MyThread.Th1));  
		t1.Start();  
		t2.Start();  
	}  
}

/*
non static method
*/
using System;  
using System.Threading;  
public class MyThread  
{  
	public void Thread1()  
	{  
		for (int i = 0; i < 10; i++)  
		{  
			Console.WriteLine(i);  
		}  
	}  
}  
public class ThreadExample  
{  
	public static void Main()  
	{  
		MyThread mt = new MyThread();  
		Thread t1 = new Thread(new ThreadStart(mt.Thread1));  
		Thread t2 = new Thread(new ThreadStart(mt.Thread1));  
		t1.Start();  
		t2.Start();  
	}  
}