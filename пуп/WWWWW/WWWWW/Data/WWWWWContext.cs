using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WWWWW.models;

namespace WWWWW.Data
{
    public class WWWWWContext : DbContext
    {
        public WWWWWContext (DbContextOptions<WWWWWContext> options)
            : base(options)
        {
        }

        public DbSet<WWWWW.models.User> User { get; set; } = default!;
        public DbSet<WWWWW.models.Service> Service { get; set; } = default!;
        public DbSet<WWWWW.models.Request> Request { get; set; } = default!;
        public DbSet<WWWWW.models.Employee> Employee { get; set; } = default!;
    }
}
