using System;
using System.Collections.Generic;
using System.Text;

namespace BnakApp
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Account[] Accounts { get; set; }
    }

}
