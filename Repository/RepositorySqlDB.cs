using Context;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositorySqlDB<T> : IRepositoryDB<T> where T : class, new()
    {
        public Db_Context db;
        public RepositorySqlDB(Db_Context db)
        {
            this.db = db;
        }
        public int Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges();
        }

        //public T FirstorDefault(Expression<Func<T, bool>> expression)
        //{
        //    return db.Set<T>().FirstOrDefault(expression);
        //}

        public int Modify(T model)
        {
            db.Set<T>().Attach(model);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }

        public List<T> Query()
        {
            return db.Set<T>().AsQueryable<T>().ToList();
        }
    }
}
