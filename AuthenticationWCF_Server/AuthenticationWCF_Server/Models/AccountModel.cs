using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationWCF_Server.Models
{
    public class AccountModel
    {
        private List<Account> listAccounts = new List<Account>();

        public AccountModel()
        {
            listAccounts.Add(new Account { UserName = "test1", Password = "1234" });
            listAccounts.Add(new Account { UserName = "test2", Password = "1234" });
            listAccounts.Add(new Account { UserName = "test3", Password = "1234" });
        }

        public bool Login(string userName, string password)
        {
            return listAccounts.Count(x => x.UserName == userName && x.Password == password) > 0;
        }
    }
}