using _3_Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Interfaces
{
    public interface IDataSource
    {

        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
     //   Task<int> SaveChanges();
        Task<int> SaveChanges(CancellationToken cancellationToken = default(CancellationToken));


    }
}
