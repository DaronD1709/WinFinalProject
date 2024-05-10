using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class InventoryHistory
    {
        public int ID_InventoryHistory { get; set; }
        public int ID_Items { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
        public int? ID_Room { get; set; }

        // Constructor
        public InventoryHistory(int idInventoryHistory, int idItems, int number, DateTime time, int? idRoom)
        {
            ID_InventoryHistory = idInventoryHistory;
            ID_Items = idItems;
            Number = number;
            Time = time;
            ID_Room = idRoom;
        }
    }
}
