using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace webapiBasic.Basic
{
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        public string Password { get; set; }
        public BasicAuthenticationIdentity(string name , string password):base(name,"Basic")
        {
            this.Password = password;
        }
    }
}