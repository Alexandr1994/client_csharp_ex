namespace WebProject.Forms
{
    partial class Register
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
            this.label3 = new System.Windows.Forms.Label();
            this.login_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_field2 = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.email_field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login:";
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(101, 12);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(129, 20);
            this.login_field.TabIndex = 1;
            this.login_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(101, 64);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(129, 20);
            this.password_field.TabIndex = 3;
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_field.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm password:";
            // 
            // password_field2
            // 
            this.password_field2.Location = new System.Drawing.Point(101, 90);
            this.password_field2.Name = "password_field2";
            this.password_field2.PasswordChar = '*';
            this.password_field2.Size = new System.Drawing.Size(129, 20);
            this.password_field2.TabIndex = 4;
            this.password_field2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_field2.UseSystemPasswordChar = true;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(67, 116);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(122, 31);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "E-mail:";
            // 
            // email_field
            // 
            this.email_field.Location = new System.Drawing.Point(101, 38);
            this.email_field.Name = "email_field";
            this.email_field.Size = new System.Drawing.Size(129, 20);
            this.email_field.TabIndex = 2;
            this.email_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 155);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email_field);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_field2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_field);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_field2;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email_field;
    }
}