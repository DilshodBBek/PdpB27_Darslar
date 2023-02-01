using OnlineEducation.Interfaces;
using OnlineEducation.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEducation.Models
{
    internal class Account : IAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public string PersonId { get; set; }
       public static Account AddAccount(string PersonId)
        {
            Console.WriteLine($"{PersonId} added new account");
            return new Account() { Id = 123 };
        }

        public void RemoveAccount(Account account)
        {
            Console.WriteLine(account.Id + " Removed");
        }
    }
}
