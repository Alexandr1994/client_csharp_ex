using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebProject.Core
{
    class TokenHelper
    {
        /// <summary>
        /// Получить сохраненный токен
        /// </summary>
        /// <returns></returns>
        public static string LoadToken()
        {
            StreamReader reader = new StreamReader("token");
            string token = reader.ReadToEnd();
            reader.Close();
            return token;
        }

        /// <summary>
        /// Сохранить токен
        /// </summary>
        /// <param name="token">Токен</param>
        public static void SaveToken(string token)
        {
            DeleteToken();
            StreamWriter writer = new StreamWriter("token");
            writer.Write(token);
            writer.Close();
        }

        /// <summary>
        /// Удалить сохраненный токен
        /// </summary>
        public static void DeleteToken()
        {
            if (File.Exists("token"))
            {
                File.Delete("token");
            }
        }
    }
}
