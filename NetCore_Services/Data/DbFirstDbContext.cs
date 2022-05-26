using Microsoft.EntityFrameworkCore;
using NetCore.Data.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.Data
{
    public class DbFirstDbContext : DbContext
    {

        // DB테이블 리스트 지정
        public DbSet<Practice1_User> users { get; set; }
        public DbSet<Practice1_UserRole> UserRoles { get; set; }

        public DbFirstDbContext(DbContextOptions<DbFirstDbContext> options) : base(options)
        { 
        }

        // virtual
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<Practice1_User>().ToTable(name: "practice_1.practice1_user");
        }
    }
}
