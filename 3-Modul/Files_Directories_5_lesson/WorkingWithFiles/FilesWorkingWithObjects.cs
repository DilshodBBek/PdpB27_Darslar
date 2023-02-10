using System.Linq;

namespace _3_Modul.Files_Directories_5_lesson.WorkingWithFiles
{
    internal class FilesWorkingWithObjects
    {
        public static void Run()
        {
            string path = Directory.GetCurrentDirectory().ToString();
            DirectoryInfo? thisDir = new DirectoryInfo(path);

            thisDir = thisDir?.Parent?.Parent?.Parent;

            //thisDir?.CreateSubdirectory("Person\\Employee\\kjg");
            //thisDir?.CreateSubdirectory("Person\\Student");
            //Directory.Delete(thisDir.FullName + "\\Person\\Employee");
            //Directory.Delete(thisDir.FullName + "\\Person\\Student");
            string[] objName = new string[] { "PersonData1", "PersonData2", "PersonData3" };
            //C: \Users\User\Desktop\VS\PdpB27_Darslar\3 - Modul\Person

            thisDir = thisDir?.CreateSubdirectory("Person");// new DirectoryInfo(thisDir?.FullName + "\\Person");

            foreach (string item in objName)
            {
                if (!File.Exists(thisDir.FullName + $"\\{item}.txt"))
                {
                    File.Create(thisDir.FullName + $"\\{item}.txt").Dispose();
                }
            }

            List<Person> people = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person() { Id = Guid.NewGuid(), Name = "Eshmat" + i });
                Console.WriteLine(people[i]);
            }
            //var sds = new EnumerationOptions();
            //sds.
            FileInfo[]? personDatas = thisDir?.GetFiles("*Data*.*", SearchOption.AllDirectories);

            using (StreamWriter writer = personDatas[1].AppendText())
            {
                people.ForEach(person =>
                {
                   if(!File.ReadAllText(personDatas[0].FullName).Contains(person.ToString()))
                       writer?.WriteLine(person);
                });
            }




        }

        public static List<Person> GetAllData()
        {
            List<Person> people = new();
            DirectoryInfo? PersonDir = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.Parent?.Parent;
            PersonDir = new DirectoryInfo(PersonDir?.FullName + "\\Person");

            FileInfo PersonData1 = PersonDir.GetFiles("*.txt")[0];

            using (StreamReader reader = PersonData1.OpenText())
            {
                //string[] AllLines = File.ReadAllLines(PersonData1.FullName);
                string? person = reader.ReadLine();

                while (!string.IsNullOrEmpty(person))
                {
                    people.Add(new Person()
                    {
                        Id = Guid.Parse(person.Substring("Id:".Length, "8ceab0e1-7bf4-4f27-9b5f-aa6edc5aac69".Length)),
                        Name = person.Substring(person.IndexOf("Name:") + "Name:".Length)
                    });
                    person= reader.ReadLine();
                } 
            }

            people.ForEach(x => Console.WriteLine(x));

            //FileStream fs=PersonData1.OpenRead();
            //byte[] bytes = File.ReadAllBytes(PersonDir.FullName + "\\PersonData1.txt");
            //foreach (byte item in bytes)
            //{
            //    Console.WriteLine(item);
            //}

            return people;

        }

    }
    class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Id:{Id},Name:{Name}";
        }
    }
}
