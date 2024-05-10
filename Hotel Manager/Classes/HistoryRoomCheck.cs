using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class HistoryRoomCheck
    {
        public int ID_Customer { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Room { get; set; }
        public DateTime TimeCheckin { get; set; }
        public DateTime TimeCheckout { get; set; }
        public DateTime TimeHaveToCheckout { get; set; }

        // Constructor
        public HistoryRoomCheck(int idCustomer, int idEmployee, int idRoom, DateTime timeCheckin, DateTime timeCheckout, DateTime timeHaveToCheckout)
        {
            ID_Customer = idCustomer;
            ID_Employee = idEmployee;
            ID_Room = idRoom;
            TimeCheckin = timeCheckin;
            TimeCheckout = timeCheckout;
            TimeHaveToCheckout = timeHaveToCheckout;
        }
    }
}
