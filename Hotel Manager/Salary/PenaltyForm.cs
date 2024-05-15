using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager.Salary
{
    public partial class PenaltyForm : Form
    {
        public PenaltyForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PunishForm punishForm = new PunishForm();
            punishForm.ShowDialog();
        }
    }
}
