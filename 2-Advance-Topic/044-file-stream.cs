/*
C# FileStream class provides a stream for file operation. 
It can be used to perform synchronous and asynchronous read and write operations. 
By the help of FileStream class, we can easily read and write data into file.

C# FileStream example: writing single byte into file
Let's see the simple example of FileStream class to write single byte of data into file. 
Here, we are using OpenOrCreate file mode which can be used for read and write operations.
*/

using System;  
using System.IO;  
public class FileStreamExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream f = new FileStream("d:\\somefile.txt", FileMode.OpenOrCreate);
		f.WriteByte(65);//writing byte into stream  
		f.Close();//closing stream  
	}  
}
---
using System;  
using System.IO;  
public class FileStreamExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream f = new FileStream("d:\\somefile.txt", FileMode.OpenOrCreate);  
		for (int i = 65; i <= 90; i++)  
		{  
			f.WriteByte((byte)i);  
		}  
		f.Close();  
	}  
}
---
using System;  
using System.IO;  
public class FileStreamExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream f = new FileStream("d:\\somefile.txt", FileMode.OpenOrCreate);  
		int i = 0;  
		while ((i = f.ReadByte()) != -1)  
		{  
			Console.Write((char)i);  
		}  
		f.Close();  
	}  
}