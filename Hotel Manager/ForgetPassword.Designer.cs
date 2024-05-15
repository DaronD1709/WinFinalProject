namespace Hotel_Manager
{
    partial class ForgetPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnsendcode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forget Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code :";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(214, 182);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(462, 43);
            this.txtmail.TabIndex = 3;
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(214, 291);
            this.txtcode.Multiline = true;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(462, 43);
            this.txtcode.TabIndex = 4;
            // 
            // btnsendcode
            // 
            this.btnsendcode.BackColor = System.Drawing.Color.IndianRed;
            this.btnsendcode.FlatAppearance.BorderSize = 0;
            this.btnsendcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsendcode.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsendcode.Location = new System.Drawing.Point(712, 175);
            this.btnsendcode.Name = "btnsendcode";
            this.btnsendcode.Size = new System.Drawing.Size(164, 55);
            this.btnsendcode.TabIndex = 5;
            this.btnsendcode.Text = "Send Code";
            this.btnsendcode.UseVisualStyleBackColor = false;
            this.btnsendcode.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(386, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Verify Code";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(924, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsendcode);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnsendcode;
        private System.Windows.Forms.Button button2;
    }
}