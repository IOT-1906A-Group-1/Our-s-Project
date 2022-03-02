using Context;
using Domain;
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
    public class ServiceSqlDB: IServiceDB
    {
        public IRepositoryDB<BPMSysOUMembers> repositoryOUMembers;
        public IRepositoryDB<BPMSysOUs> repositoryOUs;
        public IRepositoryDB<BPMSysOURoles> repositoryOURoles;
        public Db_Context db;
        public ServiceSqlDB(Db_Context db, IRepositoryDB<BPMSysOUMembers> repositoryOUMembers, IRepositoryDB<BPMSysOUs> repositoryOUs, IRepositoryDB<BPMSysOURoles> repositoryOURoles)
        {
            this.repositoryOURoles = repositoryOURoles;
            this.repositoryOUMembers = repositoryOUMembers;
            this.repositoryOUs = repositoryOUs;
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
        //查询部门
        public List<BPMSysOUs> QueryOUs()
        {
            return repositoryOUs.Query();
        }
        //查询成员
        public List<BPMSysOUMembers> QueryOUMembers()
        {
            return repositoryOUMembers.Query();
        }
        //查询角色
        public List<BPMSysOURoles> QueryOURoles()
        {
            return repositoryOURoles.Query();
        }
    }
}
