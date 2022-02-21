using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepositoryDB<T> where T:class,new()
    {
        int Add(T model);//添加
        int Modify(T model);//修改
        List<T> Query();//查询
    }
}
