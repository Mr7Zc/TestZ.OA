using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.IDAL;
using TestZ.OA.Model;

namespace TestZ.OA.EFDAL
{
    public class UOrderInfoDal :BaseDal<UserInfo>,IUserInfoDal
    {
        public string  Name { get; set; }
        //DataModelContainer db = new DataModelContainer();
        ////crud
        //#region 查询
        ////public UserInfo GetUserInfoById(int id)
        ////{

        ////    return db.UserInfo.Find(id);
        ////}

        ////public List<UserInfo> GetUserInfosd()
        ////{

        ////    return db.UserInfo.ToList();
        ////}

        ////单元（方法）测试
        //public IQueryable<UserInfo> GetUsers(Expression<Func<UserInfo, bool>> whereLambda)
        //{

        //    return db.UserInfo.Where(whereLambda).AsQueryable();
        //}

        ////分页方法
        //public IQueryable<UserInfo> GetPageUsers<S>(int pageSize, int pageIndex, out int total, Expression<Func<UserInfo, bool>> whereLambda, Expression<Func<UserInfo, S>> orderByLambda, bool isAsc)
        //{
        //    total = db.UserInfo.Where(whereLambda).Count();

        //    if (isAsc)
        //    {
        //        var temp = db.UserInfo.Where(whereLambda)
        //              .OrderBy<UserInfo, S>(orderByLambda)
        //              .Skip(pageSize * (pageIndex - 1))
        //              .Take(pageSize).AsQueryable();
        //        return temp;
        //    }
        //    else
        //    {
        //        var temp = db.UserInfo.Where(whereLambda)
        //             .OrderByDescending<UserInfo, S>(orderByLambda)
        //             .Skip(pageSize * (pageIndex - 1))
        //             .Take(pageSize).AsQueryable();
        //        return temp;
        //    }

        //}
        //#endregion

        //#region cud
        //public UserInfo Add(UserInfo userInfo)
        //{

        //    db.UserInfo.Add(userInfo);
        //    db.SaveChanges();
        //    return userInfo;
        //}

        //public bool Update(UserInfo userInfo)
        //{
        //    db.Entry(userInfo).State = System.Data.Entity.EntityState.Modified;
        //    return db.SaveChanges() > 0;

        //}

        //public bool Delete(UserInfo userInfo)
        //{
        //    db.Entry(userInfo).State = System.Data.Entity.EntityState.Deleted;
        //    return db.SaveChanges() > 0;

        //}
        //#endregion


    }
}
