using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.EFDAL;
using TestZ.OA.IDAL;

namespace TestZ.OA.DALFactory
{
    public class StaticDalFactory
    {
        public static IUserInfoDal GetUserInfoDal()
        {
            //return new UOrderInfoDal();

            //把上面的new去掉，希望改一个配置那么创建实例就发生变化，不需要改代码
            return Assembly.Load("TestZ.OA.EFDAL").CreateInstance("TestZ.OA.EFDAL.UserInfoDal")
                as IUserInfoDal;
        }
        public static IOrderInfoDal GetOrderInfoDal()
        {
            return new OrderInfoDal();
        }
    }
}
