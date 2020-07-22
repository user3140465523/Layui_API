using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Model
{
    public class Response
    {
        public int code { get; set; } = 0;
        public string msg { get; set; }
        public int count { get; set; }
        public object data { get; set; }
    }
}
