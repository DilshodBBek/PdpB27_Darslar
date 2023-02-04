using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class PredicateExample
    {
        public static void Run()
        {
            Predicate<string> isEmailAddres = email => email.Contains('@');

            List<string> emails = new();

            emails.Add("Salom@gmail.com");
            emails.Add("Hello World");
            emails.Add("Tramp@mail.ru");

            string? foundEmail = emails.Find(isEmailAddres);

            Console.WriteLine("Find email address is:{0}", foundEmail);

            string f = "sdfsgDilshoddfhdfDilshodfgjghDilshod";
            //f(x => x.Equals("Dilshod"));

            Dictionary<string, int> d = new();

            d.Any(x => x.Key=="Google"&&x.Value==1);


        }
    }
}
