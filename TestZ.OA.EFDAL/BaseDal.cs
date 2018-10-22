using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.Model;

namespace TestZ.OA.EFDAL
{
    /// <summary>
    /// 职责：封装所有的dal的公共的crud的方法
    /// </summary>
    public class BaseDal<T> where T:class ,new ()
    {
        DataModelContainer db = new DataModelContainer();
        //crud
        #region 查询
        //单元（方法）测试
        public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda)
        {

            return db.Set<T>().Where(whereLambda).AsQueryable();
        }

        //分页方法
        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc)
        {
            total = db.Set<T>().Where(whereLambda).Count();

            if (isAsc)
            {
                var temp = db.Set<T>().Where(whereLambda)
                      .OrderBy<T, S>(orderByLambda)
                      .Skip(pageSize * (pageIndex - 1))
                      .Take(pageSize).AsQueryable();
                return temp;
            }
            else
            {
                var temp = db.Set<T>().Where(whereLambda)
                     .OrderByDescending<T, S>(orderByLambda)
                     .Skip(pageSize * (pageIndex - 1))
                     .Take(pageSize).AsQueryable();
                return temp;
            }

        }
        #endregion

        #region cud
        public T Add(T entitiy)
        {

            db.Set<T>().Add(entitiy);
            db.SaveChanges();
            return entitiy;
        }

        public bool Update(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;

        }

        public bool Delete(T entity)
        {
            db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            return db.SaveChanges() > 0;

        }
        #endregion
    }
}
