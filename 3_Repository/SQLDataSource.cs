using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository
{
    public class SQLDataSource : DbContext, IDataSource
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER001\\Documents\\newDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        public async Task<int> SaveChanges(CancellationToken cancellationToken = default)
        {
             return base.SaveChanges(); 
        }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set;}
    }
}
