using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layui_API.Models
{
    public class DBContext:DbContext
    {
        public DBContext() { }
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        /// <summary>
        /// 车辆信息
        /// </summary>
        public DbSet<Vehicle>  vehicles  { get; set; }
        /// <summary>
        /// 车队信息
        /// </summary>
        public DbSet<Motorcade>  motorcades { get; set; }
        /// <summary>
        /// 驾驶员
        /// </summary>
        public DbSet<Driver> drivers { get; set; }
        /// <summary>
        /// 承运单
        /// </summary>
        public DbSet<Carrier> carriers { get; set; }
        /// <summary>
        /// 成本
        /// </summary>
        public DbSet<Chenben> chenbens { get; set; }
 
    }
}
