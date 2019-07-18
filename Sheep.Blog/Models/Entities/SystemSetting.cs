using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Sheep.Blog.Definitions;

namespace Sheep.Blog.Models.Entities
{
    /// <summary>
    /// 系统设置
    /// </summary>
    [Table("SystemSetting")]
    public class SystemSetting : BaseEntity
    {
        public SystemSetting()
        {
            DataStatus = DataStatus.Available;
        }
        /// <summary>
        /// 参数项名
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [Required]
        public string Value { get; set; }

    }
}
