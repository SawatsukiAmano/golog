using CommonHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class EFMySqlContent : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<Blog> Blog { get; set; }

        //[ConfigurationProperty("connectionString", DefaultValue = "", Options = System.Configuration.ConfigurationPropertyOptions.IsRequired)]
        //public string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string str = Appsettings.GetValue("ConnectionStrings:LocalConnection");
            optionsBuilder.UseMySql(str, new MySqlServerVersion(new Version(8, 0, 24)));
        }

        //创建时配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
