using Context;
using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class CarController : ControllerBase
    {
        //连接服务
        private readonly IServiceDBCar serviceDBCar;
        private readonly IServiceDBVehicel serviceDBVehicel;
        private readonly Db_Context db_Context;
        //构造函数
        public CarController(IServiceDBCar serviceDBCar, IServiceDBVehicel serviceDBVehicel, Db_Context db_Context)
        {
            this.serviceDBCar = serviceDBCar;
            this.serviceDBVehicel = serviceDBVehicel;
            this.db_Context = db_Context;
        }
        /// <summary>
        /// 车辆保养添加函数
        /// </summary>
        /// <param name="carmaintain"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carmaintain")]
        public int CarmaintainAdd([FromBody]CarMaintain carmaintain)
        {
            return serviceDBCar.AddCarmaintain(carmaintain);
        }
        /// <summary>
        /// 车辆保养删除函数
        /// </summary>
        /// <returns></returns>
        [HttpDelete,Route("api/carmaintaindelete")]
        public int CarmaintainDelete(int id)
        {
            var list = db_Context.CarMaintain.Find(id);
            if (list!=null)
            {
                db_Context.CarMaintain.Remove(list);
                return db_Context.SaveChanges();
            }
            return 0;
        }
        /// <summary>
        /// 车辆保养反填函数
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("api/carmaintainfirst")]
        public ActionResult CarmaintainFirst(int id)
        {
            var list = db_Context.CarMaintain.Find(id);
            return Ok(list);
        }
        /// <summary>
        /// 车辆保养修改函数
        /// </summary>
        /// <param name="carMaintain"></param>
        /// <returns></returns>
        [HttpPut,Route("api/carmaintainupdate")]
        public int CarmaintainUpdate(CarMaintain carMaintain)
        {
            db_Context.CarMaintain.Attach(carMaintain);
            db_Context.Entry(carMaintain).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db_Context.SaveChanges();
        }
        /// <summary>
        /// 车辆保养查询函数
        /// </summary>
        /// <returns></returns>
        [HttpGet,Route("api/carmaintainshow")]
        public ActionResult CarmaintainShow(string Name,string Kdate,string Jdate )
        {
            var list = db_Context.CarMaintain.ToList();
            if (Name!=null)
            {
                list = list.Where(x => x.carmaintain_Name.Contains(Name)).ToList();
            }
            if (Kdate!=null && Jdate!=null)
            {
                var kai=Convert.ToDateTime(Kdate);
                var jie = Convert.ToDateTime(Jdate);
                list = list.Where(x => x.carmaintain_Date >= kai && x.carmaintain_Date <= jie).ToList();
            }
            return Ok(list);
        }
        /// <summary>
        /// 车辆保险添加函数
        /// </summary>
        /// <param name="carInsurance"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carinsurance")]
        public int CarinsuranceAdd([FromBody] CarInsurance carInsurance)
        {
            return serviceDBCar.AddCarinsurance(carInsurance);
        }
        /// <summary>
        /// 车辆保险删除函数
        /// </summary>
        /// <returns></returns>
        [HttpDelete, Route("api/carinsurancedelete")]
        public int CarinsuranceDelete(int id)
        {
            var list = db_Context.CarInsurance.Find(id);
            if (list != null)
            {
                db_Context.CarInsurance.Remove(list);
                return db_Context.SaveChanges();
            }
            return 0;
        }
        /// <summary>
        /// 车辆保险反填函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carinsurancefirst")]
        public ActionResult CarinsuranceFirst(int id)
        {
            var list = db_Context.CarInsurance.Find(id);
            return Ok(list);
        }
        /// <summary>
        /// 车辆保险修改函数
        /// </summary>
        /// <param name="CarInsurance"></param>
        /// <returns></returns>
        [HttpPut, Route("api/carinsuranceupdate")]
        public int CarinsuranceUpdate(CarInsurance carInsurance)
        {
            db_Context.CarInsurance.Attach(carInsurance);
            db_Context.Entry(carInsurance).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db_Context.SaveChanges();
        }
        /// <summary>
        /// 车辆保险查询函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carinsuranceshow")]
        public ActionResult CarinsuranceShow(string Name, string Kdate, string Jdate)
        {
            //var a = new DateTime(Convert.ToInt32(Date));
            //var b=a.da
            var list = db_Context.CarInsurance.ToList();
            if (Name != null)
            {
                list = list.Where(x => x.carinsutance_Name.Contains(Name)).ToList();
            }
            if (Kdate != null && Jdate != null)
            {
                var kai = Convert.ToDateTime(Kdate);
                var jie = Convert.ToDateTime(Jdate);
                list = list.Where(x => x.carinsutance_Jdate >= kai && x.carinsutance_Jdate <= jie).ToList();
            }
            return Ok(list);
        }
        /// <summary>
        /// 车辆维修添加函数
        /// </summary>
        /// <param name="carService"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carservice")]
        public int CarserviceAdd([FromBody] CarService carService)
    {
            return serviceDBCar.AddCarservice(carService);
        }
        /// <summary>
        /// 车辆维修删除函数
        /// </summary>
        /// <returns></returns>
        [HttpDelete, Route("api/carservicedelete")]
        public int CarserviceDelete(int id)
        {
            var list = db_Context.CarService.Find(id);
            if (list == null)
            {
                db_Context.CarService.Remove(list);
                return db_Context.SaveChanges();
            }
            return 0;
        }
        /// <summary>
        /// 车辆维修反填函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carservicefirst")]
        public ActionResult CarserviceFirst(int id)
        {
            var list = db_Context.CarService.Find(id);
            return Ok(list);
        }
        /// <summary>
        /// 车辆维修修改函数
        /// </summary>
        /// <param name="CarService"></param>
        /// <returns></returns>
        [HttpPut, Route("api/carserviceupdate")]
        public int CarserviceUpdate(CarService carService)
        {
            db_Context.CarService.Attach(carService);
            db_Context.Entry(carService).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db_Context.SaveChanges();
        }
        /// <summary>
        /// 车辆维修查询函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carserviceshow")]
        public ActionResult CarserviceShow(string Name, string Kdate,string Jdate)
        {
            var list = db_Context.CarService.ToList();
            if (Name != null)
            {
                list = list.Where(x => x.carservice_Name.Contains(Name)).ToList();
            }
            if (Kdate!=null && Jdate!=null)
            {
                var kai = Convert.ToDateTime(Kdate);
                var jie = Convert.ToDateTime(Jdate);
                list = list.Where(x => x.carservice_Cdate >= kai && x.carservice_Cdate <= jie).ToList();
            }
            return Ok(list);
        }
        /// <summary>
        /// 车辆违章添加函数
        /// </summary>
        /// <param name="carBreak"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carbreak")]
        public int CarbreakAdd([FromBody] CarBreak carBreak)
        {
            return serviceDBCar.AddCarbreak(carBreak);
        }
        /// <summary>
        /// 车辆违章删除函数
        /// </summary>
        /// <returns></returns>
        [HttpDelete, Route("api/carbreakdelete")]
        public int CarbreakDelete(int id)
        {
            var list = db_Context.CarBreak.Find(id);
            if (list!=null)
            {
                db_Context.CarBreak.Remove(list);
                return db_Context.SaveChanges();
            }
            return 0;
        }
        /// <summary>
        /// 车辆违章反填函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carbreakfirst")]
        public ActionResult CarbreakFirst(int id)
        {
            var list = db_Context.CarBreak.Find(id);
            return Ok(list);
        }
        /// <summary>
        /// 车辆违章修改函数
        /// </summary>
        /// <param name="CarBreak"></param>
        /// <returns></returns>
        [HttpPut, Route("api/carbreakupdate")]
        public int CarbreakUpdate(CarBreak carBreak)
        {
            db_Context.CarBreak.Attach(carBreak);
            db_Context.Entry(carBreak).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db_Context.SaveChanges();
        }
        /// <summary>
        /// 车辆违章查询函数
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/carbreakshow")]
        public ActionResult CarbreakShow(string Name, string Kdate,string Jdate)
        {
            var list = db_Context.CarBreak.ToList();
            if (Name != null)
            {
                list = list.Where(x => x.carbreak_Name.Contains(Name)).ToList();
            }
            if (Kdate!=null && Jdate!=null)
            {
                var kai = Convert.ToDateTime(Kdate);
                var jie = Convert.ToDateTime(Jdate);
                list = list.Where(x => x.carbreak_Rdate >= kai && x.carbreak_Rdate <= jie).ToList();
            }
            return Ok(list);
        }
        ///// <summary>
        ///// 车辆显示函数（联查）
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet,Route("api/vehicel")]
        //public ActionResult AllVehicel()
        //{
        //    var list = serviceDBVehicel.GetVehicel();
        //    return Ok(list);
        //}
    }
}
