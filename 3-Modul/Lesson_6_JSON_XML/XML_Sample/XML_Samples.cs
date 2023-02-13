using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace _3_Modul.Lesson_6_JSON_XML.XML_Sample
{
    internal class XML_Samples
    {
       static readonly string XMLFile1 = @"..\..\..\Lesson_6_JSON_XML\XML_Sample\XMLFile1.xml";
       static readonly string XMLFile2 = @"..\..\..\Lesson_6_JSON_XML\XML_Sample\XMLFile2.xml";
        public static void Run()
        {
            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLFile1);

            XmlElement? xRoot = xDoc.DocumentElement;
            //var nodeList = xRoot.SelectNodes("/people/student");
            //var node = xRoot.SelectSingleNode("/people/student[@name='Timur']");
            //nodeList = xRoot.ChildNodes;// ("/people/student");
            //XmlNode element = xRoot.RemoveChild(node);
            if (xRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xnode in xRoot)
                {
                    // получаем атрибут name
                    XmlNode? attr = xnode.Attributes.GetNamedItem("name");
                    Console.WriteLine(attr?.Value);

                    // обходим все дочерние узлы элемента user
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // если узел - company
                        if (childnode.Name == "company")
                        {
                            Console.WriteLine($"Company: {childnode.InnerText}");
                        }
                        // если узел age
                        if (childnode.Name == "age")
                        {
                            Console.WriteLine($"Age: {childnode.InnerText}");
                        }
                    }
                    Console.WriteLine();
                }
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
        }
        public static void XML_Serialize()
        {
            Person person = new("fasdghjk", 33,11);
            // передаем в конструктор тип класса Person
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));


            //// получаем поток, куда будем записывать сериализованный объект
            //using (StreamWriter fs = new StreamWriter(XMLFile2))//, FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs, person);
                
            //    Console.WriteLine("Object has been serialized");
            //}

            //Deserialize
            using (StreamReader fs = new FileInfo(XMLFile2).OpenText())//, FileMode.OpenOrCreate))
            {
                Person? person1 = xmlSerializer.Deserialize(fs) as Person;
                Console.WriteLine($"Name: {person1?.Name}  Age: {person1?.Age}");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public int Age { get; set; } = 1;
        public int Id { get; set; } = 1;
        

        public Person() { }
        public Person(string name, int age, int id )
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
