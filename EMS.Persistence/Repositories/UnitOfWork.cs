using EMS.Application.Constants;
using EMS.Application.Contracts.Persistence;
using EMS.Persistence.DatabaseContext;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmsDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IOrgDivisionRepository _orgDivisionRepository;

        public UnitOfWork(EmsDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            this._httpContextAccessor = httpContextAccessor;
        }

        public IOrgDivisionRepository OrgDivisionRepository => _orgDivisionRepository ??= new OrgDivisionRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            var userType = _httpContextAccessor.HttpContext.User.FindFirst(CustomClaimTypes.Uid)?.Value;

           _context.SaveChanges(userType);
        }


    }
}
