using Microsoft.EntityFrameworkCore;
using NetCore.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.Data
{
    // Fluent API
    // 상속
    public class CodeFirstDbContext : DbContext
    {
        // 생성자 상속
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {
        }

        // DB테이블 리스트 지정
        public DbSet<Practice1_User> users { get; set; }
        public DbSet<Practice1_UserRole> UserRoles { get; set; }
        // public DbSet<Practice1_UserRolesByUser> UserRolesByUsers { get; set; }

        // 메서드 상속 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            // 4가 작업 필요

            // 1.DB테이블이름 변경
            modelBuilder.Entity<Practice1_User>().ToTable(name: "User");
            modelBuilder.Entity<Practice1_UserRole>().ToTable(name: "UserRole");
            // modelBuilder.Entity<Practice1_UserRolesByUser>().ToTable(name: "UserRolesByUser");

            // 2. 복합키 지정
            // modelBuilder.Entity<Practice1_UserRolesByUser>().HasKey(c => new { c.UserId, c.RoleId});

            // 3. 컬럼 기본값 지정
            modelBuilder.Entity<Practice1_User>(e =>
            {
                e.Property(c => c.IsMembershipWithdrawn).HasDefaultValue(value: false);
            });

            // 4.인덱스 지정
            modelBuilder.Entity<Practice1_User>().HasIndex(c => new { c.UserEmail });
        }
    }
}
