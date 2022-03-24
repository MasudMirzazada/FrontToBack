using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboASP.Models;
 

namespace TurboASP.DAL
{
    public class TurboASPDbContext:DbContext
    {
        public TurboASPDbContext(DbContextOptions<TurboASPDbContext> options) : base(options){}
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
