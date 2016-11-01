namespace WebProject
{
    partial class App
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
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(83, 212);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(115, 38);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(29, 50);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(24, 13);
            this.info_label.TabIndex = 2;
            this.info_label.Text = "info";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_btn);
            this.Name = "App";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_label;
    }
}