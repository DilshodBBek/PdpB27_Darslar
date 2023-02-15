using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example
{
    public class Account
    {
        public int Id { get; set; }
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
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };

            json = @"{
   'CPU': 'Intel',
   'PSU': '500W',
   'Drives': [
     'DVD read/writer'
     /*(broken)*/,
     '500 gigabyte hard drive',
     '200 gigabyte hard drive'
   ]
}";

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }

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
            //Account account1 = JsonConvert.DeserializeObject<Account>(json) ?? new();

            //Console.WriteLine(account1.Email);
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

            JObject o = JObject.Parse(@"{
  'Stores': [
    'Lambton Quay',
    'Willis Street'
  ],
  'Manufacturers': [
    {
      'Name': 'Acme Co',
      'Products': [
        {
          'Name': 'Anvil',
          'Price': 50
        }
      ]
    },
    {
      'Name': 'Contoso',
      'Products': [
        {
          'Name': 'Elbow Grease',
          'Price': 99.95
        },
        {
          'Name': 'Headlight Fluid',
          'Price': 4
        }
      ]
    }
  ]
}");

            // manufacturer with the name 'Acme Co'
            JToken acme = o.SelectToken("$.Manufacturers[?(@.Name == 'Acme Co')]");

            Console.WriteLine(acme);
            // { "Name": "Acme Co", Products: [{ "Name": "Anvil", "Price": 50 }] }

            // name of all products priced 50 and above
            IEnumerable<JToken> pricyProducts = o.SelectTokens("$..Products[?(@.Price >= 50)].Name");

            foreach (JToken item in pricyProducts)
            {
                Console.WriteLine(item);
            }

        }
    }

}
