using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestZ.OA.Model;

namespace TestZ.OA.EFDAL
{
    public class DbContextFactory
    {
      public static  DbContext GetCurrentDbContext()
        {
            //一次请求共用一个实例  上下文都可以切换
            return new DataModelContainer();

        }
    }
}
