using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Layui_API.Model;
using Layui_API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Layui_API.Controllers
{
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]
    //车队控制器
    public class ClssController : ControllerBase
    {
        public DBContext db;

        public ClssController(DBContext db)
        {
            this.db = db;
        }

        //显示
        [HttpGet]
        [Route("GetClss")]
        public ActionResult<Response> GetClss(int page, int limit, string mName = "")
        {
            var linq = (from s in db.classes
                        select new Xian()
                        {
                            Mid = s.Mid,
                            MName = s.MName,
                            Mnumber = s.Mnumber,
                            ShippingRegion = s.ShippingRegion,
                            Administrator = s.Administrator,
                            TheTeam = s.TheTeam,
                          
                        }).ToList();
           
            if (mName == null)
            {
                mName = "";
            }
            linq = linq.Where(m => m.MName.Contains(mName)).ToList();
            int num = linq.Count;
            linq = linq.OrderByDescending(m => m.Mid).Skip((page - 1) * limit).Take(limit).ToList();
            return new Response() { code = 0, msg = "", data = linq, count = num };
          
        }
        //添加
        [HttpPost]
        [Route("AddClss")]
        public ActionResult<int> AddClss(Motorcade s)
        {
            db.classes.Add(s);
            return db.SaveChanges();

        }
        [HttpPost]
        [Route("DelClss")]
        //删除
        public ActionResult<int> DelClss(Motorcade s)
        {
            var stu = db.classes.Where(m => m.Mid == s.Mid).FirstOrDefault();
            db.classes.Remove(stu);
            return db.SaveChanges();

         
        }
        [HttpPost]
        [Route("EditClss")]
        //修改
        public ActionResult<int> EditClss([FromBody] Motorcade s)
        {
            db.Entry<Motorcade>(s).State = EntityState.Modified;
            return db.SaveChanges();

        }
    }
}
