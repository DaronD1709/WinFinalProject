using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class PenaltyBoard
    {
        public int ID_PenaltyBoard { get; set; }
        public string Shift { get; set; }
        public DateTime Day { get; set; }
        public string Role { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }

        // Constructor
        public PenaltyBoard(int idPenaltyBoard, string shift, DateTime day, string role, decimal amount, string reason)
        {
            ID_PenaltyBoard = idPenaltyBoard;
            Shift = shift;
            Day = day;
            Role = role;
            Amount = amount;
            Reason = reason;
        }
    }
}
