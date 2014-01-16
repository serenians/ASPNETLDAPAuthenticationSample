using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LDAPAuthenticationSample.Models
{
    public class LoginModel
    {
        public string Password { get; set; }

        public string UserName { get; set; }
    }
}