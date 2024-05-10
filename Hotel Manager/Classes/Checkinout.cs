using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Checkinout
    {
        public int ID_Employee { get; set; }
        public int ID_Calendar { get; set; }
        public DateTime TimeCheckin { get; set; }
        public DateTime TimeCheckout { get; set; }

        // Constructor
        public Checkinout(int idEmployee, int idCalendar, DateTime timeCheckin, DateTime timeCheckout)
        {
            ID_Employee = idEmployee;
            ID_Calendar = idCalendar;
            TimeCheckin = timeCheckin;
            TimeCheckout = timeCheckout;
        }
    }
}
