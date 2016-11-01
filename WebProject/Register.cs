using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_field.Text == "")
            {
                MessageBox.Show("Error!\nLogin is not inputed!");
                return;
            }
            if (password_field.Text != password_field2.Text)
            {
                MessageBox.Show("Error!\nWrong Password Confirmation!");
                return;
            }
            try
            {
                Dictionary<string, string> args = new Dictionary<string, string>();
                Http http = new Http();
                args["firstname"] = firstname_field.Text;
                args["surname"] = surname_field.Text;
                args["login"] = login_field.Text;
                args["password"] = password_field.Text;
                args = http.PostRequest("register", args);

                MessageBox.Show("Error!\n" + args["message"]);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
