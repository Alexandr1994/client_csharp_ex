using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebProject.Objects;

namespace WebProject.Core
{
    class Http
    {
        private string host = "http://web_omstu-borntokill1361002.codeanyapp.com/";

        /// <summary>
        /// HTTP-запрос на сервер методом POST
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="data">Данные для передачи на сервер (в теле запроса)</param>
        /// <returns>Ответ</returns>
        public ResponseObject PostRequest(string url, RequestObject data)
        {
            return this.DoRequest(url, "POST", data);
        }

        /// <summary>
        /// HTTP-запрос на сервер методом GET
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="data">Данные для передачи на сервер (в строке запроса)</param>
        /// <returns>Ответ</returns>
        public ResponseObject GetRequest(string url, Dictionary<string, string> data)
        {
            //GET data
            if(data.Count > 0)
            {
                url += "?";
                int index = 0;
                foreach (KeyValuePair<string, string> part in data)
                {
                    if (index > 0)
                    {
                        url += "&";
                    }
                    url += part.Key + "=" + part.Value;
                    index++;
                }
            }
            return this.DoRequest(url, "GET");
        }

        /// <summary>
        /// HTTP-запрос на сервер
        /// </summary>
        /// <param name="url">URI</param>
        /// <param name="method">Метод запроса</param>
        /// <param name="data">Данные для передачи на сервер</param>
        /// <returns></returns>
        private ResponseObject DoRequest(string url, string method, RequestObject data = null)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host + url);
            request.ContentType = "application/json";
            request.Method = method;
            Stream stream;
            //request data
            if (data != null)
            {
                stream = request.GetRequestStream();
                string temp = JsonConvert.SerializeObject(data);
                foreach (char part in temp)
                {
                    stream.WriteByte((byte)part);
                }
            }//response
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
            return JsonConvert.DeserializeObject<ResponseObject>(respStr);;
        }
    }
}
