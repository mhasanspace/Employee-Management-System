using EMS.Domain.Common;

namespace EMS.Domain.Models
{
    public class OrgDivision: BaseModelEntity
    {
        public string Name { get; set; }
        public int? Status { get; set; }
    }
}
