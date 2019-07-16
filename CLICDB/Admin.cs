using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICDB
{
    public class Admin
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Admin()
        {
            FirstName = "";
            LastName = "";
            Phone = "";
            Username = "";
            Password = "";
        }
    }
}
