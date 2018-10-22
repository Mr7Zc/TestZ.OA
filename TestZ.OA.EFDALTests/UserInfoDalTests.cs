using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestZ.OA.EFDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.Model;

namespace TestZ.OA.EFDAL.Tests
{
    [TestClass()]
    public class UserInfoDalTests
    {
        [TestMethod()]
        public void GetUserInfoByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserInfosdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUsersTest()
        {
            //测试 获取数据方法
            IUserInfoDal dal = new IUserInfoDal();
            //单元测试必须自己处理数据，不能依赖第三方数据，如果依赖那么先自己创建数据，然后在用完之后，再清楚数据。

            //创建测试数据
            for (int i = 0; i < 10; i++)
            {
                dal.Add(new UserInfo()
                {
                    UName = i + "ssz"

                });
            }
            IQueryable<UserInfo> temp = dal.GetEntities(u => u.UName.Contains("sz"));

            //断言
            Assert.AreEqual(true, temp.Count() >= 10);

        }

        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}