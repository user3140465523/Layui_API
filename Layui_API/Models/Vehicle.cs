using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Models
{
    public class Vehicle
    {
        [Key]
        /// <summary>
        /// 车辆编号
        /// </summary>
        public int Vid { get; set; }
        /// <summary>
        /// 车辆姓名 
        /// </summary>
        public string VName { get; set; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string VLicense { get; set; }
        /// <summary>
        /// 车辆价格
        /// </summary>
        public string VehiclePrices { get; set; }
        /// <summary>
        /// 车身颜色
        /// </summary>
        public string Vcolor { get; set; }
        /// <summary>
        /// 车辆燃料
        /// </summary>
        public string VehicleFuel { get; set; }
        /// <summary>
        /// 排放等级
        /// </summary>
        public string Emission { get; set; }
        /// <summary>
        /// 车辆结构
        /// </summary>
        public string VehicleStructure { get; set; }
        /// <summary>
        /// 车队id
        /// </summary>
        public int Mid { get; set; }
        //public int SId { get; set; }
        //public string Name { get; set; }
        //public bool Sex { get; set; }
        //public int CId { get; set; }
    }
}
