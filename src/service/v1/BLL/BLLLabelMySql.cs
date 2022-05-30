using IBLL;
using IDAL;
using IDAL.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLabelMySql : Base.BaseBLL<Model.Label>, IBLLLabel
    {
        private readonly IBaseDAL<Label> _dALLabel;
        public BLLLabelMySql(IDALLabel dal)
        {
            this._dALLabel = dal;
            base._baseDal = dal;
        }
    }
}
