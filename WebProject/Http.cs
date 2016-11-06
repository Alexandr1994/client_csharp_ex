using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebProject
{
    class Http
    {
        /// <summary>
        /// HTTP-запрос на сервер методом POST
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="data">Данные для передачи на сервер (в теле запроса)</param>
        /// <returns>Ответ</returns>
        public Dictionary<string, string> PostRequest(string url, Dictionary<string, string> data)
        {
            return this.DoRequest(url, "POST", data);
        }

        /// <summary>
        /// HTTP-запрос на сервер методом GET
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="data">Данные для передачи на сервер (в строке запроса)</param>
        /// <returns>Ответ</returns>
        public Dictionary<string, string> GetRequest(string url, List<string> data)
        {
            foreach(string part in data)
            {
                url += "/" + part;
            }
            return this.DoRequest(url, "GET", new Dictionary<string, string>());
        }

        /// <summary>
        /// HTTP-запрос на сервер
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="method">Метод запроса</param>
        /// <param name="data">Данные для передачи на сервер</param>
        /// <returns></returns>
        private Dictionary<string, string> DoRequest(string url, string method, Dictionary<string, string> data)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://php_container-borntokill1361002.codeanyapp.com/" + url);
            request.ContentType = "application/json";
            request.Method = method;
            Stream stream = request.GetRequestStream();
            string temp = JsonConvert.SerializeObject(data);
            foreach (char part in temp)
            {
                stream.WriteByte((byte)part);
            }
            HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
            stream = responce.GetResponseStream();
            string respStr = "";
            while (true)
            {
                int part = stream.ReadByte();
                if (part == -1)
                {
                    break;
                }
                respStr += (char)part;
            }
            return JsonConvert.DeserializeObject<Dictionary<string, string>>(respStr);;
        }
    }
}
