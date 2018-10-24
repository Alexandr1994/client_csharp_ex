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
using WebProject.Objects;
using WebProject.Core;
using WebProject.Forms;

namespace WebProject.Forms
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
            RequestTokenObject args = new RequestTokenObject();
            Http http = new Http();
            args.token = TokenHelper.LoadToken();
            try
            {
                ResponseObject result = http.PostRequest("api/logout", args);
                if(result.success == 1)
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
