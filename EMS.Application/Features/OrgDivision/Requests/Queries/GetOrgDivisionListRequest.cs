using EMS.Application.DTO.OrgDivision;
using MediatR;

namespace EMS.Application.Features.OrgDivision.Requests.Queries
{
    public class GetOrgDivisionListRequest: IRequest<List<OrgDivisionDto>>
    {
    }
}
