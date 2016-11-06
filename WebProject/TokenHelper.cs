using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebProject
{
    class TokenHelper
    {

        public static string LoadToken()
        {
            StreamReader reader = new StreamReader("token");
            string token = reader.ReadToEnd();
            reader.Close();
            return token;
        }

        public static void SaveToken(string token)
        {
            DeleteToken();
            StreamWriter writer = new StreamWriter("token");
            writer.Write(token);
            writer.Close();
        }

        public static void DeleteToken()
        {
            if (File.Exists("token"))
            {
                File.Delete("token");
            }
        }
    }
}
