using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string token = "";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                StreamReader reader = new StreamReader("token");
                token = reader.ReadToEnd();
                reader.Close();
                Dictionary<string, string> args = new Dictionary<string, string>();
                args["token"] = token;
                Http http = new Http();
                args = http.PostRequest("user", args);
                if (args["code"] == "200")
                {
                    Application.Run(new App());
                }
                else
                {
                    Application.Run(new Login());
                }
            }
            catch (Exception)
            {
                Application.Run(new Login());
            }
            
        }
    }
}
