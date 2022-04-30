using Microsoft.EntityFrameworkCore;

using MultDataSaveDemo.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultDataSaveDemo.DAL
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(
           DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          
        }
    }
}
