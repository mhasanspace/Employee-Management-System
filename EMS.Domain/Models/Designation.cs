using EMS.Domain.Common;

namespace EMS.Domain.Models
{
    public class Designation: BaseModelEntity
    {
        public int DepartmentId { get; set; }
        public string DesignationName { get; set; }
        public string DesignationCode { get; set; }
        public int? Status { get; set; }
    }
}
