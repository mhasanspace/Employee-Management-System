using EMS.Application.DTO.OrgDivision;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Features.OrgDivision.Requests.Commands
{
    public class UpdateOrgDivisionCommand : IRequest<Unit>
    {
        public UpdateOrgDivisionDto UpdateOrgDivisionDto { get; set; }
    }
}
