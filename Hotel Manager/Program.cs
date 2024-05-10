using Hotel_Manager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
            // Connect dữ liệu 
            string connectionString = (@"Data Source=DAROND\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
            DBContext context = new DBContext(connectionString);

            // Lấy dữ liệu 
            var allManager = context.Managers.ToList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 flogin = new Form1();
            if (flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }


            
        }
    }
}
