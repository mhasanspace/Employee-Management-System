using EMS.Domain.Common;

namespace EMS.Domain.Models
{
    public class Department: BaseModelEntity
    {
        public int OrgDivisionId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public int? Status { get; set; }
    }
}
