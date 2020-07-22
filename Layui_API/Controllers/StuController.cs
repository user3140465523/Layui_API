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
    [EnableCors("cors")] //设置跨域处理的代理
    public class StuController : ControllerBase
    {
        public DBContext db;

        public StuController(DBContext db)
        {
            this.db = db;
        }

      
        //显示
        [HttpGet]
        [Route("GetStu")]
        public ActionResult<Response> GetStu(int page,int limit,int mid=0,string vName = "")
        {
            var linq = (from s in db.students
                        join c in db.classes on s.Mid equals c.Mid
                        select new Show()
                        {
                            Mid = c.Mid,
                            MName = c.MName,
                            VName = s.VName,
                            VLicense = s.VLicense,
                            VehiclePrices = s.VehiclePrices,
                            Vcolor = s.Vcolor,
                            VehicleFuel = s.VehicleFuel,
                            Emission = s.Emission,
                            VehicleStructure = s.VehicleStructure,
                            Vid = s.Vid
                        }).ToList();
            if (mid != 0)
            {
                linq = linq.Where(m => m.Mid == mid).ToList();
            }
            if (vName == null)
            {
                vName = "";
            }
            linq = linq.Where(m => m.VName.Contains(vName)).ToList();
            int num = linq.Count;
            linq = linq.OrderByDescending(m => m.Vid).Skip((page - 1) * limit).Take(limit).ToList();
            return new Response() { code = 0, msg = "", data = linq, count = num };
            //var linq = (from s in db.students
            //           join c in db.classes on s.CId equals c.CId
            //           select new Show() { 
            //            CId=c.CId,
            //            CName=c.CName,
            //            Name=s.Name,
            //            Sex=s.Sex,
            //            SId=s.SId                      
            //           }).ToList();
            //if (cId!=0)
            //{
            //    linq = linq.Where(m => m.CId == cId).ToList();
            //}
            //if (name==null)
            //{
            //    name = "";
            //}
            //linq = linq.Where(m => m.Name.Contains(name)).ToList();
            //int num = linq.Count;
            //linq = linq.OrderByDescending(m=>m.SId).Skip((page - 1) * limit).Take(limit).ToList();
            //return new Response() {code=0,msg="", data = linq, count = num };
        }
        //添加
        [HttpPost]
        [Route("AddStu")]
        public ActionResult<int> AddStu(Vehicle s)
        {
            db.students.Add(s);
            return db.SaveChanges();

        }
        [HttpPost]
        [Route("DelStu")]
        //删除
        public ActionResult<int> DelStu(Vehicle s) 
        {
            var stu = db.students.Where(m => m.Vid == s.Vid).FirstOrDefault();
            db.students.Remove(stu);
            return db.SaveChanges();

            //var stu = db.students.Where(m => m.SId == s.SId).FirstOrDefault();
            //db.students.Remove(stu);
            //return db.SaveChanges();
        }
        [HttpPost]
        [Route("EditStu")]
        //修改
        public ActionResult<int> EditStu([FromBody] Vehicle s)
        {
            db.Entry<Vehicle>(s).State = EntityState.Modified;
            return db.SaveChanges();

        }
        [HttpGet]
        [Route("GetClass")]
        //绑定下拉
        public List<Motorcade> GetClass()
        {
            return db.classes.ToList();
        }
    }
}
