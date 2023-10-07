using HRMichLeo.Shared.Models;

namespace HRMichLeo.Server.Interfaces
{
    public interface IRepository
    {
        public IQueryable<Sede> Sedi { get; }

    }
}
