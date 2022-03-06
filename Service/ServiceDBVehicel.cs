using Domain.OutPutModels;
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
    public class ServiceDBVehicel : IServiceDBVehicel
    {
        //连接仓储
        private readonly IRepositoryDB<CarMaintain> repositoryDBmaintain;
        private readonly IRepositoryDB<CarInsurance> repositoryDBinsurance;
        private readonly IRepositoryDB<CarService> repositoryDBservice;
        private readonly IRepositoryDB<CarBreak> repositoryDBbreak;
        //构造函数
        public ServiceDBVehicel(IRepositoryDB<CarMaintain> repositoryDBmaintain, IRepositoryDB<CarInsurance> repositoryDBinsurance, IRepositoryDB<CarService> repositoryDBservice, IRepositoryDB<CarBreak> repositoryDBbreak)
        {
            this.repositoryDBmaintain = repositoryDBmaintain;
            this.repositoryDBinsurance = repositoryDBinsurance;
            this.repositoryDBservice = repositoryDBservice;
            this.repositoryDBbreak = repositoryDBbreak;
        }
        //显示函数(车辆管理显示)
        public List<OutPutCar> GetVehicel()
        {
            var list = (from a in repositoryDBmaintain.Query()
                        join b in repositoryDBinsurance.Query() on a.TaskId equals b.TaskId
                        join c in repositoryDBservice.Query() on b.TaskId equals c.TaskId
                        join d in repositoryDBbreak.Query() on c.TaskId equals d.TaskId
                        select new OutPutCar
                        {
                            TaskId = a.TaskId,
                            carmaintain_Id = a.carmaintain_Id,
                            carmaintain_Cause = a.carmaintain_Cause,
                            carmaintain_Date = a.carmaintain_Date,
                            carmaintain_Km = a.carmaintain_Km,
                            carmaintain_Money = a.carmaintain_Money,
                            carmaintain_Name = a.carmaintain_Name,
                            carmaintain_Project = a.carmaintain_Project,
                            carmaintain_Remark = a.carmaintain_Remark,
                            carmaintain_Unit = a.carmaintain_Unit,
                            carinsutance_Bjdate = b.carinsutance_Bjdate,
                            carinsutance_Bkdate = b.carinsutance_Bkdate,
                            carinsutance_Danger = b.carinsutance_Danger,
                            carinsutance_Id = b.carinsutance_Id,
                            carinsutance_Jdate = b.carinsutance_Jdate,
                            carinsutance_Mdate = b.carinsutance_Mdate,
                            carinsutance_Name = b.carinsutance_Name,
                            carinsutance_Number = b.carinsutance_Number,
                            carinsutance_Price = b.carinsutance_Price,
                            carinsutance_Project = b.carinsutance_Project,
                            carinsutance_Seat = b.carinsutance_Seat,
                            carinsutance_Style = b.carinsutance_Style,
                            carinsutance_Zdate = b.carinsutance_Zdate,
                            carservice_Cdate = c.carservice_Cdate,
                            carservice_Id = c.carservice_Id,
                            carservice_Km = c.carservice_Km,
                            carservice_Money = c.carservice_Money,
                            carservice_Name = c.carservice_Name,
                            carservice_Project = c.carservice_Project,
                            carservice_Remark = c.carservice_Remark,
                            carservice_Trouble = c.carservice_Trouble,
                            carservice_Unit = c.carservice_Unit,
                            carservice_Wdate = c.carservice_Wdate,
                            carbreak_Cdate = d.carbreak_Cdate,
                            carbreak_Deduct = d.carbreak_Deduct,
                            carbreak_Driver = d.carbreak_Driver,
                            carbreak_Id = d.carbreak_Id,
                            carbreak_Name = d.carbreak_Name,
                            carbreak_Price = d.carbreak_Price,
                            carbreak_Rdate = d.carbreak_Rdate,
                            carbreak_Remark = d.carbreak_Remark,
                            carbreak_Shi = d.carbreak_Shi,
                            carbreak_Wdate = d.carbreak_Wdate,
                            key=a.carmaintain_Id
                        }).ToList();
            return list;
        }
    }
}
