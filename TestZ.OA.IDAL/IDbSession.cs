﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZ.OA.IDAL
{
    public interface IDbSession
    {
        IUserInfoDal UserInfoDal { get; }
        IOrderInfoDal OrderInfoDal { get; }

        int SaveChanges();
    }
}
