using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Room
    {
        public int ID_Room { get; set; }
        public string State { get; set; }
        public int NumberOfBeds { get; set; }
        public decimal PricePerHour { get; set; }

        // Constructor
        public Room(int idRoom, string state, int numberOfBeds, decimal pricePerHour)
        {
            ID_Room = idRoom;
            State = state;
            NumberOfBeds = numberOfBeds;
            PricePerHour = pricePerHour;
        }
    }
}
