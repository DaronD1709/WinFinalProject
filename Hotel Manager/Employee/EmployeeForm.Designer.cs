namespace Hotel_Manager.Employee
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGVEmployee = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ID_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE MANAGEMENT";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(381, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // DGVEmployee
            // 
            this.DGVEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(232)))), ((int)(((byte)(217)))));
            this.DGVEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Employee,
            this.Name,
            this.Role,
            this.DOB,
            this.PhoneNumber,
            this.Picture});
            this.DGVEmployee.Location = new System.Drawing.Point(71, 149);
            this.DGVEmployee.Name = "DGVEmployee";
            this.DGVEmployee.RowHeadersWidth = 51;
            this.DGVEmployee.RowTemplate.Height = 24;
            this.DGVEmployee.Size = new System.Drawing.Size(1117, 484);
            this.DGVEmployee.TabIndex = 10;
            this.DGVEmployee.DoubleClick += new System.EventHandler(this.DGVEmployee_DoubleClick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(914, 50);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(231, 54);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "+ Add New Employee";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(526, 658);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 54);
            this.iconButton2.TabIndex = 44;
            this.iconButton2.Text = "Delete";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // ID_Employee
            // 
            this.ID_Employee.HeaderText = "ID Employee";
            this.ID_Employee.MinimumWidth = 6;
            this.ID_Employee.Name = "ID_Employee";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name ";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Picture
            // 
            this.Picture.HeaderText = "Picture";
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1237, 741);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.DGVEmployee);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGVEmployee;
        private System.Windows.Forms.Button btnadd;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
    }
}