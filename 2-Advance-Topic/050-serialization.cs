/*
In C#, serialization is the process of converting object into byte 
stream so that it can be saved to memory, file or database. 
The reverse process of serialization is called deserialization.

Serialization is internally used in remote applications.

C# SerializableAttribute
To serialize the object, you need to apply SerializableAttribute attribute to the type. 
If you don't apply SerializableAttribute attribute to the type, 
SerializationException exception is thrown at runtime.


C# Serialization example
Let's see the simple example of serialization in C#
 where we are serializing the object of Student class. 
 Here, we are going to use BinaryFormatter.
 Serialize(stream, reference) method to serialize the object.
*/
using System;  
using System.IO;  
using System.Runtime.Serialization.Formatters.Binary;  
[Serializable]  
class Student  
{  
	int rollno;  
	string name;  
	public Student(int rollno, string name)  
	{  
		this.rollno = rollno;  
		this.name = name;  
	}  
} 

public class SerializeExample  
{  
	public static void Main(string[] args)  
	{  
		FileStream stream = new FileStream("d:\\sss.txt", FileMode.OpenOrCreate);  
		BinaryFormatter formatter=new BinaryFormatter();  
		  
		Student s = new Student(101, "sonoo");  
		formatter.Serialize(stream, s);  
  
		stream.Close();  
	}  
}