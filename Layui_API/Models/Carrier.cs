using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Models
{
    public class Carrier
    {
        [Key]
        public int CID { get; set; }
        public string Position { get; set; }
        public DateTime StarTime { get; set; }
        public string Estimate { get; set; }
        public string Fleet { get; set; }
        public int CarNo { get; set; }
        public string Numbers { get; set; }
    }
}
