using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Sheep.Blog.Definitions;
using Sheep.Blog.Models.Validation;

namespace Sheep.Blog.Models.Entities
{
    /// <summary>
    /// 订阅表
    /// </summary>
    [Table("Broadcast")]
    public class Broadcast : BaseEntity
    {
        public Broadcast()
        {
            DataStatus = DataStatus.Subscribing;
            UpdateTime = DateTime.Now;
        }

        /// <summary>
        /// 订阅接收邮箱
        /// </summary>
        [IsEmail]
        public string Email { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string ValidateCode { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 订阅类型
        /// </summary>
        public SubscribeType SubscribeType { get; set; }
    }
}
