using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Objects
{
    /// <summary>
    /// Класс данных для обмена с API сервера с токеном сессии
    /// </summary>
    class RequestTokenObject : RequestObject
    {
        /// <summary>
        /// Токен сессии
        /// </summary>
        public string token;

        public RequestTokenObject() : base()
        {
            this.token = null;
        }
    }
}
