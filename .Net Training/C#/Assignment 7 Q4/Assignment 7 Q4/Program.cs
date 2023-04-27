using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment_7_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SMANJUAG\.NET\C#\Assignment 7 Q4\Assignment 7 Q4\TextFile.txt";
            Employee emp = new Employee(143, "Shruti", 80000);
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();


            bf.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine(" File created successfully -> " + path);


            FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            Employee objnew = (Employee)bf.Deserialize(stream1);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);
            Console.WriteLine(objnew.salary);

        }
    }
}
