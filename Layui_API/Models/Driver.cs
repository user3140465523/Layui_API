using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Models
{
    public class Driver
    {
        [Key]
        public int Did { get; set; }
        public string DName { get; set; }
        public int DSex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DPhone { get; set; }
        public string DMaritalStatus { get; set; }
        public string DContactAddress { get; set; }
        public string DIDNumber { get; set; }
        public string DrivingNumber { get; set; }
        public string DQuasiType { get; set; }
        public string DBelongsTeam { get; set; }
        public DateTime DEntryTime { get; set; }
        public int Drid { get; set; }
    }
}
