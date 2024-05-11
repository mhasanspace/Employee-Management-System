using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Features.OrgDivision.Requests.Commands
{
    public class DeleteOrgDivisionCommand : IRequest
    {
        public int Id { get; set; }
    }
}
