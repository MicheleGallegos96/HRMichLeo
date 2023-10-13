using HRMichLeo.Server.Data;
using HRMichLeo.Server.Interfaces;
using HRMichLeo.Server.Interfaces.Repository;
using HRMichLeo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace HRMichLeo.Server.Models
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ApplicationDbContext _dbcontext;
        public RepositoryBase(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

        public async Task Create(T entity)
        {
            await _dbcontext.Set<T>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbcontext.Update(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<T?> GetById(Guid id)
        {
            return await _dbcontext.Set<T>().FindAsync(id);
        }

        public async Task Delete(Guid id)
        {
            var result = await GetById(id);
            if (result != null)
            {
                _dbcontext.Set<T>().Remove(result);
                await _dbcontext.SaveChangesAsync();
            }
        }

    }
}
