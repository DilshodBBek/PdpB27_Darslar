using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_6_JSON_XML.JSON_Example.JSON_CRUD
{
    internal class AccountComparer : IEqualityComparer<Account>
    {
        public bool Equals(Account? x, Account? y)
        {
            return x?.Id==y?.Id;// x.Email==y.Email&&x.Active==y.Active&&x.Roles==y.Roles;
        }

        public int GetHashCode([DisallowNull] Account obj)
        {
            return obj.GetHashCode();
        }
    }
}
