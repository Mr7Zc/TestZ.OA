using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.IDAL;

namespace TestZ.OA.BLL
{

    public class BaseService<T> where T:class  ,new()
    {
        public IBaseDal<T> CurrentDal { get; set; }

        #region 查询
        //单元（方法）测试
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda);


        //分页方法
        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc);

        #endregion

        #region cud
        public T Add(T entitiy)
        {
            return CurrentDal.Add(entitiy);
        }

        bool Update(T entity)
        {
          return CurrentDal.Update(entity);
        }


        bool Delete(T entity)
        {
            return CurrentDal.Delete(entity);
        }

        #endregion
    }
}
