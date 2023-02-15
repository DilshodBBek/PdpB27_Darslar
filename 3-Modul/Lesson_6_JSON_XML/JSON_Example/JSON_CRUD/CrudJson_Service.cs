using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.JSON_CRUD
{
    internal class CrudJson_Service : ICRUDService
    {
        string _path = @"..\..\..\Lesson_6_JSON_XML\JSON_Example\JSON_CRUD\AccountData.json";
        string _db;
        public CrudJson_Service()
        {
            if (File.Exists(_path))
            {
                _db = File.ReadAllText(_path);
            }
        }

        public void Add(Account account)
        {
            Add(new List<Account>() { account });
        }

        public void Add(List<Account> accounts)
        {
            List<Account> _data = new();
            if (File.Exists(_path))
            {
                _data = JsonConvert.DeserializeObject<List<Account>>(_db) ?? new();
                accounts = accounts.Except(_data).ToList();
            }
            else
            {
                File.Create(_path).Dispose();
            }
            if (accounts.Count != 0)
            {
                _data.AddRange(accounts);
                _db = JsonConvert.SerializeObject(_data, Formatting.Indented);
                File.WriteAllText(_path, _db);
            }
        }

        public bool Delete(int id)
        {
            JArray accounts = JArray.Parse(_db);
            JToken? FoundAccount = accounts.FirstOrDefault(x => (int)x["Id"] == id);
            //JProperty? prop =new JProperty( FoundAccount.Children<JProperty>().Select(x=>x.Name).FirstOrDefault());
            JToken? id1 = FoundAccount.FirstOrDefault(x => (int)x["Id"] == 1);
            if (FoundAccount != null)
            {
                accounts.Remove(FoundAccount);
                File.WriteAllText(_path, accounts.ToString());
                return true;
            }
            return false;
        }

        public List<Account> GetAll()
        {
            return JsonConvert.DeserializeObject<List<Account>>(_db) ?? new();
        }

        public Account? GetById(int id)
        {
            JArray accounts = JArray.Parse(_db);
            JToken? tokenAccount = accounts.FirstOrDefault(x => (int)x["Id"] == id);
            return tokenAccount == null ? null : JsonConvert.DeserializeObject<Account>(tokenAccount.ToString());
        }

        public bool Update(int id, Account account)
        {
            JArray accounts = JArray.Parse(_db);
            //JToken? FoundAccount = accounts.SelectToken(@$"$.[?(@.Id === {id})]");
            JToken? FoundAccount = accounts.FirstOrDefault(x => (int)x["Id"] == id);
            if (FoundAccount != null)
            {
                account.Id = id;
                accounts.Remove(FoundAccount);
                FoundAccount = JToken.Parse(JsonConvert.SerializeObject(account, Formatting.Indented));
                accounts.Add(FoundAccount);
                File.WriteAllText(_path, accounts.ToString());
                return true;
            }
            return false;
        }
    }
}
