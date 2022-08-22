using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 标签表
    /// </summary>
    public class Label
    {
        public int LabelId { get; set; }
        /// <summary>
        /// 标签名
        /// </summary>
        public string LabelName { get; set; }
        /// <summary>
        /// 文章id
        /// </summary>
        public int BlogId { get; set; }
        /// <summary>
        /// 文章名称
        /// </summary>
        public string BlogName { get; set; }
    }
}
