using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRes
{
    public class user
    {
        public int user_id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string acc { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public int pwd { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string nick_name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string eamil { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        public string vx_id { get; set; }
        /// <summary>
        /// GithubID
        /// </summary>
        public string git_id { get; set; }
        /// <summary>
        /// QQId
        /// </summary>
        public string qq_id { get; set; }
    }

    public class login_user
    {
        public string user_id { get; set; }
        public string pwd { get; set; }
    }
}
