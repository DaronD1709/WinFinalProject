using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager.Inventory
{
    public partial class AddInventory : Form
    {
        public AddInventory()
        {
            InitializeComponent();
        }

        private void AddInventory_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Search by ID, Item name";

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search by ID, Item name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search by ID, Item name";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AddItems addItems = new AddItems();
            addItems.ShowDialog();
        }
    }
}
