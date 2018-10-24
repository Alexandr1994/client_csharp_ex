using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebProject.Objects;
using WebProject.Forms;
using WebProject.Core;

namespace WebProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                RequestTokenObject args = new RequestTokenObject();
                args.token = TokenHelper.LoadToken();
                Http http = new Http();
                ResponseObject result = http.PostRequest("api/user", args);
                if (result.success == 1)
                {
                    Application.Run(new App());
                }
                else
                {
                    Application.Run(new Login());
                }
            }
            catch (Exception e)
            {
                Application.Run(new Login());
            }
        }
    }
}
