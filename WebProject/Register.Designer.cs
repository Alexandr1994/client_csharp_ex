namespace WebProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstname_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_field2 = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firstname:";
            // 
            // firstname_field
            // 
            this.firstname_field.Location = new System.Drawing.Point(105, 34);
            this.firstname_field.Name = "firstname_field";
            this.firstname_field.Size = new System.Drawing.Size(129, 20);
            this.firstname_field.TabIndex = 10;
            this.firstname_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname:";
            // 
            // surname_field
            // 
            this.surname_field.Location = new System.Drawing.Point(105, 60);
            this.surname_field.Name = "surname_field";
            this.surname_field.Size = new System.Drawing.Size(129, 20);
            this.surname_field.TabIndex = 12;
            this.surname_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login:";
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(105, 86);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(129, 20);
            this.login_field.TabIndex = 14;
            this.login_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(105, 112);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(129, 20);
            this.password_field.TabIndex = 16;
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_field.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirm password:";
            // 
            // password_field2
            // 
            this.password_field2.Location = new System.Drawing.Point(105, 138);
            this.password_field2.Name = "password_field2";
            this.password_field2.PasswordChar = '*';
            this.password_field2.Size = new System.Drawing.Size(129, 20);
            this.password_field2.TabIndex = 18;
            this.password_field2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_field2.UseSystemPasswordChar = true;
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(78, 184);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(122, 31);
            this.reg_btn.TabIndex = 20;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_field2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstname_field);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstname_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surname_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_field2;
        private System.Windows.Forms.Button reg_btn;

    }
}