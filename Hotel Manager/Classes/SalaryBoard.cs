using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class SalaryBoard
    {
        public int ID_SalaryBoard { get; set; }
        public DateTime Day { get; set; }
        public string Shift { get; set; }
        public string Role { get; set; }
        public decimal Amount { get; set; }

        // Constructor
        public SalaryBoard(int idSalaryBoard, DateTime day, string shift, string role, decimal amount)
        {
            ID_SalaryBoard = idSalaryBoard;
            Day = day;
            Shift = shift;
            Role = role;
            Amount = amount;
        }
    }
}
