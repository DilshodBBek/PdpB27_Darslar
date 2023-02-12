using _3_Modul.Lesson_6_JSON_XML.XML_Sample;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _3_Modul.Lesson_6_JSON_XML.BinaryFormatterExample
{
    internal class BinaryForamatterSample
    {
        static readonly string BinaryFile = @"..\..\..\Lesson_6_JSON_XML\BinaryFormatterExample\Person.bin";

        public static void Run()
        {
            //MyObject obj = new MyObject();
            //obj.n1 = 1;
            //obj.n2 = 24;
            //obj.str = "Some String";
            //BinaryFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, obj);
            //stream.Close();

            //Person p = new() { Name = "Alice", Age = 30 };
            //BinaryFormatter formatter = new();
            //using (FileStream stream = File.Create(BinaryFile))
            //{
            //    formatter.Serialize(stream, p);
            //}

            //// Deserialize the binary file back into a Person object
            //using (FileStream stream = File.OpenRead(BinaryFile))
            //{
            //    Person p2 = (Person)formatter.Deserialize(stream);
            //    Console.WriteLine($"Name: {p2.Name}, Age: {p2.Age}");
            //}
        }
    }
    [Serializable]
    public class MyObject
    {
        public int n1 = 0;
        public int n2 = 0;
        public String str = null;
    }
}
