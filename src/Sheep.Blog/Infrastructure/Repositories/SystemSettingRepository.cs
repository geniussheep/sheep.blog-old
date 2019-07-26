using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sheep.Blog.Infrastructure.Repositories.Interface;
using Sheep.Blog.Models.Entities;

namespace Sheep.Blog.Infrastructure.Repositories
{
    public partial class SystemSettingRepository : BaseRepository<SystemSetting>, ISystemSettingRepository
    {
        public SystemSettingRepository(DataContext dbContext) : base(dbContext)
        {
        }
    }
}
