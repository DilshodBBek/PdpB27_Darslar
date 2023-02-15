using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.JsonTraining.Models
{
    internal class CRUD
    {
        string _path = @"..\..\..\Lesson_6_JSON_XML\JSON_Example\JsonTraining\shop.json";
        string _path1 = @"..\..\..\Lesson_6_JSON_XML\JSON_Example\JsonTraining\my.json";
        public Shop? GetAll()
        {
            if (File.Exists(_path))
            {
                //JObject jobj = JObject.Parse(File.ReadAllText(_path));
                return JsonConvert.DeserializeObject<Shop>(File.ReadAllText(_path));
            }
            return null;
        }
        public void Serialize(Shop shop)
        {
            if (!File.Exists(_path1)) { File.Create(_path1).Dispose(); }
            File.WriteAllText(_path1, JsonConvert.SerializeObject(shop, Formatting.Indented));
        }
        //public Root? GetAll()
        //{
        //    if (File.Exists(_path))
        //    {
        //        JObject jobj=JObject.Parse(File.ReadAllText(_path));
        //        return  JsonConvert.DeserializeObject<Root>(jobj.ToString());
        //    }
        //    return null;
        //}
        //public void Serialize(Root shop)
        //{
        //    if (!File.Exists(_path1)) { File.Create(_path1).Dispose(); }
        //    File.WriteAllText(_path1, JsonConvert.SerializeObject(shop, Formatting.Indented));
        //}
    }
}
