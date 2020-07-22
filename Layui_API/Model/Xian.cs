using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Model
{
    public class Xian
    { /// <summary>
      /// 车队id
      /// </summary>
        public int Mid { get; set; }
        /// <summary>
        /// 车队名称
        /// </summary>
        public string MName { get; set; }
        /// <summary>
        /// 车队数量
        /// </summary>
        public int Mnumber { get; set; }
        /// <summary>
        /// 运输区域
        /// </summary>
        public string ShippingRegion { get; set; }
        /// <summary>
        /// 管理人
        /// </summary>
        public string Administrator { get; set; }
        /// <summary>
        /// 车队介绍
        /// </summary>
        public string TheTeam { get; set; }
    }
}
