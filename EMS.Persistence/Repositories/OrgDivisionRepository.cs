using EMS.Application.Contracts.Persistence;
using EMS.Domain.Models;
using EMS.Persistence.DatabaseContext;

namespace EMS.Persistence.Repositories
{
    public class OrgDivisionRepository : GenericRepository<OrgDivision>, IOrgDivisionRepository
    {
        private readonly EmsDbContext _dbContext;
        public OrgDivisionRepository(EmsDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
