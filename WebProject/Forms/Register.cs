using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebProject.Core;
using WebProject.Forms;
using WebProject.Objects;

namespace WebProject.Forms
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
                RequestObject args = new RequestObject();
                Http http = new Http();
                //validation
                string login = login_field.Text;
                if (login == "" || !Regex.IsMatch(login,"[A-Za-z0-9+]"))
                {
                    MessageBox.Show("Login is empry or wrong!");
                    return;
                }
                string email = email_field.Text;
                if(email == "" || !Regex.IsMatch(email, ".*@.*"))
                {
                    MessageBox.Show("E-mail is empty or wrong");
                    return;
                }
                if(this.password_field.Text == "" || this.password_field2.Text == "")
                {
                    MessageBox.Show("Password or password confirmation is empty");
                    return;
                }
                string password = this.password_field.Text;
                if (password.Length < 8)
                {
                    MessageBox.Show("Password is too short");
                    return;
                }
                if (password != this.password_field2.Text)
                {
                    MessageBox.Show("Password and password confirmation isn't equal");
                    return;
                }
                args.data.Add("login", login_field.Text);
                args.data.Add("email", email_field.Text);
                args.data.Add("password", password_field.Text);
                ResponseObject result = http.PostRequest("api/registration", args);
                if (result.success != 1)
                {
                    MessageBox.Show("Error!\n" + result.error["message"]);
                    return;
                }
                TokenHelper.SaveToken(result.data["token"]);
                this.AppStart();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR!");
            }
        }

        private void AppStart()
        {
            this.Visible = false;
            App app = new App();
            app.Closed += onAppClose;
            app.Show();
        }

        private void onAppClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
