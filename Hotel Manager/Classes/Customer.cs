using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Customer
    {
        public int ID_Customer { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public byte[] Pictures { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }

        // Constructor
        public Customer(int idCustomer, string name, string number, byte[] pictures, string phoneNumber, DateTime dob)
        {
            ID_Customer = idCustomer;
            Name = name;
            Number = number;
            Pictures = pictures;
            PhoneNumber = phoneNumber;
            DOB = dob;
        }
    }
}
