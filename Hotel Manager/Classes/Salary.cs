using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Salary
    {
        public int ID_Salary { get; set; }
        public int ID_Employee { get; set; }
        public int ID_SalaryBoard { get; set; }
        public int ID_Calendar { get; set; }
        public DateTime Day { get; set; }
        public string Shift { get; set; }
        public decimal Amount { get; set; }

        // Constructor
        public Salary(int idSalary, int idEmployee, int idSalaryBoard, int idCalendar, DateTime day, string shift, decimal amount)
        {
            ID_Salary = idSalary;
            ID_Employee = idEmployee;
            ID_SalaryBoard = idSalaryBoard;
            ID_Calendar = idCalendar;
            Day = day;
            Shift = shift;
            Amount = amount;
        }
    }
}
