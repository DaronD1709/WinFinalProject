using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Employee
    {
        public int ID_Employee { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        // Constructor
        public Employee(int id, DateTime dob, string phoneNumber, string name, string role)
        {
            ID_Employee = id;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Name = name;
            Role = role;
        }
    }
}
