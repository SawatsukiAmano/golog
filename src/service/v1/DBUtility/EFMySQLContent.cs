using IDBUnity;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class EFMySQLContent : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<Blog> Blog { get; set; }
        //[ConfigurationProperty("connectionString", DefaultValue = "", Options = System.Configuration.ConfigurationPropertyOptions.IsRequired)]
        //public string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("", new MySqlServerVersion(new Version(8, 0, 26)));
        }

        //创建时配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
