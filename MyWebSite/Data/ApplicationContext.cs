using Microsoft.EntityFrameworkCore;
using MyWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options)
        {

        }
        public DbSet<UserName> UserName { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder) //指定生成数据库中表的名字
        //{
        //    modelBuilder.Entity<Users>().ToTable("User");
        //    modelBuilder.Entity<Test>().ToTable("Test");
        //    modelBuilder.Entity<Admin>().ToTable("Admin");
        //}
    }
}
