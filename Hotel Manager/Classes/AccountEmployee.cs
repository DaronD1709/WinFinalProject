using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class AccountEmployee
    {
        public int ID_Employee { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Constructor
        public AccountEmployee(int idEmployee, string username, string password)
        {
            ID_Employee = idEmployee;
            Username = username;
            Password = password;
        }
    }
}
