﻿namespace Hotel_Manager
{
    partial class LaborMenu
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
            this.components = new System.ComponentModel.Container();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnlogout = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnreport = new FontAwesome.Sharp.IconButton();
            this.btnSalary = new FontAwesome.Sharp.IconButton();
            this.btninventory = new FontAwesome.Sharp.IconButton();
            this.buttonschedual = new FontAwesome.Sharp.IconButton();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(284, 24);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(61, 28);
            this.linkLabel3.TabIndex = 16;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Logout";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(159, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Welcome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(175, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "User";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnreport);
            this.panel5.Controls.Add(this.btnSalary);
            this.panel5.Location = new System.Drawing.Point(0, 390);
            this.panel5.MaximumSize = new System.Drawing.Size(279, 112);
            this.panel5.MinimumSize = new System.Drawing.Size(279, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 52);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 745);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1346, 745);
            this.panel4.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btninventory);
            this.panel1.Controls.Add(this.buttonschedual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(276, 689);
            this.panel1.MinimumSize = new System.Drawing.Size(125, 689);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 689);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnlogout.IconColor = System.Drawing.Color.Black;
            this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlogout.IconSize = 35;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 500);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnlogout.Size = new System.Drawing.Size(279, 54);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(-4, 223);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(283, 54);
            this.iconButton2.TabIndex = 18;
            this.iconButton2.Text = "In/Out";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(-4, 167);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(283, 54);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Menu";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Manager.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.White;
            this.btnreport.FlatAppearance.BorderSize = 0;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.btnreport.IconColor = System.Drawing.Color.Black;
            this.btnreport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnreport.IconSize = 35;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(-2, 1);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(280, 54);
            this.btnreport.TabIndex = 6;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnSalary.IconColor = System.Drawing.Color.Black;
            this.btnSalary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalary.IconSize = 35;
            this.btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalary.Location = new System.Drawing.Point(-1, 54);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSalary.Size = new System.Drawing.Size(280, 54);
            this.btnSalary.TabIndex = 7;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btninventory
            // 
            this.btninventory.BackColor = System.Drawing.Color.White;
            this.btninventory.FlatAppearance.BorderSize = 0;
            this.btninventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory.IconChar = FontAwesome.Sharp.IconChar.TruckRampBox;
            this.btninventory.IconColor = System.Drawing.Color.Black;
            this.btninventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninventory.IconSize = 35;
            this.btninventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninventory.Location = new System.Drawing.Point(-1, 279);
            this.btninventory.Name = "btninventory";
            this.btninventory.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btninventory.Size = new System.Drawing.Size(279, 54);
            this.btninventory.TabIndex = 2;
            this.btninventory.Text = "Inventory";
            this.btninventory.UseVisualStyleBackColor = false;
            this.btninventory.Click += new System.EventHandler(this.btninventory_Click);
            // 
            // buttonschedual
            // 
            this.buttonschedual.BackColor = System.Drawing.Color.White;
            this.buttonschedual.FlatAppearance.BorderSize = 0;
            this.buttonschedual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonschedual.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonschedual.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.buttonschedual.IconColor = System.Drawing.Color.Black;
            this.buttonschedual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonschedual.IconSize = 35;
            this.buttonschedual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonschedual.Location = new System.Drawing.Point(-1, 335);
            this.buttonschedual.Name = "buttonschedual";
            this.buttonschedual.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.buttonschedual.Size = new System.Drawing.Size(279, 54);
            this.buttonschedual.TabIndex = 4;
            this.buttonschedual.Text = "Schedule";
            this.buttonschedual.UseVisualStyleBackColor = false;
            this.buttonschedual.Click += new System.EventHandler(this.buttonschedual_Click);
            // 
            // LaborMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LaborMenu";
            this.Text = "LaborMenu";
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnreport;
        private FontAwesome.Sharp.IconButton btnSalary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btninventory;
        private FontAwesome.Sharp.IconButton buttonschedual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}