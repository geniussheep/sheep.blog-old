using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Sheep.Blog.Definitions;

namespace Sheep.Blog.Models.Entities
{
    public class BaseEntity 
    {
        [DefaultValue(DataStatus.Default)]
        public DataStatus DataStatus { get; set; }
    }
}
