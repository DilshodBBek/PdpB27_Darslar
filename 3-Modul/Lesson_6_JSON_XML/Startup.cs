using _3_Modul.Lesson_6_JSON_XML.JSON_Example;
using _3_Modul.Lesson_6_JSON_XML.JSON_Example.Json_CRUD_Sercvice;

namespace _3_Modul.Lesson_6_JSON_XML
{
    internal class Startup
    {
        public static void Start()
        {
            JsonCrud jsonCrud = new();

            List<Account> accounts = new List<Account>()
            {
                new Account() {Active= true, CreatedDate=DateTime.Now, Id=5, Email="1@mail"},
                new Account() {Active= false, CreatedDate=DateTime.Now, Id=2, Email="2@mail"},
                new Account() {Active= true, CreatedDate=DateTime.Now, Id=3, Email="3@mail"},
                new Account() {Active= false, CreatedDate=DateTime.Now, Id=4, Email="4@mail"},
            };

            jsonCrud.Add(accounts);

            //Json_Sample.Run();
            List<Account> accounts = InitData();
            CrudJson_Service crudJson_service = new();
            crudJson_service.Update(7, new Account() { Email="@mail.com"});

        }

        private static List<Account> InitData()
        {
            return new List<Account>()
            {
                new Account() {
                    Id=4,
                   // CreatedDate=DateTime.Now,
                    Email="1@mail.uz",
                   // Roles=new List<string>{"1Admin", "1User"}
                },
                new Account() {
                    Id=7,
                    //CreatedDate=DateTime.Now,
                    Email="2@mail.uz",
                    //Roles=new List<string>{"2Admin", "2User"}
                },
                new Account() {
                    Id=6,
                    //CreatedDate=DateTime.Now,
                    Email="3@mail.uz",
                    //Roles=new List<string>{"3Admin", "2User"}
                },
            };
        }

        public static void RunXMLExamples()
        {
            //XML_Samples.Run();
            //XML_Samples.XML_Serialize();
            //List<User> users = new()
            //{
            //    new User() {Name ="Alex", Id= 1},
            //    new User() {Name ="Aleksey", Id= 2}
            //};
            //int number=XML_CRUD_Users_Service.AddUsers(users);
            //Console.WriteLine("Added elements count:" + number);
            //users = XML_CRUD_Users_Service.GetUsers();
            //  XML_CRUD_Users_Service.Delete(new User() { Name = "sada", Id = 23 });
            //XML_CRUD_Users_Service.Update(3, new User() { Name = "Salom", Id = 11 });

        }
    }
}
