using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Models
{
    public class Chenben
    {
        [Key]
        public int Id { get; set; }
        public int Cyid { get; set; }
        public string Startcity { get; set; }
        public string Endcity { get; set; }
        public int Kimiter { get; set; }
        public int People { get; set; }
        public int Sum { get; set; }
    }
}
