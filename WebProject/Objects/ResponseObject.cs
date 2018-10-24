using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProject.Objects
{
    class ResponseObject
    {
        public int success;
        public Dictionary<string, string> data;
        public Dictionary<string, string> error;

        public ResponseObject()
        {
            this.data = new Dictionary<string, string>();
            this.error = new Dictionary<string, string>();
        }
    }
}
