using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Penalty
    {
        public int ID_Penalty { get; set; }
        public int ID_PenaltyBoard { get; set; }
        public int ID_Employee { get; set; }
        public int? ID_Manager { get; set; }
        public int? ID_Calendar { get; set; }
        public DateTime Day { get; set; }
        public string Shift { get; set; }
        public decimal Amount { get; set; }

        // Constructor
        public Penalty(int idPenalty, int idPenaltyBoard, int idEmployee, int? idManager, int? idCalendar, DateTime day, string shift, decimal amount)
        {
            ID_Penalty = idPenalty;
            ID_PenaltyBoard = idPenaltyBoard;
            ID_Employee = idEmployee;
            ID_Manager = idManager;
            ID_Calendar = idCalendar;
            Day = day;
            Shift = shift;
            Amount = amount;
        }
    }
}
