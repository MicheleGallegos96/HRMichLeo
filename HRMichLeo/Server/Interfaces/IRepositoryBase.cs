using HRMichLeo.Shared.Models;

namespace HRMichLeo.Server.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        public IQueryable<T> Sedi { get; }

    }
}
