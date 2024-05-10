using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class AccountManager
    {
        public int ID_Manager { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        // Constructor
        public AccountManager(int id, string password, string username)
        {
            ID_Manager = id;
            Password = password;
            UserName = username;
        }
    }
}
