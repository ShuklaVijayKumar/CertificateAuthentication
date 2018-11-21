using AuthenticationWCF_Server.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;

namespace AuthenticationWCF_Server.App_Code.Authentication
{
    public class CustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            var accountModel = new AccountModel();
            if (accountModel.Login(userName, password))
                return;
            throw new SecurityTokenException("Access denied !!");
        }
    }
}