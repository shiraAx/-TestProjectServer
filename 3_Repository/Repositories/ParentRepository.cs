using _3_Repository.Entities;
using _3_Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository.Repositories
{
    public class ParentRepository : IParentRepository
    {
        IDataSource _source;
        public ParentRepository(IDataSource source)
        {
            _source = source;
        }

        public async Task<Parent> Add(Parent model)
        {
            _source.Parents.Add(model);
            await _source.SaveChanges();
            return model;
        }

        public async Task Delete(string key)
        {
            _source.Parents.Remove(await GetById(key));
            await _source.SaveChanges();
        }

        public async Task<List<Parent>> GetAll()
        {
            return await _source.Parents.ToListAsync();
        }

        public async Task<Parent> GetById(string key)
        {
            return await _source.Parents.FirstOrDefaultAsync(k => k.ParentId == key);
        }

        public async Task<Parent> Update(Parent model)
        {
            var update = _source.Parents.Update(model).Entity;
            await _source.SaveChanges();
            return update;
        }
    }
}
