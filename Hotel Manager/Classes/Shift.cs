using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Shift
    {
        public int ID_Shift { get; set; }
        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeOut { get; set; }

        // Constructor
        public Shift(int id, TimeSpan timeIn, TimeSpan timeOut)
        {
            ID_Shift = id;
            TimeIn = timeIn;
            TimeOut = timeOut;
        }
    }
}
