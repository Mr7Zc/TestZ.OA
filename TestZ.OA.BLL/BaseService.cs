using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.DALFactory;
using TestZ.OA.IDAL;

namespace TestZ.OA.BLL
{
    /// <summary>
    /// 父类逼迫自己给父类的一个属性赋值
    /// 赋值的操作必须在父类的方法调用之前先执行
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseService<T> where T:class  ,new()
    {
        public IBaseDal<T> CurrentDal { get; set; }

        public IDbSession dbSession
        {
            get
            {
                return DbSessionFactory.GetCurrentDbSession();
            }
        } 

        public BaseService()//基类的构造函数
        {
            SetCurrentDal();//抽象方法
        }
        public abstract void SetCurrentDal(); //抽象方法：要求子类必须实现

        DbSession dbsession = new DbSession();


        #region 查询
        //单元（方法）测试
       public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.GetEntities(whereLambda);
        }


        //分页方法
        public IQueryable<T> GetPageEntities<S>(int pageSize, int pageIndex, out int total, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc)
        {
            return CurrentDal.GetPageEntities(pageSize, pageIndex, out total, whereLambda, orderByLambda, isAsc);
        }

        #endregion


        #region cud
        public T Add(T entitiy)
        {

            CurrentDal.Add(entitiy);
            dbSession.SaveChanges();
            return entitiy;
        }

        bool Update(T entity)
        {
          CurrentDal.Update(entity);
            return dbSession.SaveChanges() > 0;
        }


        bool Delete(T entity)
        {
            CurrentDal.Delete(entity);
            return dbSession.SaveChanges() > 0;
        }

        #endregion
    }
}
