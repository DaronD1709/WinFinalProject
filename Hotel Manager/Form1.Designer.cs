namespace Hotel_Manager
{
    partial class Form1
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
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.btnlogin = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new Krypton.Toolkit.KryptonTextBox();
            this.txtpassword = new Krypton.Toolkit.KryptonTextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnmanager = new System.Windows.Forms.RadioButton();
            this.btemployee = new System.Windows.Forms.RadioButton();
            this.btnadmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(17)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(163, 412);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(194, 58);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.AliceBlue;
            this.linkLabel2.Location = new System.Drawing.Point(259, 282);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(124, 24);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password ?";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(161, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 72);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOGIN";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(143, 136);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(240, 41);
            this.txtusername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtusername.StateCommon.Border.Rounding = 20F;
            this.txtusername.StateCommon.Content.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.TabIndex = 11;
            this.txtusername.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged_2);
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(143, 217);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '●';
            this.txtpassword.Size = new System.Drawing.Size(240, 41);
            this.txtpassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpassword.StateCommon.Border.Rounding = 20F;
            this.txtpassword.StateCommon.Content.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.TabIndex = 12;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 38;
            this.iconPictureBox2.Location = new System.Drawing.Point(88, 220);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(40, 38);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(88, 139);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(40, 38);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Manager.Properties.Resources.backGround_DN;
            this.pictureBox1.Location = new System.Drawing.Point(2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1162, 500);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnmanager
            // 
            this.btnmanager.AutoSize = true;
            this.btnmanager.BackColor = System.Drawing.Color.Transparent;
            this.btnmanager.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmanager.Location = new System.Drawing.Point(216, 350);
            this.btnmanager.Name = "btnmanager";
            this.btnmanager.Size = new System.Drawing.Size(83, 28);
            this.btnmanager.TabIndex = 15;
            this.btnmanager.TabStop = true;
            this.btnmanager.Text = "Manager";
            this.btnmanager.UseVisualStyleBackColor = false;
            // 
            // btemployee
            // 
            this.btemployee.AutoSize = true;
            this.btemployee.BackColor = System.Drawing.Color.Transparent;
            this.btemployee.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btemployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btemployee.Location = new System.Drawing.Point(329, 350);
            this.btemployee.Name = "btemployee";
            this.btemployee.Size = new System.Drawing.Size(87, 28);
            this.btemployee.TabIndex = 14;
            this.btemployee.TabStop = true;
            this.btemployee.Text = "Employee";
            this.btemployee.UseVisualStyleBackColor = false;
            // 
            // btnadmin
            // 
            this.btnadmin.AutoSize = true;
            this.btnadmin.BackColor = System.Drawing.Color.Transparent;
            this.btnadmin.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadmin.Location = new System.Drawing.Point(114, 350);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(67, 28);
            this.btnadmin.TabIndex = 13;
            this.btnadmin.TabStop = true;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.ClientSize = new System.Drawing.Size(1124, 508);
            this.Controls.Add(this.btnmanager);
            this.Controls.Add(this.btemployee);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txtusername;
        private Krypton.Toolkit.KryptonTextBox txtpassword;
        private System.Windows.Forms.RadioButton btnmanager;
        private System.Windows.Forms.RadioButton btemployee;
        private System.Windows.Forms.RadioButton btnadmin;
    }
}

