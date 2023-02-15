using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.Json_CRUD_Sercvice
{
    internal class JsonCrud : ICRUDJson
    {
        string PathJsonFile = @"..\..\..\Lesson_6_JSON_XML\JSON_Example\Json_CRUD Sercvice\MyData.json";
        string JsonString;
        JObject JsonObj;
        public JsonCrud()
        {
            if (File.Exists(PathJsonFile))
            {
                JsonString = File.ReadAllText(PathJsonFile);
                JsonObj = JObject.Parse(JsonString);
            }
        }
        public void Add(Account account)
        {
            Add(new List<Account>() { account });
        }

        public void Add(List<Account> accounts)
        {
            if (JsonObj==null)
            {
                string AccountsJson = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                AccountsJson = "{Accounts:" + AccountsJson + "}";
                using (StreamWriter sw = new(PathJsonFile))
                {
                    sw.Write(AccountsJson);
                }
            }
            else
            {
                List<Account>? accounts1 =JsonConvert.DeserializeObject<List<Account>>(JsonObj.GetValue("Accounts").ToString());
               // var ex = accounts1.Concat(accounts);
                foreach (Account item in accounts)
                {
                    if (accounts1.Contains(item))
                    {
                        accounts.Remove(item);
                    }
                }
                var sds  = JsonObj.Values("Accounts");
                //foreach (Account item in sds)
                //{
                    
                //}
                //using (StreamWriter sw = new(PathJsonFile))
                //{
                //    JProperty sd = JsonObj.AddFirst().ad;
                //    sd.
                //}
                //string json = JsonConvert.SerializeObject(accounts, Formatting.Indented);

                //JToken jToken = JsonObj.GetValue("Accounts");

                //JsonTextWriter jsonWriter = new();
                Console.WriteLine(JsonObj);
            }
           
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public void Read(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(int Id, Account accounts)
        {
            throw new NotImplementedException();
        }
    }
}
