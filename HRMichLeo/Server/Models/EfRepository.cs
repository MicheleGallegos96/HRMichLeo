using HRMichLeo.Server.Data;
using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;

namespace HRMichLeo.Server.Models
{
    public class EfRepository : IRepository
    {
        private ApplicationDbContext context;
        public EfRepository(ApplicationDbContext context) => this.context = context;
        public IQueryable<Sede> Sedi => context.Sedi;
    }
}
