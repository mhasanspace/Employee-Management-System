using EMS.Application.DTO.OrgDivision;
using EMS.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Features.OrgDivision.Requests.Commands
{
    public class CreateOrgDivisionCommand : IRequest<BaseCommandResponse>
    {
        public CreateOrgDivisionDto OrgDivisionDto { get; set; }
    }
}
