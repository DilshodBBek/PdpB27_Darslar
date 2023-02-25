using System.Diagnostics;

namespace _3_Modul.Lesson8_LINQ.Linq2Obj
{
    internal class Examples
    {
        public static void Run()
        {
            //StudentMethod();
            Range1();
        }
        static  void Range1()
        {
            IEnumerable<int> numberSequence = Enumerable.Range(12, 40).TakeWhile(x=>x%2==0);
            foreach (int i in numberSequence)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static void Main1()
        {
            var random = new Random();
            int[] values = Enumerable.Range(1, 99999999)
                .Select(x => random.Next(1, 1000)).ToArray();
            //Min, Max and Average LINQ extension methods
            Console.WriteLine("Min, Max and Average with LINQ");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // var linqStart = DateTime.Now; 
            var linqMin = values.Min();
            var linqMax = values.Max();
            var linqAverage = values.Average();
            stopwatch.Stop();
            var linqTimeMS = stopwatch.ElapsedMilliseconds;
            DisplayResults(linqMin, linqMax, linqAverage, linqTimeMS);
            //Min, Max and Average PLINQ extension methods
            Console.WriteLine("\nMin, Max and Average with PLINQ");
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            var plinqMin = values.AsParallel().Min();
            var plinqMax = values.AsParallel().Max();
            var plinqAverage = values.AsParallel().Average();
            stopwatch1.Stop();
            var plinqTimeMS = stopwatch1.ElapsedMilliseconds;
            DisplayResults(plinqMin, plinqMax, plinqAverage, plinqTimeMS);

            Console.ReadKey();
        }
        static void DisplayResults(int min, int max, double average, double time)
        {
            Console.WriteLine($"Min: {min}\nMax: {max}\n" + $"Average: {average:F}\nTotal time in milliseconds: {time}");
        }
        static void More()
        {
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            //Method Syntax
            var MS = dataSource1.Union(dataSource2).ToList();
            //Query Syntax
            var QS = (from num in dataSource1
                      select num)
                      .Union(dataSource2).ToList();
            foreach (var item in MS)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static void StudentMethod()
        {
            List<string> nameList = new List<string>() { "Pranaya", "Kumar" };
            //Using Method Syntax
            List<char> MethodSyntax = nameList.SelectMany(std => std).ToList();
            List<string> MethodSyntax1 = Student.GetStudents().SelectMany(student=>student.Programming).ToList();
            List<string> MethodSyntax2 = Student.GetStudents().SelectMany(student => student.Programming).Select(ch => ch).ToList();

            List<char> chars = (from std in Student.GetStudents()
                                from programming in std.Programming
                                from str in programming
                                select str).ToList();
            //Using Query Syntax
            IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
                                              from program in std.Programming
                                              select program;
            //Printing the values
            foreach (char program in chars)
            {
                Console.Write(program);
            }
            Console.ReadKey();
        }
        public static void EmployeeMethod()
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //Step2: Query
            //LINQ Query using Query Syntax to fetch all numbers which are > 5
            var QuerySyntax = (from obj in integerList //Data Source
                               where obj > 5 //Condition
                               select obj).Sum(); //Selection

            var res = integerList.Where(x => x > 5).Sum();

            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> EvenNumbers = Enumerable.Where(intList, n => n % 2 == 0);
            //{
            //    return n % 2 == 0;
            //};
            List<int> EvenNumbers1 = intList.Where(n => n % 2 == 0).ToList();

            //Step3: Execution  
            //foreach (int item in res)
            //{
            //    Console.Write(item + " ");
            //}

            //Query Syntax
            var query = (from emp in Employee.GetEmployees().Select((value, index) => new { index, value })
                         select new
                         {
                             //Index is 0-Based, and always increases by 1
                             IndexPosition = emp.index,
                             FullName = emp.value.FirstName + " " + emp.value.LastName,
                             emp.value.Salary
                         }).ToList();
            foreach (var emp in query)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }
            //Method Syntax
            //Projects each element of a sequence into a new form by incorporating the element's index.
            var selectMethod = Employee.GetEmployees().
                                          Select((emp, index) => new
                                          {
                                              //Index is 0-Based, and always increases by 1
                                              IndexPosition = index,
                                              FullName = emp.FirstName + " " + emp.LastName,
                                              emp.Salary
                                          });
            foreach (var emp in selectMethod)
            {
                Console.WriteLine($" Position {emp.IndexPosition} Name : {emp.FullName} Salary : {emp.Salary} ");
            }
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Programming { get; set; }
        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Email = "James@j.com", Programming = new List<string>() { "C#", "Java", "C++"} },
                new Student(){ID = 2, Name = "Sam", Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                new Student(){ID = 3, Name = "Patrik", Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Java", "LINQ"} },
                new Student(){ID = 4, Name = "Sara", Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
            };
        }
    }
}
