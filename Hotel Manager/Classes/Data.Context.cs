﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Manager.Classes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HotelEntities : DbContext
    {
        public HotelEntities()
            : base("name=HotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account_Employee> Account_Employee { get; set; }
        public virtual DbSet<Account_Manager> Account_Manager { get; set; }
        public virtual DbSet<Checkin_out> Checkin_out { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<HistoryRoomcheck> HistoryRoomchecks { get; set; }
        public virtual DbSet<InventoryHistory> InventoryHistories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Payroll> Payrolls { get; set; }
        public virtual DbSet<Penalty> Penalties { get; set; }
        public virtual DbSet<PenaltyBoard> PenaltyBoards { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReportIncome> ReportIncomes { get; set; }
        public virtual DbSet<ReportInventory> ReportInventories { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<SalaryBoard> SalaryBoards { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Smart_Calendar> Smart_Calendar { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}