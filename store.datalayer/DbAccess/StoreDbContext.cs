using Microsoft.EntityFrameworkCore;
using store.datalayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.datalayer.DbAccess
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { 

        }

        public DbSet<Role> Role { get; set; }

        public DbSet<UserInfo> UserInfo { get; set; }

        public DbSet<Product> Product { get; set; }

    }
}
