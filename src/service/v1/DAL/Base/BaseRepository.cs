using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class BaseRepository<T> : IBaseRepository where T : class, new()
    {
    }
}
