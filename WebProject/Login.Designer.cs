namespace WebProject
{
    partial class Login
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_field = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(66, 179);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(122, 31);
            this.reg_btn.TabIndex = 0;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(90, 40);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(129, 20);
            this.login_field.TabIndex = 1;
            this.login_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(66, 131);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(122, 31);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(90, 79);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(129, 20);
            this.password_field.TabIndex = 3;
            this.password_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_field.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.login_field);
            this.Controls.Add(this.reg_btn);
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

