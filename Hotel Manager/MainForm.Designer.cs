namespace Hotel_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.btnreport = new FontAwesome.Sharp.IconButton();
            this.btnemployee = new FontAwesome.Sharp.IconButton();
            this.btnroom = new FontAwesome.Sharp.IconButton();
            this.buttoninventory = new FontAwesome.Sharp.IconButton();
            this.buttonschedual = new FontAwesome.Sharp.IconButton();
            this.btncustomer = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btnroom);
            this.panel1.Controls.Add(this.buttoninventory);
            this.panel1.Controls.Add(this.buttonschedual);
            this.panel1.Controls.Add(this.btncustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 609);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(285, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 609);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(-1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 158);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1043, 609);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "User";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(183, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 28);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Info User";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnlogout.IconColor = System.Drawing.Color.Black;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.IconSize = 35;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 555);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(285, 54);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnreport.IconColor = System.Drawing.Color.Black;
            this.btnreport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreport.IconSize = 35;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(3, 471);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(280, 54);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnemployee.FlatAppearance.BorderSize = 0;
            this.btnemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnemployee.IconColor = System.Drawing.Color.Black;
            this.btnemployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnemployee.IconSize = 35;
            this.btnemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemployee.Location = new System.Drawing.Point(3, 191);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnemployee.Size = new System.Drawing.Size(279, 54);
            this.btnemployee.TabIndex = 0;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnroom
            // 
            this.btnroom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnroom.FlatAppearance.BorderSize = 0;
            this.btnroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroom.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnroom.IconColor = System.Drawing.Color.Black;
            this.btnroom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnroom.IconSize = 35;
            this.btnroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Location = new System.Drawing.Point(3, 303);
            this.btnroom.Name = "btnroom";
            this.btnroom.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnroom.Size = new System.Drawing.Size(279, 54);
            this.btnroom.TabIndex = 2;
            this.btnroom.Text = "Room";
            this.btnroom.UseVisualStyleBackColor = false;
            // 
            // buttoninventory
            // 
            this.buttoninventory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttoninventory.FlatAppearance.BorderSize = 0;
            this.buttoninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoninventory.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninventory.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.buttoninventory.IconColor = System.Drawing.Color.Black;
            this.buttoninventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttoninventory.IconSize = 35;
            this.buttoninventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoninventory.Location = new System.Drawing.Point(3, 359);
            this.buttoninventory.Name = "buttoninventory";
            this.buttoninventory.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttoninventory.Size = new System.Drawing.Size(279, 54);
            this.buttoninventory.TabIndex = 3;
            this.buttoninventory.Text = "Inventory";
            this.buttoninventory.UseVisualStyleBackColor = false;
            // 
            // buttonschedual
            // 
            this.buttonschedual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonschedual.FlatAppearance.BorderSize = 0;
            this.buttonschedual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonschedual.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonschedual.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.buttonschedual.IconColor = System.Drawing.Color.Black;
            this.buttonschedual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonschedual.IconSize = 35;
            this.buttonschedual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonschedual.Location = new System.Drawing.Point(3, 415);
            this.buttonschedual.Name = "buttonschedual";
            this.buttonschedual.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonschedual.Size = new System.Drawing.Size(279, 54);
            this.buttonschedual.TabIndex = 4;
            this.buttonschedual.Text = "Schedule";
            this.buttonschedual.UseVisualStyleBackColor = false;
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncustomer.FlatAppearance.BorderSize = 0;
            this.btncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncustomer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btncustomer.IconColor = System.Drawing.Color.Black;
            this.btncustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncustomer.IconSize = 35;
            this.btncustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncustomer.Location = new System.Drawing.Point(3, 247);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btncustomer.Size = new System.Drawing.Size(279, 54);
            this.btncustomer.TabIndex = 1;
            this.btncustomer.Text = "Customer";
            this.btncustomer.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonschedual;
        private FontAwesome.Sharp.IconButton buttoninventory;
        private FontAwesome.Sharp.IconButton btnroom;
        private FontAwesome.Sharp.IconButton btncustomer;
        private FontAwesome.Sharp.IconButton btnemployee;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnlogout;
        private FontAwesome.Sharp.IconButton btnreport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}