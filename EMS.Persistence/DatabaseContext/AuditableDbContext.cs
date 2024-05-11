using EMS.Common.EnumUtility;
using EMS.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Persistence.DatabaseContext
{
    public abstract class AuditableDbContext: DbContext
    {
        public AuditableDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual int SaveChanges(string userType = "SuperAdmin")
        {
            foreach (var entry in base.ChangeTracker.Entries<BaseModelEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entry.Entity.LastModifyDate = DateTime.Now;
                entry.Entity.LastModifyBy = userType;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreateDate = DateTime.Now;
                    entry.Entity.CreateBy = userType;
                }
            }

            var result = base.SaveChanges();

            return result;
        }
    }
}
