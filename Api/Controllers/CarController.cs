using IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        //构造函数
        public CarController(IServiceDBCar serviceDBCar)
        {
            this.serviceDBCar = serviceDBCar;
        }
        /// <summary>
        /// 车辆保险添加函数
        /// </summary>
        /// <param name="carmaintain"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carmaintain")]
        public int CarmaintainAdd([FromBody]CarMaintain carmaintain)
        {
            return serviceDBCar.AddCarmaintain(carmaintain);
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
        /// 车辆违章添加函数
        /// </summary>
        /// <param name="carBreak"></param>
        /// <returns></returns>
        [HttpPost,Route("api/carbreak")]
        public int CarbreakAdd([FromBody] CarBreak carBreak)
        {
            return serviceDBCar.AddCarbreak(carBreak);
        }
    }
}
