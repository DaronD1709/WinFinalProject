namespace Hotel_Manager
{
    partial class OTP
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
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm Code OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(157, 167);
            this.txtOTP.Multiline = true;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(494, 42);
            this.txtOTP.TabIndex = 1;
            // 
            // btnOTP
            // 
            this.btnOTP.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTP.Location = new System.Drawing.Point(311, 274);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(188, 50);
            this.btnOTP.TabIndex = 2;
            this.btnOTP.Text = "Confirm";
            this.btnOTP.UseVisualStyleBackColor = true;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.btnOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.label1);
            this.Name = "OTP";
            this.Text = "OTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnOTP;
    }
}