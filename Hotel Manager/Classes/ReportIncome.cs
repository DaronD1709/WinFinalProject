using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class ReportIncome
    {
        public int ID_ReportIncome { get; set; }
        public decimal AmountIncome { get; set; }
        public decimal AmountOutcome { get; set; }

        // Constructor
        public ReportIncome(int idReportIncome, decimal amountIncome, decimal amountOutcome)
        {
            ID_ReportIncome = idReportIncome;
            AmountIncome = amountIncome;
            AmountOutcome = amountOutcome;
        }
    }
}
