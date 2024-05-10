using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Receipt
    {
        public int ID_Receipt { get; set; }
        public int ID_Customer { get; set; }
        public string Name_Customer { get; set; }
        public int ID_Room { get; set; }
        public int ID_Employee { get; set; }
        public DateTime TimeMake { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime DayInTotal { get; set; }

        // Constructor
        public Receipt(int idReceipt, int idCustomer, string nameCustomer, int idRoom, int idEmployee, DateTime timeMake, decimal totalPayment, DateTime dayInTotal)
        {
            ID_Receipt = idReceipt;
            ID_Customer = idCustomer;
            Name_Customer = nameCustomer;
            ID_Room = idRoom;
            ID_Employee = idEmployee;
            TimeMake = timeMake;
            TotalPayment = totalPayment;
            DayInTotal = dayInTotal;
        }
    }
}
