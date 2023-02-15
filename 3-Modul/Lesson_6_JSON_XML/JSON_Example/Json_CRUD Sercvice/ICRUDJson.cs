using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.Json_CRUD_Sercvice
{
    internal interface ICRUDJson
    {
        public void Add(Account account);
        public void Add(List<Account> accounts);
        public void Read(int Id);
        public void Update(int Id, Account accounts);
        public void Delete(int Id);


    }
}
