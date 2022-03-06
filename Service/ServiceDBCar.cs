using IRepository;
using IService;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceDBCar : IServiceDBCar
    {
        //连接仓储
        private readonly IRepositoryDB<CarMaintain> repositorydbcarmaintain;
        private readonly IRepositoryDB<CarInsurance> repositorydbcarinsurance;
        private readonly IRepositoryDB<CarService> repositorydbcarservice;
        private readonly IRepositoryDB<CarBreak> repositorydbcarbreak;
        //构造函数
        public ServiceDBCar(IRepositoryDB<CarMaintain> repositorydbcarmaintain, IRepositoryDB<CarInsurance> repositorydbcarinsurance, IRepositoryDB<CarService> repositorydbcarservice, IRepositoryDB<CarBreak> repositorydbcarbreak)
        {
            this.repositorydbcarmaintain = repositorydbcarmaintain;
            this.repositorydbcarinsurance = repositorydbcarinsurance;
            this.repositorydbcarservice = repositorydbcarservice;
            this.repositorydbcarbreak = repositorydbcarbreak;
        }
        /// <summary>
        /// 车辆违章添加
        /// </summary>
        /// <param name="carBreak"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int AddCarbreak(CarBreak carBreak)
        {
            return repositorydbcarbreak.Add(carBreak);
        }
        /// <summary>
        /// 车辆保养添加
        /// </summary>
        /// <param name="carmaintain"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int AddCarmaintain(CarMaintain carmaintain)
        {
            return repositorydbcarmaintain.Add(carmaintain);
        }
        /// <summary>
        /// 车辆维修添加
        /// </summary>
        /// <param name="carService"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int AddCarservice(CarService carService)
        {
            return repositorydbcarservice.Add(carService);
        }
        /// <summary>
        /// 车辆保险添加
        /// </summary>
        /// <param name="carInsurance"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int AddCarinsurance(CarInsurance carInsurance)
        {
            return repositorydbcarinsurance.Add(carInsurance);
        }
    }
}
