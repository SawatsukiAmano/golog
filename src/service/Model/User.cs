using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("user")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        public string VXId { get; set; }
        /// <summary>
        /// GithubID
        /// </summary>
        public string GitId { get; set; }
        /// <summary>
        /// QQId
        /// </summary>
        public string QQId { get; set; }

    }
}
