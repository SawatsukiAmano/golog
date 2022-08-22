namespace BLL.MySql
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
