using EAndSSolutions.Model.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAndSSolutions.Entity.Context
{
    public class EAndSSolutionsContext : DbContext
    {
        public EAndSSolutionsContext(DbContextOptions<EAndSSolutionsContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "System",
                    LastName = "",
                    UserName = "System@gmail.com",
                    Password = "System@1234",
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now
                }
            );
        }
    }
}
