/*
C# StreamReader class is used to read string from the stream. 
It inherits TextReader class. 
It provides Read() and ReadLine() methods to read data from the stream.
*/
using System;  
using System.IO;  
public class StreamReaderExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream f = new FileStream("d:\\somefile.txt", FileMode.OpenOrCreate);  
		StreamReader s = new StreamReader(f);  
  
		string line = "";  
		while ((line = s.ReadLine()) != null)  
		{  
			Console.WriteLine(line);  
		}  
		s.Close();  
		f.Close();  
	}  
}

