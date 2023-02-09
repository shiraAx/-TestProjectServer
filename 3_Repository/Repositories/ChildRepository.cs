using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ChildRepository : IChildRepository
    {
        IDataSource _source;
        public ChildRepository(IDataSource source)
        {
            _source = source;
        }

        public async Task<Child> Add(Child model)
        {
           _source.Children.Add(model);
            await _source.SaveChanges();
            return model;   
        }

        public async Task Delete(string key)
        {
            _source.Children.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<Child>> GetAll()
        {
           return await _source.Children.ToListAsync();
        }

        public async Task<Child> GetById(string key)
        {
            return await _source.Children.FirstOrDefaultAsync(k => k.ChildId== key);
        }

        public async Task<Child> Update(Child model)
        {
            var update = _source.Children.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
