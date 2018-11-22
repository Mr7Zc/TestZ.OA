using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.EFDAL;
using TestZ.OA.IDAL;

namespace TestZ.OA.DALFactory
{
   public  class DbSession :IDbSession
    {
        #region 简单工厂或抽象工厂部分
        public IUserInfoDal UserInfoDal
        {
            get { return StaticDalFactory.GetUserInfoDal(); }

        }
        public IOrderInfoDal OrderInfoDal
        {
            get { return StaticDalFactory.GetOrderInfoDal(); }
        }
        #endregion

        #region 拿到当前EF上下文，然后进行 把修改实体进行一个整体提交
        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
        #endregion
    }
}
