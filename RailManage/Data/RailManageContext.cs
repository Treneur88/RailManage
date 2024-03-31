using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RailManage.Models;

namespace RailManage.Data
{
    public class RailManageContext : DbContext
    {
        public RailManageContext (DbContextOptions<RailManageContext> options)
            : base(options)
        {
        }

        public DbSet<RailManage.Models.Train> Train { get; set; } = default!;
    }
}
