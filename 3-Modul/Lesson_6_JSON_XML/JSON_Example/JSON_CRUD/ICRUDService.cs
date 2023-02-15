namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.JSON_CRUD
{
    interface ICRUDService
    {
        void Add(Account account);
        void Add(List<Account> accounts);
        bool Update(int id, Account account);
        bool Delete(int id);
        List<Account> GetAll();
        Account? GetById(int id);
    }
}
