using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 文章表
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// 文章id
        /// </summary>
        public int BlogId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 文章名
        /// </summary>
        public string BlogName { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 第一次发布时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后一次发布时间
        /// </summary>
        public DateTime LatestTime { get; set; }
        /// <summary>
        /// 最后次编辑的文本
        /// </summary>
        public string CurrEditTxt { get; set; }
        /// <summary>
        ///显示的文本
        /// </summary>
        public string ViewTxt { get; set; }
    }
}
