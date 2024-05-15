using Hotel_Manager.Customer;
using Hotel_Manager.Room;
using Hotel_Manager.Checkinout;
using Hotel_Manager.Employee;
using Hotel_Manager.Manager;
using Hotel_Manager.Revenue;
using Hotel_Manager.Inventory;
using Hotel_Manager.Salary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class EmployeeMenuForm : Form
    {
        private bool isCollapsed;
        private bool ismenu;
        private Form currentChildForm;
        public EmployeeMenuForm()
        {
            InitializeComponent();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InfoCustomer());
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookRooms());
        }

        private void EmployeeMenuForm_Load(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Second Form 
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel5.Height += 10;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width += 15;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel1.Width -= 15;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalaryForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InOut());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InfoAccount infoAccount = new InfoAccount();
            infoAccount.Show();
        }
    }
}
