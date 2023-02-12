using Newtonsoft.Json;
using System.Text.Json;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example
{
    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
    internal class Json_Sample
    {
        internal static void Run()
        {
            Account account = new()
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string> { "User, Admin" }
            };
            #region SerializeObject
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            // {
            //   "Email": "james@example.com",
            //   "Active": true,
            //   "CreatedDate": "2013-01-20T00:00:00Z",
            //   "Roles": [
            //     "User",
            //     "Admin"
            //   ]
            // }
            Console.WriteLine(json);
            #endregion

            #region DeserializeObject
            //account = JsonConvert.DeserializeObject<Account>(json) ?? new();

            //Console.WriteLine(account.Email);
            #endregion

            #region This sample deserializes JSON into an anonymous type.
            //var definition = new { Name = "" };

            //string json1 = @"{'Name':'James'}";
            //var customer1 = JsonConvert.DeserializeAnonymousType(json1, definition);

            //Console.WriteLine(customer1.Name);
            //// James

            //string json2 = @"{'Name':'Mike'}";
            //var customer2 = JsonConvert.DeserializeAnonymousType(json2, definition);

            //Console.WriteLine(customer2.Name);
            #endregion

        }
    }

}
