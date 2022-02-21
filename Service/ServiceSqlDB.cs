using Context;
using Domain;
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
        public int Login(InputLogin model)
        {
            var obj = db.User.FirstOrDefault(x => x.user_Account == model.user_Account && x.user_Password == model.user_Password);
            if (obj != null)
            {
                return obj.user_Id;
            }
            else
            {
                return 0;
            }
        }
    }
}
