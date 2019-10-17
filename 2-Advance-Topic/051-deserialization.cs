/*
In C# programming, deserialization is the reverse process of serialization. 
It means you can read the object from byte stream. 
Here, we are going to use BinaryFormatter.
Deserialize(stream) method to deserialize the stream.
*/
using System;  
using System.IO;  
using System.Runtime.Serialization.Formatters.Binary;  
[Serializable]  
class Student  
{  
	public int rollno;  
	public string name;  
	public Student(int rollno, string name)  
	{  
		this.rollno = rollno;  
		this.name = name;  
	}  
}  
public class DeserializeExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream stream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate);  
		BinaryFormatter formatter=new BinaryFormatter();  
  
		Student s=(Student)formatter.Deserialize(stream);  
		Console.WriteLine("Rollno: " + s.rollno);  
		Console.WriteLine("Name: " + s.name); 
		stream.Close();  
	}  
}