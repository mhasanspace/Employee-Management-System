using EMS.Application.DTO.OrgDivision;
using MediatR;

namespace EMS.Application.Features.OrgDivision.Requests.Queries
{
    public class GetOrgDivisionDetailRequest : IRequest <OrgDivisionDto>
    {
        public int Id { get; set; }
    }
}
