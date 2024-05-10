using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class SmartCalendar
    {
        public int ID_Calendar { get; set; }
        public int ID_Shift { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int ID_Employee { get; set; }
        public string Name_Employee { get; set; }

        // Constructor
        public SmartCalendar(int idCalendar, int idShift, TimeSpan? timeIn, TimeSpan? timeOut, int idEmployee, string nameEmployee)
        {
            ID_Calendar = idCalendar;
            ID_Shift = idShift;
            TimeIn = timeIn;
            TimeOut = timeOut;
            ID_Employee = idEmployee;
            Name_Employee = nameEmployee;
        }

        static void AutoCreateCalender(DBContext context)
        {
            int employeenum = context.Employees.Count();
            int shiftnum = context.Shifts.Count();
            int dayofweek = 7;
        }



        private int[,,] RenderShiftRequests(List<Tuple<int, int, int>> requests)
        {
            int numNurses = requests.Max(t => t.Item1) + 1;
            int numDays = requests.Max(t => t.Item2) + 1;
            int numShifts = requests.Max(t => t.Item3) + 1;

            int[,,] shiftRequests = new int[numNurses, numDays, numShifts];

            foreach (var request in requests)
            {
                int nurse = request.Item1;
                int day = request.Item2;
                int shift = request.Item3;

                shiftRequests[nurse, day, shift] = 1;
            }

            return shiftRequests;

        }
        static public List<Tuple<int, int, int>> requests = new List<Tuple<int, int, int>>()
        {

        };
    }
}
