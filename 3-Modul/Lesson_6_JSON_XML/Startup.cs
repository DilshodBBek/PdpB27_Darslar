using _3_Modul.Lesson_6_JSON_XML.XML_Sample.Crud_USER_Service;

namespace _3_Modul.Lesson_6_JSON_XML
{
    internal class Startup
    {
        public static void Start()
        {
            //  Json_Sample.Run();
            //XML_Samples.Run();
            //XML_Samples.XML_Serialize();
            List<User> users = new()
            {
                new User() {Name ="Alex", Id= 1},
                new User() {Name ="Aleksey", Id= 2}
            };
            int number=XML_CRUD_Users_Service.AddUsers(users);
            //Console.WriteLine("Added elements count:" + number);
            //users = XML_CRUD_Users_Service.GetUsers();
           //  XML_CRUD_Users_Service.Delete(new User() { Name = "sada", Id = 23 });
             //XML_CRUD_Users_Service.Update(3, new User() { Name = "Salom", Id = 11 });
            
        }
    }
}
