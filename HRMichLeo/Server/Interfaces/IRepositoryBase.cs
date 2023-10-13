using HRMichLeo.Shared.Models;

namespace HRMichLeo.Server.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {

        public Task<IEnumerable<T>> GetAll();
        public Task Create(T entity);
        public Task Update(T entity);
        public Task<T?> GetById(Guid id);
        public Task Delete(Guid id);
    }
}
