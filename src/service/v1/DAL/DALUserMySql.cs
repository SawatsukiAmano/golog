﻿using IDAL;
using DBUtility;
using Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL
{
    public class DALUserMySql : Base.DALBaseMysql<User>, IDALUser
    {
      
    }
}
