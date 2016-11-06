using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebProject
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> args = new Dictionary<string, string>();
            Http http = new Http();
            args["token"] = TokenHelper.LoadToken();
            try
            {
                args = http.PostRequest("account/logout", args);
                if(args["code"] == "200")
                {
                    TokenHelper.DeleteToken();
                    Application.Restart();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR!");
            }
        }
    }
}
