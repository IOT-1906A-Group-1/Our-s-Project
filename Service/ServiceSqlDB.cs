using Context;
using Domain;
using Domain.OutPutModels;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceSqlDB: IServiceDB
    {
        public Db_Context db;
        public ServiceSqlDB(Db_Context db)
        {
            this.db = db;
        }

        //登录
        public string Login(InputLogin model)
        {
            var obj = db.BPMSysUsers.FirstOrDefault(x => x.Account == model.user_Account && x.Password == model.user_Password);
            if (obj != null)
            {
                return obj.DisplayName;
            }
            else
            {
                return null;
            }
        }
    }
}
