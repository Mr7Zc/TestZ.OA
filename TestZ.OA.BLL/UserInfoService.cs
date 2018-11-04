using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.DALFactory;
using TestZ.OA.EFDAL;
using TestZ.OA.IDAL;
using TestZ.OA.Model;

namespace TestZ.OA.BLL
{
    //模块内高内聚，模块间低耦合

   //变化点：1 跨数据库 2数据库访问驱动层驱动变化 
    //crud
    public class UserInfoService
    {
        //依赖接口编程
        //IUserInfoDal UserInfoDal = new UserInfoDal();

        //IUserInfoDal UserInfoDal = StaticDalFactory.GetUserInfoDal();
        DbSession dbSession = new DbSession();

        //更高级 IOC DI依赖注入的方式 string.net

        public UserInfo Add(UserInfo  userInfo) //单元工作模式
        {

            //return UserInfoDal.Add(userInfo);
            dbSession.UserInfoDal.Add(userInfo);
                        
            dbSession.SaveChanges();   //数据提交的权利从数据库访问层提到了逻辑层
        }
    }
}
