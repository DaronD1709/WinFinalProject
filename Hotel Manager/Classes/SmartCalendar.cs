using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Google.OrTools.Sat;

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
        static List<Tuple<int, int, int>> requests = new List<Tuple<int, int, int>>();

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

      

            int[] allNurses = Enumerable.Range(0, employeenum).ToArray();
            int[] allDays = Enumerable.Range(0, dayofweek).ToArray();
            int[] allShifts = Enumerable.Range(0, shiftnum).ToArray();

            requests.Add(Tuple.Create(1, 1, 1));
            requests.Add(Tuple.Create(2, 2, 0));
            requests.Add(Tuple.Create(3, 3, 2));
            requests.Add(Tuple.Create(4, 4, 1));
            requests.Add(Tuple.Create(0, 5, 0));
            requests.Add(Tuple.Create(1, 6, 2));
            requests.Add(Tuple.Create(2, 0, 1));
            requests.Add(Tuple.Create(3, 1, 0));
            requests.Add(Tuple.Create(4, 2, 2));

            int[,,] shiftRequests = RenderShiftRequests(requests);
            // Creates the model.
            CpModel model = new CpModel();

            // Creates shift variables.
            // shifts[(n, d, s)]: nurse 'n' works shift 's' on day 'd'.

            Dictionary<Tuple<int, int, int>, IntVar> shifts = new Dictionary<Tuple<int, int, int>, IntVar>();

            foreach (int n in allNurses)
            {
                foreach (int d in allDays)
                {
                    foreach (int s in allShifts)
                    {
                        shifts.Add(Tuple.Create(n, d, s), model.NewBoolVar($"shifts_n{n}d{d}s{s}"));
                    }
                }
            }

            // Each shift is assigned to exactly one nurse in the schedule period.
            foreach (int d in allDays)
            {
                foreach (int s in allShifts)
                {
                    IntVar[] x = new IntVar[employeenum];
                    foreach (int n in allNurses)
                    {
                        var key = Tuple.Create(n, d, s);
                        x[n] = shifts[key];
                    }
                    model.Add(LinearExpr.Sum(x) == 1);
                }
            }

            // Each nurse works at most one shift per day.
            foreach (int n in allNurses)
            {
                foreach (int d in allDays)
                {
                    IntVar[] x = new IntVar[shiftnum];
                    foreach (int s in allShifts)
                    {
                        var key = Tuple.Create(n, d, s);
                        x[s] = shifts[key];
                    }
                    model.Add(LinearExpr.Sum(x) <= 1);
                }
            }

            // Try to distribute the shifts evenly, so that each nurse works
            // minShiftsPerNurse shifts. If this is not possible, because the total
            // number of shifts is not divisible by the number of nurses, some nurses will
            // be assigned one more shift.
            int minShiftsPerNurse = (shiftnum * dayofweek) / employeenum;
            int maxShiftsPerNurse;
            if ((shiftnum * dayofweek) % employeenum == 0)
            {
                maxShiftsPerNurse = minShiftsPerNurse;
            }
            else
            {
                maxShiftsPerNurse = minShiftsPerNurse + 1;
            }
            foreach (int n in allNurses)
            {
                IntVar[] numShiftsWorked = new IntVar[dayofweek * shiftnum];
                foreach (int d in allDays)
                {
                    foreach (int s in allShifts)
                    {
                        var key = Tuple.Create(n, d, s);
                        numShiftsWorked[d * shiftnum + s] = shifts[key];
                    }
                }
                model.AddLinearConstraint(LinearExpr.Sum(numShiftsWorked), minShiftsPerNurse, maxShiftsPerNurse);
            }

            IntVar[] flatShifts = new IntVar[employeenum * dayofweek * shiftnum];
            int[] flatShiftRequests = new int[employeenum * dayofweek * shiftnum];
            foreach (int n in allNurses)
            {
                foreach (int d in allDays)
                {
                    foreach (int s in allShifts)
                    {
                        var key = Tuple.Create(n, d, s);
                        flatShifts[n * dayofweek * shiftnum + d * shiftnum + s] = shifts[key];
                        flatShiftRequests[n * dayofweek * shiftnum + d * shiftnum + s] = shiftRequests[n, d, s];
                    }
                }
            }
            model.Maximize(LinearExpr.WeightedSum(flatShifts, flatShiftRequests));

            // Solve
            CpSolver solver = new CpSolver();
            CpSolverStatus status = solver.Solve(model);
            Console.WriteLine($"Solve status: {status}");

            if (status == CpSolverStatus.Optimal || status == CpSolverStatus.Feasible)
            {
                Console.WriteLine("Solution:");
                foreach (int d in allDays)
                {
                    Console.WriteLine($"Day {d}");
                    foreach (int n in allNurses)
                    {
                        bool isWorking = false;
                        foreach (int s in allShifts)
                        {
                            var key = Tuple.Create(n, d, s);
                            if (solver.Value(shifts[key]) == 1L)
                            {
                                if (shiftRequests[n, d, s] == 1)
                                {
                                    Console.WriteLine($"  Nurse {n} work shift {s} (requested).");
                                }
                                else
                                {
                                    Console.WriteLine($"  Nurse {n} work shift {s} (not requested).");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(
                    $"Number of shift requests met = {solver.ObjectiveValue} (out of {employeenum * minShiftsPerNurse}).");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }

         

            requests.Clear();   

        }


                


            
        
    


         // Render 
        

        static private int[,,] RenderShiftRequests(List<Tuple<int, int, int>> requests)
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
       
    }
}


