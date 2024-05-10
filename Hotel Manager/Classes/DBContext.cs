using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Entity;

namespace Hotel_Manager.Classes
{

    internal class DBContext : DataContext
    { 
        public DbSet<Manager> Managers;
        public DbSet<AccountEmployee> AccountEmployees;
        public DbSet<AccountManager> AccountManagers;
        public DbSet<Checkinout> Checkinouts;
        public DbSet<Customer> Customers;
        public DbSet<Employee> Employees;
        public DbSet<HistoryRoomCheck> HistoryRoomChecks;
        public DbSet<InventoryHistory> InventoryHistories;
        public DbSet<Item> Items;
        public DbSet<Payroll> Payrolls;
        public DbSet<Penalty> Penaltys;
        public DbSet<PenaltyBoard> PenaltyBoards;
        public DbSet<Receipt> Receipts;
        public DbSet<ReportIncome> ReportIncomes;
        public DbSet<ReportInventory> ReportInventorys;
        public DbSet<Room> Rooms;
        public DbSet<Salary> Salarys;
        public DbSet<SalaryBoard> SalaryBoards;
        public DbSet<Shift> Shifts;
        public DbSet<SmartCalendar> SmartCalendars;


        public DBContext(string connectionString) : base(connectionString) 
        {
           
        }
    }
}
