using DBUtility.Base;
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
    public class EFMySqlContent<T> : DbContext, IBaseUtility<T> where T : class, new()
    {
        public DbSet<User> User { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public bool AddOne(T model)
        {
            throw new NotImplementedException();
        }

        public T FindOne(Expression<Func<T, bool>> expression)
        {
            using (var db = new EFMySqlContent<T>())
            {
                return db.Set<T>().FirstOrDefault(expression);
            }
        }

        public T GetOneById(object id)
        {
            throw new NotImplementedException();
        }

        public T Where(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }


        //[ConfigurationProperty("connectionString", DefaultValue = "", Options = System.Configuration.ConfigurationPropertyOptions.IsRequired)]
        //public string ConnectionString { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql("server=42.193.14.174;user id=root;password=Admin@123;database=golog;Character Set=utf8", new MySqlServerVersion(new Version(8, 0, 26)));
        }

        //创建时配置
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
