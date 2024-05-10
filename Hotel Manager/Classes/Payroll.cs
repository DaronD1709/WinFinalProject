using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Payroll
    {
        public int ID_Payroll { get; set; }
        public int ID_Employee { get; set; }
        public int ID_Manager { get; set; }
        public decimal Total_Payment { get; set; }
        public decimal? Punish { get; set; }
        public decimal? Salary { get; set; }

        // Constructor
        public Payroll(int idPayroll, int idEmployee, int idManager, decimal totalPayment, decimal? punish, decimal? salary)
        {
            ID_Payroll = idPayroll;
            ID_Employee = idEmployee;
            ID_Manager = idManager;
            Total_Payment = totalPayment;
            Punish = punish;
            Salary = salary;
        }
    }
}
