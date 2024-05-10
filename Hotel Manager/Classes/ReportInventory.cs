using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class ReportInventory
    {
        public int ID_ReportInventory { get; set; }
        public decimal TotalPriceAtItems { get; set; }
        public decimal TotalPriceDeliverItems { get; set; }
        public DateTime Day { get; set; }

        // Constructor
        public ReportInventory(int idReportInventory, decimal totalPriceAtItems, decimal totalPriceDeliverItems, DateTime day)
        {
            ID_ReportInventory = idReportInventory;
            TotalPriceAtItems = totalPriceAtItems;
            TotalPriceDeliverItems = totalPriceDeliverItems;
            Day = day;
        }
    }
}
