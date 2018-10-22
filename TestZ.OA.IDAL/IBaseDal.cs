using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestZ.OA.IDAL
{
    public interface IBaseDal<T> where T :class ,new()
    {

        //crud
        #region 查询
        //单元（方法）测试
        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda);


        //分页方法
        IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc);

        #endregion

        #region cud
        T Add(T entitiy);

        bool Update(T entity);


        bool Delete(T entity);
     
        #endregion
    }
}
