using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebProject.Objects;
using WebProject.Core;

namespace WebProject.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            register.Closed += onRegClose;
            this.Visible = false;
        }

        private void onRegClose(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_field.Text == "" || password_field.Text == "")
            {
                MessageBox.Show("Error!\nEmpty field of login or password!");
                return;
            }
            try
            {
                Http http = new Http();
                RequestObject args = new RequestObject();
                args.data.Add("login", login_field.Text);
                args.data.Add("password", password_field.Text);
                ResponseObject result = http.PostRequest("api/login", args);
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
