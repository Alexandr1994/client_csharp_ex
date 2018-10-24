using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Objects
{
    /// <summary>
    /// Базовый класс данных для обмена с API сервера
    /// </summary>
    class RequestObject
    {
        /// <summary>
        /// Словарь данных простых типов 
        /// </summary>
        public Dictionary<string, string> data;

        public RequestObject()
        {
            this.data = new Dictionary<string, string>();
        }
    }
}
