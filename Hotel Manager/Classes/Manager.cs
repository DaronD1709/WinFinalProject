using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    internal class Manager
    {
        ConnectionManager connectionManager = new ConnectionManager();
        public int ID_Manager { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }

        // Constructor
        public Manager(int id, string name, DateTime dob, string phoneNumber)
        {
            ID_Manager = id;
            Name = name;
            DOB = dob;
            PhoneNumber = phoneNumber;
        }
    }
}
