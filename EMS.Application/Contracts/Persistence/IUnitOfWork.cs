using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EMS.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IOrgDivisionRepository OrgDivisionRepository { get; }

        void Save();
        
    }
}
